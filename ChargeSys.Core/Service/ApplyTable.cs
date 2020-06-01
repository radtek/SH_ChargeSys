using ChargeSys.Common;
using ChargeSys.Common.Dtos;
using ChargeSys.Entitys;
using iTextSharp.text;
using iTextSharp.text.pdf;
using O2S.Components.PDFRender4NET;
using O2S.Components.PDFRender4NET.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeSys.Core.Service
{
    public class ApplyTable
    {
        private CarInfo _carInfo;
        private PdfHelper _pdfHelper = new PdfHelper();
        private static BaseFont baseFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private iTextSharp.text.Font BoldFont = null;
        private iTextSharp.text.Font NormalFont = null;
        private string _ticketNo;
        public ApplyTable(CarInfo carInfo,string ticketNo)
        {
            _carInfo = carInfo;
            _ticketNo = ticketNo;
            BoldFont = new iTextSharp.text.Font(baseFont, 20, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            NormalFont = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
        }

        public Bitmap CreatePDF()
        {
            Document doc = _pdfHelper.CreateDocumentA4(10, 10, 30, 10);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
            doc.Open();
            doc.NewPage();
            doc.Add(_pdfHelper.CreateTitleParagraph($"机动车牌证申请表", BoldFont));
            doc.Add(_pdfHelper.CreateTitleParagraph($" 排队票号：{_ticketNo}", NormalFont));

            PdfPCell pdfPCell = null;
            PdfPTable table = _pdfHelper.CreateTable(new float[] { 2, 3, 3, 3, 3, 3 }, doc);
            table.AddCell(_pdfHelper.CreateCell("申请人信息栏", NormalFont, Element.ALIGN_CENTER, 6));

            pdfPCell = _pdfHelper.CreateCell("机动车所有人", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.Rowspan = 3;
            table.AddCell(pdfPCell);

            table.AddCell(_pdfHelper.CreateCell("姓名/名称", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell(_carInfo?.Owner, NormalFont, Element.ALIGN_CENTER,2));
            table.AddCell(_pdfHelper.CreateCell("邮政编码", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("100010", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("邮寄地址", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER,4));
            table.AddCell(_pdfHelper.CreateCell("手机号码", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER,2));
            table.AddCell(_pdfHelper.CreateCell("固定电话", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));

            table.AddCell(_pdfHelper.CreateCell("代理人", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("姓名/名称", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("手机号码", NormalFont, Element.ALIGN_CENTER,1));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER,2));
            table.AddCell(_pdfHelper.CreateCell("申请业务事项", NormalFont, Element.ALIGN_CENTER, 6));
            doc.Add(table);

            table = _pdfHelper.CreateTable(new float[] { 0.3F, 0.7F, 1, 1, 1, 1 }, doc);
            table.AddCell(_pdfHelper.CreateCell("号牌种类", NormalFont, Element.ALIGN_CENTER, 2));
            table.AddCell(_pdfHelper.CreateCell(AppHelper.GetNameByCode(_carInfo?.PlateType,"HPZL"), NormalFont, Element.ALIGN_CENTER,2));  
            table.AddCell(_pdfHelper.CreateCell("号牌号码", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell(_carInfo?.PlateNo, NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("申请事项", NormalFont, Element.ALIGN_CENTER, 2));
            table.AddCell(_pdfHelper.CreateCell("申请原因及声明", NormalFont, Element.ALIGN_CENTER,4));

            PdfPTable table1;

            pdfPCell = _pdfHelper.CreateCell("号牌", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.Rowspan = 2;
            table.AddCell(pdfPCell);
            table.AddCell(_pdfHelper.CreateCell("□补领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□丢失        □灭失         □前号牌          □后号牌 ", NormalFont, Element.ALIGN_LEFT,4));     
            
            table.AddCell(_pdfHelper.CreateCell("□换领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□前号牌        □后号牌 ", NormalFont, Element.ALIGN_LEFT, 4));



            pdfPCell = _pdfHelper.CreateCell("行驶证", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.Rowspan = 2;
            table.AddCell(pdfPCell);

            table.AddCell(_pdfHelper.CreateCell("□补领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□丢失        □灭失   ", NormalFont, Element.ALIGN_LEFT, 4));

            table.AddCell(_pdfHelper.CreateCell("□换领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell(" ", NormalFont, Element.ALIGN_CENTER, 4));

            pdfPCell = _pdfHelper.CreateCell("登记证书", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.Rowspan = 3;
            table.AddCell(pdfPCell);

            table.AddCell(_pdfHelper.CreateCell("□申领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("  ", NormalFont, Element.ALIGN_CENTER, 4));

            table.AddCell(_pdfHelper.CreateCell("□补领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□丢失        □灭失        □未获得", NormalFont, Element.ALIGN_LEFT, 4));       
            
            table.AddCell(_pdfHelper.CreateCell("□换领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("", NormalFont, Element.ALIGN_CENTER, 4));

            pdfPCell = _pdfHelper.CreateCell("检验合格标志", NormalFont, Element.ALIGN_CENTER);
            pdfPCell.Rowspan = 3;
            table.AddCell(pdfPCell);

            table.AddCell(_pdfHelper.CreateCell("□申请", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□在登记地车辆管理所申请        □在登记地以外车辆管理所申请 ", NormalFont, Element.ALIGN_LEFT, 4));

            table.AddCell(_pdfHelper.CreateCell("□补领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("□丢失        □灭失        ", NormalFont, Element.ALIGN_LEFT, 4));

            table.AddCell(_pdfHelper.CreateCell("□换领", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell(" ", NormalFont, Element.ALIGN_CENTER, 4));
            doc.Add(table);

            table = _pdfHelper.CreateTable(new float[] { 3, 3 }, doc);
            table.AddCell(_pdfHelper.CreateCell("  机动车所有人及代理人对申请材料的真实有效性负责", NormalFont, Element.ALIGN_LEFT));
            table.AddCell(_pdfHelper.CreateCell("机动车所有人(代理人签字)："+Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine+ "                     " +DateTime.Now.ToString("yyyy年MM月dd日").PadLeft("机动车所有人(代理人签字)：".Length*3,' '), NormalFont, Element.ALIGN_LEFT));
            
            //table1 = _pdfHelper.CreateTable(new float[] { 1 }, doc);
            //table1.AddCell(_pdfHelper.CreateNoWidthCell("机动车所有人(代理人签字)：", NormalFont, Element.ALIGN_LEFT));
            //table1.AddCell(_pdfHelper.CreateNoWidthCell("", NormalFont, Element.ALIGN_LEFT));
            //table1.AddCell(_pdfHelper.CreateNoWidthCell(DateTime.Now.ToString("yyyy年MM月dd日"), NormalFont, Element.ALIGN_LEFT));
            //PdfPCell cell1 = new PdfPCell(table1);
            //table.AddCell(cell1);
            doc.Add(table);

            table = _pdfHelper.CreateTable(new float[] { 1, 4 }, doc);
            table.AddCell(_pdfHelper.CreateCell("公安交警"+Environment.NewLine+"部门提示", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateCell("       《中华人民共和国道路交通安全法》第十六条规定，任何单位或者个人不得" +
                "拼装机动车或者擅自改变机动车已登记的结构、构造或者特征。构造或者特征。《机动车登记规公安交管定》" +
                " (公安部令第124号)第五十七条规定，擅自改变机动车外形和已登记的有部门提示关技术数据的， 由公安机关交通管理部门责令恢复原状，" +
                "并处警告或者五百元以下罚款。擅自改装机动车属于违法行为，应承担法律责任，因非法改装造成交通事故的，" +
                "还应承担相应交通事故责任。", NormalFont, Element.ALIGN_LEFT));

            doc.Add(table);
            doc.Close();

            MemoryStream memoryStream1 = new MemoryStream(memoryStream.ToArray());
            O2S.Components.PDFRender4NET.PDFFile pdfFile = O2S.Components.PDFRender4NET.PDFFile.Open(memoryStream1);
            System.Drawing.Bitmap pageImage = pdfFile.GetPageImage(0, 56 * (int)PdfHelper.Definition.Six);

            PrinterSettings settings = new PrinterSettings();
            PrintDocument pd = new PrintDocument();
            settings.PrinterName = AppHelper.AppSetting.PrinterName;
            settings.PrintToFile = false;
            PDFPrintSettings pdfPrintSettings = new PDFPrintSettings(settings);
            pdfPrintSettings.PageScaling = PageScaling.MultiplePagesPerSheetProportional;
            pdfPrintSettings.PrinterSettings.Copies = 1;
            LogHelper.Trace("开始打印" + AppHelper.AppSetting.PrinterName);
            pdfFile.Print(pdfPrintSettings);
            LogHelper.Trace("打印完成" + AppHelper.AppSetting.PrinterName);

            memoryStream.Close();
            memoryStream.Dispose();
            memoryStream1.Close();
            memoryStream1.Dispose();

            return pageImage;
        }

        public void PrintMsg()
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
                iTextSharp.text.Font BoldFont = new iTextSharp.text.Font(ArialFont, 17, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));

                ApplyTableSetting print = AppHelper.ApplyPointSetting;
                PdfContentByte pb = writer.DirectContent;
                pb.BeginText();
                pb.SetFontAndSize(ArialFont, 15);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("yyyy"), print.X_Year, print.Y_Year, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("MM"), print.X_Month, print.Y_Month, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, DateTime.Now.ToString("dd"), print.X_Day, print.Y_Day, 0);

                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_carInfo.Owner, print.X_Owner, print.Y_Owner, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "100021", print.X_Post, print.Y_Post, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_carInfo?.Addr??"", print.X_Addr, print.X_Addr, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_carInfo?.MobilePhone??"", print.X_MobilePhone, print.Y_MobilePhone, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_carInfo.PlateNo, print.X_PlateNo, print.Y_PlateNo, 0);
                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_carInfo.PlateType, print.X_PlateType, print.Y_PlateType, 0);

                pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT,_ticketNo, print.X_Ticket, print.Y_Ticket, 0);
                if(_carInfo.PlateNo.Contains("京"))
                    pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "√", print.X_Apply, print.Y_Apply, 0);
                else
                    pb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "√", print.X_Apply1, print.Y_Apply1, 0);

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
                LogHelper.Error("打印异常:" + ex.Message);
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
    }
}
