using ChargeSys.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChargeSys.Core.Service
{
    public abstract class ScanService
    {
        private static Action<string> _action = null;

        private static Queue<string> _queue = new Queue<string>();

        private static AutoResetEvent _event = new AutoResetEvent(true);

        private static CancellationTokenSource _cancellationTokenSource = null;

        private static CancellationTokenSource _workcancellationTokenSource = null;

        private static Task _task = null;

        private static Task _workTask = null;

        private static Vbarapi m_vbarapi = new Vbarapi();

        public static void SetAction(Action<string> action) => _action = action;

        public static void Satrt()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _task = new Task(() =>
            {
                try
                {
                    if (m_vbarapi.openDevice())
                    {
                        LogHelper.Trace("打开设备成功");
                        while (true)
                        {
                            try
                            {
                                string s = Decoder();
                                if (s != null)
                                    EnQueue(s.Substring(1, s.Length - 1));
                            }
                            catch (Exception ex)
                            {
                                LogHelper.Error("解释扫码结果异常"+ex.Message);
                            }
                            Thread.Sleep(300);
                        }
                    }
                    else
                    {
                        LogHelper.Error("打开设备失败");
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("接收异常:" + ex.Message);
                }
            }, _cancellationTokenSource.Token);
            _task.Start();
        }

        private static string Decoder()
        {
            byte[] result;
            string sResult = null;
            int size;
            if (m_vbarapi.getResultStr(out result, out size))
            {

                //sResult = System.Text.Encoding.UTF8.GetString(result);
                string msg = System.Text.Encoding.UTF8.GetString(result);
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                sResult = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            }
            else
            {
                sResult = null;
            }
            return sResult;
        }

        public static void EnQueue(string s)
        {
            _queue.Enqueue(s);
            _event.Set();
        }

        public static void Work()
        {
            if (_action == null) throw new ArgumentNullException();
            _workcancellationTokenSource = new CancellationTokenSource();
            _workTask = new Task(() =>
            {
                try
                {
                    while (true)
                    {
                        _workcancellationTokenSource.Token.ThrowIfCancellationRequested();
                        if (_queue.Count > 0)
                        {
                            try
                            {
                                Monitor.Enter(AppHelper.AppLocker);
                                while (_queue.Count > 0)
                                {
                                    string s = _queue.Dequeue();
                                    _action.Invoke(s);
                                }
                            }
                            catch (Exception ex)
                            {
                                LogHelper.Error("任务处理异常" + ex.Message);
                            }
                            finally
                            {
                                Monitor.Exit(AppHelper.AppLocker);
                            }
                        }
                        _event.WaitOne();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("任务停止" + ex.Message);
                }
            }, _workcancellationTokenSource.Token);
            _workTask.Start();
        }

        public static void Close()
        {
            try
            {
                _cancellationTokenSource?.Cancel();
                _workcancellationTokenSource?.Cancel();
                m_vbarapi.closeDevice();
            }
            catch (Exception ex)
            {
                LogHelper.Debug("释放设备异常:"+ex.Message);
            }
        }
    }
}
