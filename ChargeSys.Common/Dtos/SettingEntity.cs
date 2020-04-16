using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChargeSys.Common.Dtos
{
    public class SettingEntity
    {
        public SettingEntity()
        {
        }

        public string DatabaseServer { get; set; }

        public string DatabaseName { get; set; }

        public string DatabaseUser { get; set; }

        public string DatabasePwd { get; set; }

        public string PrinterName { get; set; }

        public int TCP_Port { get; set; }

        public string StationNo { get; set; }

        public string LineNo { get; set; }

        public string SQLitePath { get; set; }

        public string UploadIP_GZYJ { get; set; }

        public int UploadPort_GZYJ { get; set; }

        public string GWBH { get; set; }

        public string Camera1_IP { get; set; }

        public string Camera1_Port { get; set; }

        public string Camera1_User { get; set; }

        public string Camera1_Pwd { get; set; }

        public string Camera2_IP { get; set; }

        public string Camera2_Port { get; set; }

        public string Camera2_User { get; set; }

        public string Camera2_Pwd { get; set; }

        public string WebServiceUrl { get; set; }

        public string WebNameSpace { get; set; }

        public string JKXLH { get; set; }

        public string Login_User { get; set; }

        public string Login_Pwd { get; set; }

        public string LineType { get; set; }

        public string Operator { get; set; }
    }
}
