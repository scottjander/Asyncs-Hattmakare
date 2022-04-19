using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using DataLayer.Models.Enums;

namespace AsyncHattprojekt
{
    
    public partial class ManageHatts : Form
    {
        private StandardHatController standardHatController = new StandardHatController();
        public ManageHatts()
        {
            InitializeComponent();
            Testklassen testklassen = new Testklassen();
            testklassen.FillHat();
            ShowHatStock();
        }

        private void ShowHatStock()
        {
            int size = (int) HatSize.S52;
            lbl52Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int) HatSize.S54;
            lbl54Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int) HatSize.S56;
            lbl56Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int) HatSize.S58;
            lbl58Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int)HatSize.S60;
            lbl60Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int)HatSize.S62;
            lbl62Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
            size = (int)HatSize.S64;
            lbl64Amount.Text = standardHatController.GetSizeOfHats(size).ToString();
        }
    }
}
