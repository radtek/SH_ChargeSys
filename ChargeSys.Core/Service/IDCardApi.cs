using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Core.Service
{
   public  class IDCardApi
    {
        #region API声明

        //二代证相关API---------------------------------------------------------------------------------------
        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
       public  static extern int SDT_GetCOMBaud(int iPort, ref uint puiBaudRate);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_SetCOMBaud(int iPort, uint uiCurrBaud, uint uiSetBaud);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_StartFindIDCard(int iPort, byte[] pucManaInfo, int iIfOpen);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_SelectIDCard(int iPort, byte[] pucManaMsg, int iIfOpen);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_ReadBaseMsg(int iPort, byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg, ref uint puiPHMsgLen, int iIfOpen);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_ReadBaseFPMsg(int iPort, byte[] pucCHMsg, ref uint puiCHMsgLen, byte[] pucPHMsg, ref uint puiPHMsgLen, byte[] pucFPMsg, ref uint puiFPMsgLen, int iIfOpen);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_GetSAMIDToStr(int iPort, StringBuilder pcSAMID, int iIfOpen);

        [DllImport("sdtapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int SDT_ReadNewAppMsg(int iPort, byte[] pucAppMsg, ref uint puiAppMsgLen, int iIfOpen);

        //照片解码API---------------------------------------------------------------------------------------

        [DllImport("DLL_File.dll", CallingConvention = CallingConvention.Cdecl)]//注意这里的调用方式为Cdecl
        public static extern int unpack(byte[] szSrcWltData, byte[] szDstPicData, int iIsSaveToBmp);

        #endregion
    }
}
