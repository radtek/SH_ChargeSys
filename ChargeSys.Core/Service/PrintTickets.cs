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
    public class PrintTickets
    {
        private PdfHelper _pdfHelper = new PdfHelper();
        private static BaseFont baseFont = BaseFont.CreateFont("STZHONGS.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        private iTextSharp.text.Font BoldFont = null;
        private iTextSharp.text.Font NormalFont = null;

        private readonly ChargeRecord chargeRecord;
        private readonly List<ChargeDetail> details;

        public PrintTickets(ChargeRecord chargeRecord, List<ChargeDetail>  details)
        {
            BoldFont = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            NormalFont = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
            this.chargeRecord = chargeRecord;
            this.details = details;
        }


        public void Print()
        {
            int width = 200;
            int height = 297;
            if (details.Count > 3)
                height += (details.Count - 3) * 30;

            PdfHelper pdfHelper = new PdfHelper();
            Document doc = pdfHelper.CreateDocument(width, height);
            doc.SetMargins(10,10,10,10);
            MemoryStream memoryStream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

            doc.Open();
            doc.NewPage();
            doc.Add(_pdfHelper.CreateTitleParagraph("收费明细", NormalFont));

            PdfPTable table = _pdfHelper.CreateTable(new float[] { 4,3,3 }, doc);
            table.AddCell(_pdfHelper.CreateNoWidthCell($"车牌: {chargeRecord.PlateNo}", NormalFont, Element.ALIGN_LEFT, 3));
            table.AddCell(_pdfHelper.CreateNoWidthCell($"检测时间: {chargeRecord.DateOfTest}", NormalFont, Element.ALIGN_LEFT, 3));
            table.AddCell(_pdfHelper.CreateNoWidthCell($"收费时间: {chargeRecord.DateOfCharge}", NormalFont, Element.ALIGN_LEFT, 3));
            table.AddCell(_pdfHelper.CreateNoWidthCell($"收费人: {AppHelper.UserName}", NormalFont, Element.ALIGN_LEFT, 3));
            table.AddCell(_pdfHelper.CreateNoWidthCell("检验项目", NormalFont, Element.ALIGN_LEFT));
            table.AddCell(_pdfHelper.CreateNoWidthCell("次数", NormalFont, Element.ALIGN_CENTER));
            table.AddCell(_pdfHelper.CreateNoWidthCell("金额", NormalFont, Element.ALIGN_CENTER));

            foreach (var item in details)
            {
                table.AddCell(_pdfHelper.CreateNoWidthCell(item.TestItem, NormalFont, Element.ALIGN_LEFT));
                table.AddCell(_pdfHelper.CreateNoWidthCell(item.TestTimes.ToString(), NormalFont, Element.ALIGN_CENTER));
                table.AddCell(_pdfHelper.CreateNoWidthCell(item.Price.ToString(), NormalFont, Element.ALIGN_CENTER)) ;
            }
            table.AddCell(_pdfHelper.CreateNoWidthCell($"合计: {chargeRecord.Price}", NormalFont, Element.ALIGN_RIGHT,3));
            doc.Add(table);
            doc.Close();

            MemoryStream memoryStream1 = new MemoryStream(memoryStream.ToArray());
            O2S.Components.PDFRender4NET.PDFFile pdfFile = O2S.Components.PDFRender4NET.PDFFile.Open(memoryStream1);

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
        }
    }
}
