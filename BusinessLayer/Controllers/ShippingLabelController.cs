using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace BusinessLayer
{
    public class ShippingLabelController
    {

        public Bitmap MemoryImage;

        public PrintDocument printDocument = new PrintDocument();
    
        public void PrintLabel(Form printForm)
        {
            PrintDialog printDialog = new PrintDialog();
            Graphics myGraphics = printForm.CreateGraphics();
            Size s = printForm.Size;
            MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(MemoryImage);
            memoryGraphics.CopyFromScreen(printForm.Location.X, printForm.Location.Y, -10, -40, s);


            ShowPrinterChoices();
        }

        public void ShowPrinterChoices()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public void printDocument_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(MemoryImage, 0, 0);
        }

        public Image GenerateBarCode(string enstring)
        {

            GeneratedBarcode OrderBarCode =
                IronBarCode.BarcodeWriter.CreateBarcode(enstring, BarcodeWriterEncoding.Code128);
            OrderBarCode.ResizeTo(774, 179);

            return OrderBarCode.Image;

        }   

    }

  
}
