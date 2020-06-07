using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core;
using ChargeSys.Core.Service;
using ChargeSys.Entitys;
using ChargeSys.Main.Api;
using HZH_Controls.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Live0xUtils.RegexUtils;
using Newtonsoft.Json;
using O2S.Components.PDFRender4NET;
using O2S.Components.PDFRender4NET.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ChargeSys.Main.Forms
{
    public partial class RegisterForm : FrmWithTitle
    {

        private X18J52 m_18J52 = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //查询前清空之前的数据
            picQRCode.BackgroundImage = null;
            m_18J52 = new X18J52();
            carFiller.DisplayEntity(null);

            string hphm = combQueryAera.Text + txtQueryPlateNo.Text.Trim();
            string vin = txtQueryVIN.Text.Trim();
            string hpzl = AppHelper.GetCodeByName(combQueryPlateType.Text, "HPZL");
            // string result = "";
            string loginUser = "";
            ResponseModel responseModel = new ResponseModel();
            LoadingForm frmLoading = new LoadingForm("正在查询...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "正在查询...");
                    NetHelper netHelper = new NetHelper();

                    Api.QueryVehicleApi queryVehicleApi = new Api.QueryVehicleApi();
                    responseModel = queryVehicleApi.Query18J52(hphm, loginUser, hpzl, vin);

                    //result = netHelper.QueryCar(hphm, hpzl, loginUser, vin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询时出现错误：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();

            //if (string.IsNullOrEmpty(result))
            //{
            //    FrmTips.ShowTipsError(AppHelper.MainForm, "查询结果为空", ContentAlignment.MiddleCenter); 
            //    return;
            //}
            //LogHelper.Trace("查询信息:" + result);

            //  result = HttpUtility.HtmlDecode(result);
            //string code = RegexXML.MatchField(result, "code", false);
            if (1.Equals(responseModel.Code))
            {
                //m_18J52 = RegexXML.XmlToModelByName<X18J52>(result);

                m_18J52 = JsonConvert.DeserializeObject<X18J52>(responseModel.Data?.ToString());
                m_18J52.BusinessType = combType.Text;

                //string js = JsonConvert.SerializeObject(x18J52);
                //Bitmap bitmap = Live0xUtils.QRCodeUtils.QRCodeHelper.CreateCode(js, -1, 3, true);
                //picQRCode.BackgroundImage = bitmap;

                DateTime d;
                if (m_18J52.ccrq != null && DateTime.TryParse(m_18J52.ccrq, out d))
                    m_18J52.ccrq = d.ToString("yyyy年MM月dd日");

                if (m_18J52.ccdjrq != null && DateTime.TryParse(m_18J52.ccdjrq, out d))
                    m_18J52.ccdjrq = d.ToString("yyyy年MM月dd日");

                m_18J52.cllx = AppHelper.GetNameByCode(m_18J52.cllx, "CLZL");
                m_18J52.hpzl = AppHelper.GetNameByCode(m_18J52.hpzl, "HPZL");

                carFiller.DisplayEntity(m_18J52);
            }
            else
            {
                MessageBox.Show(responseModel.Message);
            }
            //else if (string.IsNullOrEmpty(code))
            //{
            //    MessageBox.Show("查询信息为空" + result);
            //}
            //else
            //{
            //    MessageBox.Show(RegexXML.MatchField(result, "message", false));
            //}
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (!validator1.Validate())
            //    return;

            if (m_18J52 == null) return;

            string bType = combType.Text;
            string hpzl = combQueryPlateType.Text;
            m_18J52.BusinessType = bType;
            string js = JsonConvert.SerializeObject(m_18J52);
            Bitmap bitmap = Live0xUtils.QRCodeUtils.QRCodeHelper.CreateCode(js, -1, 3, true);
            picQRCode.BackgroundImage = bitmap;

            LoadingForm frmLoading = new LoadingForm("正在打印...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    try
                    {
                        frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "正在打印...");
                        byte[] buffer = null;


                        if (picQRCode.BackgroundImage != null)
                        {
                            picQRCode.BackgroundImage.Save(memoryStream, ImageFormat.Png);
                            buffer = new byte[memoryStream.Length];
                            memoryStream.Seek(0, SeekOrigin.Begin);
                            memoryStream.Read(buffer, 0, buffer.Length);
                        }
                        frmLoading.CurrentMsg = new KeyValuePair<int, string>(40, "正在打印...");

                        m_18J52.BusinessType = bType;
                        CreatePDF(m_18J52, hpzl, buffer);
                        frmLoading.CurrentMsg = new KeyValuePair<int, string>(100, "正在打印...");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            };
            frmLoading.ShowDialog();
        }

        private void CreatePDF(X18J52 x18J52, string hpzl, byte[] qrcode)
        {

            PdfHelper pdfHelper = new PdfHelper();
            Document doc = pdfHelper.CreateDocumentA4();
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            try
            {
                doc.Open();
                doc.NewPage();

                BaseFont ArialFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font BoldFont = new iTextSharp.text.Font(ArialFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));

                //二维码
                iTextSharp.text.Image img = pdfHelper.CreateImage(qrcode, 100, 100f);
                img.SetAbsolutePosition(AppHelper.PointSetting.X_QRCode, AppHelper.PointSetting.Y_QRCode);
                doc.Add(img);

                PrintPoint print = AppHelper.PointSetting;
                PdfContentByte pb = writer.DirectContent;
                pb.BeginText();
                pb.SetFontAndSize(ArialFont, 9);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("yyyy"), print.X_Year, print.Y_Year, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("MM"), print.X_Month, print.Y_Month, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("dd"), print.X_Day, print.Y_Day, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.hphm, print.X_PlateNo, print.Y_PlateNo, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.syr, print.X_Owner, print.Y_Owner, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, hpzl, print.X_PlateType, print.Y_PlateType, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "", print.X_PlateColor, print.Y_PlateColor, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.cllx, print.X_CarType, print.Y_CarType, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.clpp1, print.X_CarBrand, print.Y_CarBrand, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.clxh, print.X_CarMold, print.Y_CarMold, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.ccdjrq, print.X_RegisterDate, print.Y_RegisterDate, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.ccrq, print.X_MakeDate, print.Y_MakeDate, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.zzl, print.X_Weight, print.Y_Weight, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, x18J52.zbzl, print.X_KerbWeight, print.Y_KerbWeight, 0);

                pb.EndText();

                doc.Close();
                MemoryStream pdf = new MemoryStream(memoryStream.ToArray());
                PDFFile pdfFile = PDFFile.Open(pdf);

                PrinterSettings settings = new PrinterSettings();
                PrintDocument pd = new PrintDocument();
                settings.PrinterName = AppHelper.AppSetting.PrinterName;
                settings.PrintToFile = false;

                PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
                pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional;
                pdfPrintSettings.PrinterSettings.Copies = 1;
                pdfFile.Print(pdfPrintSettings);
                pdf.Close();
                pdf.Dispose();
                pdfFile.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印异常" + ex.Message);
            }
            finally
            {
                memoryStream.Dispose();
                memoryStream.Close();
                writer.Dispose();
                doc.Dispose();
                doc.Close();
            }
        }

        private void btnReadIDCard_Click(object sender, EventArgs e)
        {

            int iPort = 0;
            int iResult = 0;
            int iIfOpen = 1;//自动打开设备标志。如果设置为1，则在接口内部自动实现打开设备和关闭设备，无需调用者再添加。
            string strMsg = "";
            string strIDBase = "";

            StringBuilder strSAMID = new StringBuilder(64 + 1);

            byte[] byCHMsg = new byte[256 + 1];        //个人基本信息
            uint uiCHMsgSize = 0;                       //个人基本信息字节数
            byte[] byPHMsg = new byte[1024 + 1];       //照片信息
            uint uiPHMsgSize = 0;	                    //照片信息字节数
            byte[] byFPMsg = new byte[1024 + 1];       //指纹信息
            uint uiFPMsgSize = 0;                       //指纹信息字节数

            byte[] byFgnCardSign = new byte[2];       //证件类型标识

            int iIsSaveToBmp = 0;

            byte[] byBgrBuffer = new byte[38556];    //解码后图片BGR编码值
            byte[] byRgbBuffer = new byte[38808];    //解码后图片RGB编码值
            byte[] byBmpBuffer = new byte[38862];    //解码后图片RGB编码值

            uint uiDevBaud = 0;
            uint uiCurBaud = 0;



            iPort = 3;//获得端口号
                      ////////////////////////////////////////////////////////////////////
                      //以下为串口波特率设置
            if ((iPort <= 16) && (iPort >= 1))//是否为串口
            {
                uiCurBaud = Convert.ToUInt32(115200);  //获得当前波特率
                uiDevBaud = uiCurBaud;
                iResult = IDCardApi.SDT_SetCOMBaud(iPort, uiDevBaud, uiCurBaud);//尝试设置设备波特率，判断设备波特率和当前波特率是否相同
                if (0x90 != iResult)
                {
                    //设置失败，说明波特率不同，获取设备波特率,
                    iResult = IDCardApi.SDT_GetCOMBaud(iPort, ref uiDevBaud);
                    if (0x90 != iResult)
                    {
                        strMsg = String.Format("获取设备波特率失败，错误代码：{0:D}", iResult);
                        MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //修改设备波特率
                    iResult = IDCardApi.SDT_SetCOMBaud(iPort, uiDevBaud, uiCurBaud);
                    if (0x90 != iResult)
                    {
                        strMsg = String.Format("修改设备波特率失败，错误代码：{0:D}", iResult);
                        MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //获得设备SAM模块ID。
            //PS ：SAM模块ID为二代证设备唯一标志ID；
            //PS2：此函通常用来数来区分设备或判断设备是否连接正常；若只读卡信息的话无需添加此函数。
            iResult = IDCardApi.SDT_GetSAMIDToStr(iPort, strSAMID, iIfOpen);
            if (0x90 != iResult)
            {
                strMsg = String.Format("获取SAMID号失败，错误代码：{0:D}", iResult);
                MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] byManaID = new byte[8];

            //寻卡
            iResult = IDCardApi.SDT_StartFindIDCard(iPort, byManaID, iIfOpen);
            if (0x9F != iResult)
            {
                strMsg = String.Format("寻卡失败，错误代码：{0:D}", iResult);
                MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //选卡
            byManaID.Initialize();
            iResult = IDCardApi.SDT_SelectIDCard(iPort, byManaID, iIfOpen);
            if (0x90 != iResult)
            {
                strMsg = String.Format("选卡失败，错误代码：{0:D}", iResult);
                MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //读取身份证个人基本信息、照片信息和指纹信息；
            //PS：指纹信息需要专门的指纹比对设备，这里只获取加密的原始数据。
            iResult = IDCardApi.SDT_ReadBaseFPMsg(iPort, byCHMsg, ref uiCHMsgSize, byPHMsg, ref uiPHMsgSize, byFPMsg, ref uiFPMsgSize, iIfOpen);
            if (0x21 == iResult)//0501模块(一种老模块)无法读取指纹信息,会返回0x21错误，这里进行兼容处理；这种模块早就不用了，实际可以不做处理。
            {
                iResult = IDCardApi.SDT_ReadBaseMsg(iPort, byCHMsg, ref uiCHMsgSize, byPHMsg, ref uiPHMsgSize, iIfOpen);//采用只读卡信息和照片，不读指纹信息的接口
            }
            if (0x90 != iResult)
            {
                strMsg = String.Format("读取身份信息失败，错误代码：{0:D}", iResult);
                MessageBox.Show(strMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //截断数据获得证件类型标识
            Array.Copy(byCHMsg, 248, byFgnCardSign, 0, 2);

            var address = "";
            //判断类型标识，更新UI显示信息
            //大写字母'I'表示为外国人居住证，卡片返回身份信息数据默认为宽字符，这里采用直接判断字节的方法（宽字符大写字母'I'由2字节组成，分别为0x49 0x00）
            if ((byFgnCardSign[0] == 0x49) && (byFgnCardSign[1] == 0x00))
            {
                byte[] byFgnNameEN = new byte[120];     //Name EN
                byte[] byFgnSex = new byte[2];          //Sex
                byte[] byFgnCardNo = new byte[30];      //Card No
                byte[] byFgnNation = new byte[6];       //Nationality
                byte[] byFgnNameCN = new byte[30];      //Name CN
                byte[] byFgnValidityBeg = new byte[16]; //Period of Validity Begin
                byte[] byFgnValidityEnd = new byte[16]; //Period of Validity End
                byte[] byFgnBirth = new byte[16];        //Date of Birth
                byte[] byFgnCardVer = new byte[4];      //Card Version
                byte[] byFgnIssAuth = new byte[8];      //Issuing Authority

                Array.Copy(byCHMsg, 0, byFgnNameEN, 0, 120);
                Array.Copy(byCHMsg, 120, byFgnSex, 0, 2);
                Array.Copy(byCHMsg, 122, byFgnCardNo, 0, 30);
                Array.Copy(byCHMsg, 152, byFgnNation, 0, 6);
                Array.Copy(byCHMsg, 158, byFgnNameCN, 0, 30);
                Array.Copy(byCHMsg, 188, byFgnValidityBeg, 0, 16);
                Array.Copy(byCHMsg, 204, byFgnValidityEnd, 0, 16);
                Array.Copy(byCHMsg, 220, byFgnBirth, 0, 16);
                Array.Copy(byCHMsg, 236, byFgnCardVer, 0, 4);
                Array.Copy(byCHMsg, 240, byFgnIssAuth, 0, 8);

                //显示结果
                strIDBase = "读卡成功.\r\n\r\n";
                strIDBase += "英文姓名： " + Encoding.Unicode.GetString(byFgnNameEN).Trim() + "\r\n\r\n";
                strIDBase += "性别： " + Encoding.Unicode.GetString(byFgnSex).Trim() + "\r\n\r\n";
                strIDBase += "永久居留证号： " + Encoding.Unicode.GetString(byFgnCardNo).Trim() + "\r\n\r\n";
                strIDBase += "国籍或所在地区代码： " + Encoding.Unicode.GetString(byFgnNation).Trim() + "\r\n\r\n";
                strIDBase += "中文姓名： " + Encoding.Unicode.GetString(byFgnNameCN).Trim() + "\r\n\r\n";
                strIDBase += "证件签发日期： " + Encoding.Unicode.GetString(byFgnValidityBeg).Trim() + "\r\n\r\n";
                strIDBase += "证件终止日期： " + Encoding.Unicode.GetString(byFgnValidityEnd).Trim() + "\r\n\r\n";
                strIDBase += "出生日期： " + Encoding.Unicode.GetString(byFgnBirth).Trim() + "\r\n\r\n";
                strIDBase += "证件版本号： " + Encoding.Unicode.GetString(byFgnCardVer).Trim() + "\r\n\r\n";
                strIDBase += "当此申请受理机关代码： " + Encoding.Unicode.GetString(byFgnIssAuth).Trim() + "\r\n\r\n";
                strIDBase += "证件类型标识： " + Encoding.Unicode.GetString(byFgnCardSign).Trim() + "\r\n\r\n";
            }
            else if ((byFgnCardSign[0] == 0x4A) && (byFgnCardSign[1] == 0x00))//大写字母'I'（0x4A 0x00）表示为港澳台居住证
            {
                //截取个人信息数据。信息采用UNICODE存储，具体格式参可见《港澳台居民居住证机读信息规范（试行版）》
                byte[] byName = new byte[30];
                byte[] bySex = new byte[2];
                byte[] byBirth = new byte[16];
                byte[] byAddress = new byte[70];
                byte[] byID = new byte[36];
                byte[] byCompany = new byte[30];
                byte[] byBeginDate = new byte[16];
                byte[] byEndDate = new byte[16];
                byte[] byPassID = new byte[18];
                byte[] byIssNum = new byte[4];

                Array.Copy(byCHMsg, 0, byName, 0, 30);
                Array.Copy(byCHMsg, 30, bySex, 0, 2);
                Array.Copy(byCHMsg, 36, byBirth, 0, 16);
                Array.Copy(byCHMsg, 52, byAddress, 0, 70);
                Array.Copy(byCHMsg, 122, byID, 0, 36);
                Array.Copy(byCHMsg, 158, byCompany, 0, 30);
                Array.Copy(byCHMsg, 188, byBeginDate, 0, 16);
                Array.Copy(byCHMsg, 204, byEndDate, 0, 16);
                Array.Copy(byCHMsg, 220, byPassID, 0, 18);
                Array.Copy(byCHMsg, 238, byIssNum, 0, 4);

                //显示结果
                strIDBase = "读卡成功.\r\n\r\n";
                strIDBase += "姓名： " + Encoding.Unicode.GetString(byName).Trim() + "\r\n\r\n";
                strIDBase += "性别： " + Encoding.Unicode.GetString(bySex).Trim() + "\r\n\r\n";
                strIDBase += "出生日期： " + Encoding.Unicode.GetString(byBirth).Trim() + "\r\n\r\n";
                strIDBase += "居住地址： " + Encoding.Unicode.GetString(byAddress).Trim() + "\r\n\r\n";
                strIDBase += "公民身份证号： " + Encoding.Unicode.GetString(byID).Trim() + "\r\n\r\n";
                strIDBase += "签发机关： " + Encoding.Unicode.GetString(byCompany).Trim() + "\r\n\r\n";
                strIDBase += "有效起始日期： " + Encoding.Unicode.GetString(byBeginDate).Trim() + "\r\n\r\n";
                strIDBase += "有效截止日期： " + Encoding.Unicode.GetString(byEndDate).Trim() + "\r\n\r\n";
                strIDBase += "通行证号码： " + Encoding.Unicode.GetString(byPassID).Trim() + "\r\n\r\n";
                strIDBase += "签发次数： " + Encoding.Unicode.GetString(byIssNum).Trim() + "\r\n\r\n";
                strIDBase += "证件类型标识： " + Encoding.Unicode.GetString(byFgnCardSign).Trim() + "\r\n\r\n";
            }
            else
            {
                //截取个人信息数据。信息采用UNICODE存储，具体格式参可见《二代证机读信息说明.doc》
                byte[] byName = new byte[30];
                byte[] bySex = new byte[2];
                byte[] byRace = new byte[4];
                byte[] byBirth = new byte[16];
                byte[] byAddress = new byte[70];
                byte[] byID = new byte[36];
                byte[] byCompany = new byte[30];
                byte[] byBeginDate = new byte[16];
                byte[] byEndDate = new byte[16];

                Array.Copy(byCHMsg, 0, byName, 0, 30);
                Array.Copy(byCHMsg, 30, bySex, 0, 2);
                Array.Copy(byCHMsg, 32, byRace, 0, 4);
                Array.Copy(byCHMsg, 36, byBirth, 0, 16);
                Array.Copy(byCHMsg, 52, byAddress, 0, 70);
                Array.Copy(byCHMsg, 122, byID, 0, 36);
                Array.Copy(byCHMsg, 158, byCompany, 0, 30);
                Array.Copy(byCHMsg, 188, byBeginDate, 0, 16);
                Array.Copy(byCHMsg, 204, byEndDate, 0, 16);

                //显示结果
                strIDBase = "读卡成功.\r\n\r\n";
                strIDBase += "姓名： " + Encoding.Unicode.GetString(byName).Trim() + "\r\n\r\n";
                strIDBase += "性别： " + Encoding.Unicode.GetString(bySex).Trim() + "\r\n\r\n";
                strIDBase += "民族： " + Encoding.Unicode.GetString(byRace).Trim() + "\r\n\r\n";
                strIDBase += "出生日期： " + Encoding.Unicode.GetString(byBirth).Trim() + "\r\n\r\n";
                strIDBase += "居住地址： " + Encoding.Unicode.GetString(byAddress).Trim() + "\r\n\r\n";
                address = Encoding.Unicode.GetString(byAddress).Trim();
                strIDBase += "公民身份证号： " + Encoding.Unicode.GetString(byID).Trim() + "\r\n\r\n";
                strIDBase += "签发机关： " + Encoding.Unicode.GetString(byCompany).Trim() + "\r\n\r\n";
                strIDBase += "有效起始日期： " + Encoding.Unicode.GetString(byBeginDate).Trim() + "\r\n\r\n";
                strIDBase += "有效截止日期： " + Encoding.Unicode.GetString(byEndDate).Trim() + "\r\n\r\n";
            }

            txtAddress.Text = address;
        }
    }
}
