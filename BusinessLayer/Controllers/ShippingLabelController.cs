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
            Graphics myGraphics = printForm.CreateGraphics();
            Size s = printForm.Size;
            MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(MemoryImage);
            memoryGraphics.CopyFromScreen(printForm.Location.X, printForm.Location.Y, 0, 0, s);
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
