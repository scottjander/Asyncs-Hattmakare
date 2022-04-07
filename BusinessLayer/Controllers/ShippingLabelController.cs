using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ShippingLabelController
    {

        public Bitmap MemoryImage;

        public PrintDocument PrintDocument = new PrintDocument();
    
        public void PrintLabel(Form printForm)
        {
            PrintDialog printDialog = new PrintDialog();
            Graphics myGraphics = printForm.CreateGraphics();
            Size s = printForm.Size;
            MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(MemoryImage);
            memoryGraphics.CopyFromScreen(printForm.Location.X, printForm.Location.Y, 0, 0, s);
            ShowPrinterChoices();
        }

        public void ShowPrinterChoices()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = PrintDocument;
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                PrintDocument.Print();
            }
        }

        public void printDocument_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(MemoryImage, 0, 0);
        }

        public void SetLabels(Address address, Customer customer)
        {
            
        }
    }

  
}
