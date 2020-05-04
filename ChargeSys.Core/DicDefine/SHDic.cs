using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Core.DicDefine
{
    public  class SHDic
    {
        private static List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();

        private SHDic()
        {
            keyValuePairs.Add(new KeyValuePair<string, string>("9999", "超时"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1", "操作成功"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1001", "未定义"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1002", "格式错误"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1003", "未登陆"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1004", "操作失败"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1005", "分站不支持此接口"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1006", "没有找到出票的队列编号"));
            keyValuePairs.Add(new KeyValuePair<string, string>("1007", "未有等待人数"));

        }

        public static string GetSHDeifine(string code)
        {
            var keyValuePair = keyValuePairs.Where(p => code.Equals(p.Key)).FirstOrDefault();
            return keyValuePair.Value;
        }
    }
}
