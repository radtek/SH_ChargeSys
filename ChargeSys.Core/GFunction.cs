using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Core
{
    public class GFunction
    {
        /// <summary>
        /// 将字节数组写入文件
        /// </summary>
        /// <param name="_i_strFileName">文件路径</param>
        /// <param name="_i_byData">写入字节数组</param>
        /// <param name="_i_iDataSize">字节数组大小</param>
        /// <returns></returns>
        static public bool tool_WriteOneFile(string _i_strFileName, byte[] _i_byData, int _i_iDataSize)
        {

            if (_i_iDataSize == 0)
            {
                return false;
            }

            FileStream fileStream = new FileStream(_i_strFileName, FileMode.Create);
            fileStream.Write(_i_byData, 0, _i_iDataSize);
            fileStream.Flush();
            fileStream.Close();

            return true;
        }

        /// <summary>
        /// 对BGR格式数据进行B、R转换，只支持24位深度图像
        /// </summary>
        /// <param name="_i_bySrc">bgr数据</param>
        /// <param name="_i_iSrcSize">bgr数据大小</param>
        /// <param name="_o_byDst">转换后的rgb格式数据，需要开((_i_iWidth * 3 + 3) / 4) * 4 * _i_iHeight字节空间</param>
        /// <param name="_i_iDstSize">开辟空间大小</param>
        /// <param name="_i_iWidth">图片宽度（像素）</param>
        /// <param name="_i_iHeight">图片高度（像素）</param>
        /// <returns>>0 执行成功，函数执行成功后返回转换后的rgb格式数据大小</returns>
        static public int bgr2rgb(byte[] _i_bySrc, int _i_iSrcSize, byte[] _o_byDst, int _i_iDstSize, int _i_iWidth, int _i_iHeight)
        {
            int iWidthSize = _i_iWidth * 3;
            int iDstWidthSize = ((_i_iWidth * 3 + 3) / 4) * 4;
            int iExternSize = ((_i_iWidth * 3 + 3) / 4) * 4 - _i_iWidth * 3;
            int iDstSize = iDstWidthSize * _i_iHeight;
            int iPosX = 0;
            int iPosY = 0;

            if (_i_iSrcSize != (iWidthSize * _i_iHeight))
            {
                return -1;
            }

            if (_i_iDstSize < iDstSize)
            {
                return -2;
            }

            for (iPosY = 0; iPosY < _i_iHeight; iPosY++)
            {
                for (iPosX = 0; iPosX < _i_iWidth * 3; iPosX += 3)
                {
                    _o_byDst[(iWidthSize + iExternSize) * iPosY + iPosX + 0] = _i_bySrc[iWidthSize * iPosY + iPosX + 2];
                    _o_byDst[(iWidthSize + iExternSize) * iPosY + iPosX + 1] = _i_bySrc[iWidthSize * iPosY + iPosX + 1];
                    _o_byDst[(iWidthSize + iExternSize) * iPosY + iPosX + 2] = _i_bySrc[iWidthSize * iPosY + iPosX + 0];
                }
            }

            return iDstSize;
        }

        /// <summary>
        /// 字节数组转16进制字符串
        /// </summary>
        /// <param name="_i_bySrc">字节数组</param>
        /// <param name="_i_iSrcPosIdx">字节数组偏移量</param>
        /// <param name="_i_iSrcSize">转换字节数</param>
        /// <returns>16进制字符串</returns>
        public static string ByteArryToHexString(byte[] _i_bySrc, int _i_iSrcPosIdx, int _i_iCount)
        {
            int iPos = 0;
            StringBuilder strResult = new StringBuilder();

            for (iPos = 0; iPos < _i_iCount; iPos++)
            {
                strResult.Append(_i_bySrc[_i_iSrcPosIdx + iPos].ToString("X2"));
            }

            return strResult.ToString();
        }

        /// 16进制字符串转字节数组
        /// </summary>
        /// <param name="_i_strSrc">16进制字符串</param>
        /// <param name="_o_byDstBuffer">字节数组Buffer</param>
        /// <param name="_i_iDstBufferSize">字节数组Buffer大小</param>
        /// <returns>实际转换大小</returns>
        public static int HexStringToByteArray(string _i_strSrc, byte[] _o_byDstBuffer, int _i_iDstBufferSize)
        {
            int iPos = 0;
            int iDstSize = _i_strSrc.Length / 2;

            for (iPos = 0; (iPos < iDstSize) && (iPos < _i_iDstBufferSize); iPos++)
            {
                _o_byDstBuffer[iPos] = Convert.ToByte(_i_strSrc.Substring(iPos * 2, 2), 16);
            }

            return iDstSize;
        }
    }
}
