using ChargeSys.Entitys;
using EASkins.Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChargeSys.Scan
{
    public partial class Form1 : FrmWithTitle
    {
        private Vbarapi m_vbarapi = new Vbarapi();

        public static Thread DecodeThread = null;

        delegate void UpdateCaptionControl(CaptionLabel captionLabel, string msg);

        //循环是否启动标记
        public static bool bIsLoop = false;

        public Form1()
        {
            InitializeComponent();
            autoDocker1.Initialize(this);
        }

        private void Init()
        {
            if (m_vbarapi.openDevice())
            {
                StartDecodeThread();
                //ShowRichTextBoxMsg(richTextBox1,"开始扫码");
            }
            else
            {
                MessageBox.Show("打开设备失败！");
            }
        }

        /// <summary>
        /// 方法：开始解码线程方法
        /// </summary>
        private void StartDecodeThread()
        {
            bIsLoop = true;
            DecodeThread = new Thread(new ThreadStart(DecodeThreadMethod));
            DecodeThread.IsBackground = true;
            DecodeThread.Start();
        }

        /// <summary>
        /// 方法：扫码线程方法
        /// </summary>
        private void DecodeThreadMethod()
        {
            string decoderesult = null;
            //ShowRichTextBoxMsgRef ShowRichTextBoxMsgRef_Instance = new ShowRichTextBoxMsgRef(ShowRichTextBoxMsg);
            UpdateCaptionControl updateCaptionControl = new UpdateCaptionControl(UpdateMsg);
            do
            {
                //+ Environment.NewLine
                decoderesult = Decoder();
                if (decoderesult != null)
                {
                    try
                    {
                        // decoderesult = new string(decoderesult.Where(c => !Char.IsWhiteSpace(c)).ToArray());
                        X18J52 x18J52 = JsonConvert.DeserializeObject<X18J52>(decoderesult.Substring(1, decoderesult.Length - 1));
                        //this.Invoke(ShowRichTextBoxMsgRef_Instance, new object[] { this.richTextBox1, decoderesult + Environment.NewLine });
                        PropertyInfo[] propertyInfos = x18J52.GetType().GetProperties();
                        foreach (var item in propertyInfos)
                        {
                            foreach (var con in panel1.Controls)
                            {
                                if (con is CaptionLabel)
                                {
                                    CaptionLabel captionLabel = con as CaptionLabel;
                                    if (captionLabel.Tag.ToString().Equals(item.Name))
                                    {
                                        object obj = item.GetValue(x18J52, null);
                                        string str = obj == null ? "" : obj.ToString();
                                        this.Invoke(updateCaptionControl, new object[] { captionLabel, str });
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        foreach (var con in panel1.Controls)
                        {
                            if (con is CaptionLabel)
                            {
                                CaptionLabel captionLabel = con as CaptionLabel;
                                this.Invoke(updateCaptionControl, new object[] { captionLabel, "" });
                            }
                        }
                    }
                    decoderesult = null;
                }
            }
            while (bIsLoop);
        }

        private void UpdateMsg(CaptionLabel captionLabel,string msg)
        {
            captionLabel.Text = msg;
        }

        public string Decoder()
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

        private void ShowRichTextBoxMsg(System.Windows.Forms.RichTextBox lpRichTextBox, string lpMsg)
        {
            lpRichTextBox.AppendText(lpMsg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopDecodeThread();
        }

        private void StopDecodeThread()
        {
            bIsLoop = false;
            if (DecodeThread != null)
            {
                DecodeThread.Abort();
                while (DecodeThread.ThreadState != ThreadState.Aborted)
                {
                    Thread.Sleep(50);
                }
            }
        }

        private void captionLabel1_Click(object sender, EventArgs e)
        {
            CaptionLabel captionLabel = (CaptionLabel)sender;
            Clipboard.SetDataObject(captionLabel.Text.Trim(), true);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
