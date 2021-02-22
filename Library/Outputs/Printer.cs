using System;
using System.Drawing;
using System.Drawing.Printing;

namespace GC.Library.Outputs
{
    internal class Printer : PrintDocument
    {
        private Font font;
        private string text;
        private static int actualChar;

        internal string TextToPrint
        {
            get { return text; }
            set { text = value; }
        }

        internal Font PrinterFont
        {
            get { return font; }
            set { font = value; }
        }

        internal Printer() : base()
        {
            text = string.Empty;
        }

        internal Printer(string txt) : base()
        {
            text = txt;
        }

        protected override void OnBeginPrint(System.Drawing.Printing.PrintEventArgs e)
        {
            base.OnBeginPrint(e);
            if (font == null)
            {
                font = new Font("Verdana", 9);
            }
        }

        protected override void OnPrintPage(System.Drawing.Printing.PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            int height;
            int width;
            int left;
            int right;
            Int32 lines;
            Int32 chars;

            {
                height = base.DefaultPageSettings.PaperSize.Height - base.DefaultPageSettings.Margins.Top - base.DefaultPageSettings.Margins.Bottom;
                width = base.DefaultPageSettings.PaperSize.Width - base.DefaultPageSettings.Margins.Left - base.DefaultPageSettings.Margins.Right;
                left = base.DefaultPageSettings.Margins.Left;
                right = base.DefaultPageSettings.Margins.Top;  
            }

            if (base.DefaultPageSettings.Landscape)
            {
                int tmp;
                tmp = height;
                height = width;
                width = tmp;
            }

            Int32 numLines = (int)height / PrinterFont.Height;
            RectangleF area = new RectangleF(left, right, width, height);
            StringFormat format = new StringFormat(StringFormatFlags.LineLimit);
            e.Graphics.MeasureString(text.Substring(RemoveZeros(actualChar)), PrinterFont, new SizeF(width, height), format, out chars, out lines);
            e.Graphics.DrawString(text.Substring(RemoveZeros(actualChar)), PrinterFont, Brushes.Black, area, format);
            actualChar += chars;
            if (actualChar < text.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                actualChar = 0;
            }
        }

        private int RemoveZeros(int value)
        {
            switch (value)
            {
                case 0:
                    return 1;
                default:
                    return value;
            }
        }

        private static PageSettings GetPrinterPageInfo(String printerName)
        {
            PrinterSettings settings;

            if (String.IsNullOrEmpty(printerName))
            {
                foreach (var printer in PrinterSettings.InstalledPrinters)
                {
                    settings = new PrinterSettings();

                    settings.PrinterName = printer.ToString();

                    if (settings.IsDefaultPrinter)
                        return settings.DefaultPageSettings;
                }
                return null;
            }

            settings = new PrinterSettings();

            settings.PrinterName = printerName;

            return settings.DefaultPageSettings;
        }

        private static PageSettings GetPrinterPageInfo()
        {
            return GetPrinterPageInfo(null);
        }

        internal static void PrintText(string text, Font font)
        {
            Printer print = new Printer();
            if(font == null)
            {
                print.PrinterFont = new Font("Verdana", 9);
            }
            else
            {
                print.PrinterFont = font;
            }
            print.TextToPrint = text;
            print.Print();

            PageSettings page = GetPrinterPageInfo();

            RectangleF area = page.PrintableArea;
            Rectangle bounds = page.Bounds;
            Margins margins = page.Margins;
        }            
    }
}
