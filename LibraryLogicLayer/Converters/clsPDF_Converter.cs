using LibraryLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Charting;
using System.Xml.Linq;
using PdfSharp.Fonts;

namespace LibraryLogicLayer.Converters
{
    public class clsPDF_Converter : IF_Convertible
    {

        public bool Convert(DataTable dt, string FileName, string TableName)
        {
            bool result = false;
            try
            {
                using (PdfDocument doc = new PdfDocument())
                {
                    doc.Info.Title = $"pdf file Extracted from DataTable {TableName}";

                    PdfPage page = doc.AddPage();
                    page.Width = XUnit.FromMillimeter(210);
                    page.Height = XUnit.FromMillimeter(297);

                    // Create ONLY ONE XGraphics object for the page
                    using (XGraphics gfx = XGraphics.FromPdfPage(page))
                    {
                        XFont headerFont = new XFont("Times New Roman", 12, XFontStyleEx.Bold);
                        XFont cellFont = new XFont("Times New Roman", 10, XFontStyleEx.Regular);
                        double x = 60;
                        double y = 60;

                        // Add title if provided
                        if (!string.IsNullOrEmpty(doc.Info.Title))
                        {
                            XFont titleFont = new XFont("Times New Roman", 16, XFontStyleEx.Bold);
                            XRect titleRect = new XRect(0, y, page.Width.Point, 40);
                            XStringFormat titleFormat = new XStringFormat();
                            titleFormat.Alignment = XStringAlignment.Center;

                            gfx.DrawString(doc.Info.Title, titleFont, XBrushes.DarkBlue, titleRect, titleFormat);
                            y += 50;
                        }

                        // Add metadata (date generated)
                        XFont metadataFont = new XFont("Times New Roman", 8, XFontStyleEx.Italic);
                        string dateGenerated = $"Generated on: {DateTime.Now:MMMM dd, yyyy}";
                        gfx.DrawString(dateGenerated, metadataFont, XBrushes.Gray, 40, y);
                        y += 20;

                        // Draw table
                        DrawStyledTable(doc, gfx, dt, ref y, page);

                        doc.Save(FileName);
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        private void DrawStyledTable(PdfDocument doc,XGraphics gfx, DataTable dataTable, ref double y, PdfPage page)
        {
            XFont headerFont = new XFont("Times New Roman", 11, XFontStyleEx.Bold);
            XFont cellFont = new XFont("Times New Roman", 9, XFontStyleEx.Regular);

            double x = 40;
            double rowHeight = 30;
            double[] columnWidths = CalculateDynamicWidths(dataTable, page.Width.Point - 80);

            // Draw headers with gradient effect
            for (int col = 0; col < dataTable.Columns.Count; col++)
            {
                XRect rect = new XRect(x, y, columnWidths[col], rowHeight);

                // Fill header background
                gfx.DrawRectangle(XBrushes.BlueViolet, rect);
                gfx.DrawRectangle(XPens.Black, rect);

                // Draw header text in white
                XStringFormat format = new XStringFormat();
                format.Alignment = XStringAlignment.Center;
                format.LineAlignment = XLineAlignment.Center;

                gfx.DrawString(dataTable.Columns[col].ColumnName,
                               headerFont, XBrushes.White, rect, format);

                x += columnWidths[col];
            }

            y += rowHeight;

            // Draw data rows
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                x = 40;

                // Page break check
                if (y + rowHeight > page.Height.Point - 40)
                {
                    PdfPage newPage = doc.AddPage();
                    gfx = XGraphics.FromPdfPage(newPage);
                    y = 40;

                    // Redraw headers on new page
                    DrawStyledTable(doc,gfx, dataTable, ref y, page);
                    continue;
                }

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    XRect rect = new XRect(x, y, columnWidths[col], rowHeight);

                    // Alternate row colors
                    XBrush rowBrush =  XBrushes.White ;
                    gfx.DrawRectangle(rowBrush, rect);
                    gfx.DrawRectangle(XPens.Black, rect);

                    // Format cell value based on data type
                    string cellValue = FormatCellValue(dataTable.Rows[row][col]);

                    XStringFormat format = new XStringFormat();
                    format.Alignment = XStringAlignment.Center;
                    format.LineAlignment = XLineAlignment.Center;

                    gfx.DrawString(cellValue, cellFont, XBrushes.Black, rect, format);

                    x += columnWidths[col];
                }

                y += rowHeight;
            }
        }

        private double[] CalculateDynamicWidths(DataTable dataTable, double totalWidth)
        {
            GlobalFontSettings.UseWindowsFontsUnderWindows = true;
            double[] widths = new double[dataTable.Columns.Count];
            double[] maxContentWidths = new double[dataTable.Columns.Count];

            using (XGraphics gfx = XGraphics.CreateMeasureContext(new XSize(2000, 2000),
                   XGraphicsUnit.Point, XPageDirection.Downwards))
            {
                XFont font = new XFont("Times New Roman", 9, XFontStyleEx.Regular);

                // Calculate max content width for each column
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    double maxWidth = gfx.MeasureString(dataTable.Columns[col].ColumnName, font).Width;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        double stringWidth = gfx.MeasureString(row[col].ToString(), font).Width;
                        if (stringWidth > maxWidth)
                            maxWidth = stringWidth;
                    }

                    maxContentWidths[col] = maxWidth + 10; // Add padding
                }

                // Calculate proportional widths
                double totalContentWidth = maxContentWidths.Sum();
                for (int i = 0; i < widths.Length; i++)
                {
                    widths[i] = (maxContentWidths[i] / totalContentWidth) * totalWidth;
                }
            }

            return widths;
        }

        private string FormatCellValue(object value)
        {
            if (value is decimal || value is double || value is float)
            {
                return string.Format("{0:C}", value); // Format as currency
            }
            else if (value is DateTime)
            {
                return ((DateTime)value).ToString("yyyy-MM-dd");
            }

            return value.ToString();
        }
        private double[] CalculateColumnWidths(DataTable dataTable, double totalWidth)
        {
            double[] widths = new double[dataTable.Columns.Count];
            double equalWidth = totalWidth / dataTable.Columns.Count;

            // Give each column equal width
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                widths[i] = equalWidth;
            }

            return widths;
        }
    }
}
