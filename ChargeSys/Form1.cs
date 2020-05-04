using EASkins.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using O2S.Components.PDFRender4NET;
using System.Threading;
using ChargeSys.Entitys;
using Live0xUtils.RegexUtils;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using O2S.Components.PDFRender4NET.Printing;
using System.Web;
using CI.UIComponents.Helper;
using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Core;

namespace ChargeSys.Main
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            init();
            LoadPrinter();
        }

        public void init()
        {
            settingFiller.DisplayEntity(AppHelper.AppSetting);
            pointFiller.DisplayEntity(AppHelper.PointSetting);
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(AppHelper.AppSetting);
            File.WriteAllText(AppHelper.SettingPath,JsonConvert.SerializeObject(AppHelper.AppSetting,Formatting.Indented));
            MessageBox.Show("保存成功");
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //查询前清空之前的数据
            picQRCode.BackgroundImage = null;
            carFiller.DisplayEntity(null);

            string hphm = combQueryAera.Text + txtQueryPlateNo.Text.Trim();
            string vin = txtQueryVIN.Text.Trim();
            string hpzl = AppHelper.GetCodeByName(combQueryPlateType.Text,"HPZL");
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
                MessageBox.Show("查询结果为空");
                return;
            }

            File.WriteAllText("18J52.txt", result);

            result = HttpUtility.HtmlDecode(result);
            string code = RegexXML.MatchField(result, "code", false);
            if ("1".Equals(code))
            {
                X18J52 x18J52 = RegexXML.XmlToModelByName<X18J52>(result);
                string js = JsonConvert.SerializeObject(x18J52);
                Bitmap bitmap = Live0xUtils.QRCodeUtils.QRCodeHelper.CreateCode(js, -1, 3, true);
                picQRCode.BackgroundImage = bitmap;

                DateTime d;
                if (x18J52.ccrq != null && DateTime.TryParse(x18J52.ccrq, out d))
                    x18J52.ccrq = d.ToString("yyyy年MM月dd日");

                if (x18J52.ccdjrq != null && DateTime.TryParse(x18J52.ccdjrq, out d))
                    x18J52.ccdjrq = d.ToString("yyyy年MM月dd日");

                x18J52.cllx = AppHelper.GetNameByCode(x18J52.cllx, "CLZL");
                x18J52.hpzl = AppHelper.GetNameByCode(x18J52.hpzl, "HPZL");

                carFiller.DisplayEntity(x18J52);
            }
            else if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("查询信息为空"+ result);
            }
            else
            {
                MessageBox.Show(RegexXML.MatchField(result, "message", false));
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            //标题字体
            System.Drawing.Font titleFont = new System.Drawing.Font("微软雅黑", 16, FontStyle.Bold);
            //标题尺寸
            SizeF titleSize = e.Graphics.MeasureString("测试", titleFont, e.MarginBounds.Width);
            //x坐标
            int x = e.MarginBounds.Left;
            //y坐标
            int y = Convert.ToInt32(e.MarginBounds.Top - titleSize.Height);
            //边距以内纸张宽度
            int pagerWidth = e.MarginBounds.Width;
            //画标题
            e.Graphics.DrawString("测试", titleFont, Brushes.Black, x + (pagerWidth - titleSize.Width) / 2, y);
        }

        private void CreatePDF(X18J52 x18J52,string hpzl, byte[] qrcode)
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
                MessageBox.Show("打印异常"+ ex.Message);
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


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!validator1.Validate())
                return;
            string hpzl = combQueryPlateType.Text;
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
                        X18J52 x18J52 = new X18J52();
                        carFiller.FillEntity(x18J52);
                        CreatePDF(x18J52, hpzl, buffer);
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

        public void LoadPrinter()
        {
            string tt = string.Empty;
            PrintDocument prtdoc = new PrintDocument();
            List<string> list = new List<string>();
            foreach (String str in PrinterSettings.InstalledPrinters)
            {
                combPrinter.Items.Add(str);
            }

        }

        private void btnSavePoint_Click(object sender, EventArgs e)
        {
            pointFiller.FillEntity(AppHelper.PointSetting);
            File.WriteAllText(AppHelper.PrintConfigPath, JsonConvert.SerializeObject(AppHelper.PointSetting, Formatting.Indented));
            MessageBox.Show("保存成功");
        }

        private void CreatePDF(string hphm, string vin, string business, string carType, string chekItem, string weight, string makeDate, byte[] qrcode)
        {
            PdfHelper pdfHelper = new PdfHelper();
            Document doc = pdfHelper.CreateDocument(500, 500);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            doc.Open();
            doc.NewPage();

            BaseFont ArialFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font BoldFont = new iTextSharp.text.Font(ArialFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
            iTextSharp.text.Font HeadFont = new iTextSharp.text.Font(ArialFont, 11, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Red));
            PdfPTable tableVIN = pdfHelper.CreateTable(new float[] { 1, 1, 1, 1, 1 }, doc);
            tableVIN.AddCell(pdfHelper.CreateCell("号牌号码", BoldFont, Element.ALIGN_RIGHT));
            tableVIN.AddCell(pdfHelper.CreateCell(hphm, HeadFont, Element.ALIGN_CENTER));
            tableVIN.AddCell(pdfHelper.CreateCell("VIN", BoldFont, Element.ALIGN_RIGHT));
            tableVIN.AddCell(pdfHelper.CreateCell(vin, HeadFont, Element.ALIGN_CENTER, 2));
            doc.Add(tableVIN);

            PdfPTable tableMsg = pdfHelper.CreateTable(new float[] { 1, 1, 1, 1 }, doc);

            tableMsg.AddCell(pdfHelper.CreateCell("业务类型", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell(business, BoldFont, Element.ALIGN_CENTER));
            tableMsg.AddCell(pdfHelper.CreateCell("车辆类型", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell(carType, BoldFont, Element.ALIGN_CENTER));
            tableMsg.AddCell(pdfHelper.CreateCell("检测项目", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell(chekItem, BoldFont, Element.ALIGN_CENTER));
            tableMsg.AddCell(pdfHelper.CreateCell("总质量", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell(weight, BoldFont, Element.ALIGN_CENTER));
            tableMsg.AddCell(pdfHelper.CreateCell("环保登记", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell("", BoldFont, Element.ALIGN_CENTER));
            tableMsg.AddCell(pdfHelper.CreateCell("出厂日期", BoldFont, Element.ALIGN_RIGHT));
            tableMsg.AddCell(pdfHelper.CreateCell(makeDate, BoldFont, Element.ALIGN_CENTER));

            PdfPCell qrCell = null;
            if (qrcode != null)
                qrCell = new PdfPCell(pdfHelper.CreateImage(qrcode, 100f, 100f));
            else
                qrCell = pdfHelper.CreateCell("", BoldFont, Element.ALIGN_CENTER);
            //qrCell.Rowspan = 3;
            qrCell.Padding = 2;
            tableMsg.AddCell(qrCell);
            //tableMsg.AddCell(pdfHelper.CreateCell(" ", BoldFont, Element.ALIGN_LEFT, false, 3, false));
            //tableMsg.AddCell(pdfHelper.CreateCell("Admin", BoldFont, Element.ALIGN_LEFT,false,3,false));
            tableMsg.AddCell(pdfHelper.CreateCell("Admin\r\n\r\n" + DateTime.Now.ToString("yyyy年MM月dd日  HH:mm:ss"), BoldFont, Element.ALIGN_LEFT, false, 3, false));

            doc.Add(tableMsg);
            doc.Close();
            MemoryStream pdf = new MemoryStream(memoryStream.ToArray());
            PDFFile pdfFile = PDFFile.Open(pdf);
            //Bitmap pageImage  = pdfFile.GetPageImage(0,56 * (int)PdfHelper.Definition.Six);

            PrinterSettings settings = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            settings.PrinterName = "Adobe PDF";
            settings.PrintToFile = false;

            //设置纸张大小（可以不设置，取默认设置）3.90 in,  8.65 in
            //PaperSize ps = new PaperSize("test", 4, 9);
            // ps.RawKind = 9; //如果是自定义纸张，就要大于118，（A4值为9，详细纸张类型与值的对照请看http://msdn.microsoft.com/zh-tw/library/system.drawing.printing.papersize.rawkind(v=vs.85).aspx）

            PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
            //pdfPrintSettings.PaperSize = ps;
            pdfPrintSettings.PageScaling = O2S.Components.PDFRender4NET.Printing.PageScaling.MultiplePagesPerSheetProportional;
            pdfPrintSettings.PrinterSettings.Copies = 1;
            pdfFile.Print(pdfPrintSettings);

            // MemoryStream pic = new MemoryStream();
            //pageImage.Save(pic, ImageFormat.Png);
            //pageImage.Save("测试.png", ImageFormat.Png);
            pdf.Close();
            pdf.Dispose();
            //pageImage.Dispose();
            pdfFile.Dispose();
            // picQRCode.BackgroundImage = System.Drawing.Image.FromStream(pic);
        }
        private int printShow(string url)
        {
            int isOK = 0;
            PDFFile file = PDFFile.Open(url);
            PrinterSettings settings = new PrinterSettings();
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            settings.PrinterName = "\\\\192.168.2.93\\Brother DCP-7030 Printer";
            settings.PrintToFile = false;

            //设置纸张大小（可以不设置，取默认设置）3.90 in,  8.65 in
            //PaperSize ps = new PaperSize("test", 4, 9);
            //ps.RawKind = 9; //如果是自定义纸张，就要大于118，（A4值为9，详细纸张类型与值的对照请看http://msdn.microsoft.com/zh-tw/library/system.drawing.printing.papersize.rawkind(v=vs.85).aspx）

            O2S.Components.PDFRender4NET.Printing.PDFPrintSettings pdfPrintSettings = new O2S.Components.PDFRender4NET.Printing.PDFPrintSettings(settings);
            //pdfPrintSettings.PaperSize = ps;
            pdfPrintSettings.PageScaling = O2S.Components.PDFRender4NET.Printing.PageScaling.FitToPrinterMarginsProportional;
            pdfPrintSettings.PrinterSettings.Copies = 1;

            try
            {
                file.Print(pdfPrintSettings);
                isOK = 1;
            }
            catch (Exception)
            {
                isOK = -1;
                throw;
            }
            finally
            {

                file.Dispose();
            }
            return isOK;
        }
    }
}
