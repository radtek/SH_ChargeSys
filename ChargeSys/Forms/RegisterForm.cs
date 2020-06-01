using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core;
using ChargeSys.Core.Service;
using ChargeSys.Entitys;
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
            string result = "";
            string loginUser = "";

            LoadingForm frmLoading = new LoadingForm("正在查询...");
            frmLoading.BackgroundWorkAction = delegate ()
            {
                try
                {
                    frmLoading.CurrentMsg = new KeyValuePair<int, string>(10, "正在查询...");
                    NetHelper netHelper = new NetHelper();
                    result = netHelper.QueryCar(hphm, hpzl, loginUser, vin);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询时出现错误：" + ex.Message);
                }
            };
            frmLoading.ShowDialog();

            if (string.IsNullOrEmpty(result))
            {
                FrmTips.ShowTipsError(AppHelper.MainForm, "查询结果为空", ContentAlignment.MiddleCenter); 
                return;
            }
            LogHelper.Trace("查询信息:" + result);

            result = HttpUtility.HtmlDecode(result);
            string code = RegexXML.MatchField(result, "code", false);
            if ("1".Equals(code))
            {
                m_18J52 = RegexXML.XmlToModelByName<X18J52>(result);
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
            else if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("查询信息为空" + result);
            }
            else
            {
                MessageBox.Show(RegexXML.MatchField(result, "message", false));
            }
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            //取号
            CallEntity call = CallService.GetNo("普通车".Equals(combType.Text) ? "B" : "A", txtPlateNo.Text);
            MessageBox.Show(call.ClientId);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            //叫号
            CallService.CallNo(AppHelper.AppSetting.WindowAddr, txtPlateNo.Text);
        }
    }
}
