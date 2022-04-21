using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncHattprojekt
{
    public partial class NewUI : Form
    {
        private Form activeForm = null;
        public NewUI()
        {
            InitializeComponent();
            customizeDesign();
            OpenChildForm(new Home());
            new CustomerRegisterForm();
        }

        private void customizeDesign()
        {
            panelPurchaseSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPurchaseSubmenu.Visible == true)
                panelPurchaseSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void setMenuColor(Color color)
        {
            PanelBoarder.BackColor = color;
            panelOrder.BackColor = color;
            panelMenu.BackColor = color;
        }

        public void OpenChildForm(Form childForm)
        {
            if ( activeForm != null )
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
            setMenuColor(btnHome.BackColor);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPurchaseSubmenu);
        }

        private void btnDHat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnPurchase.BackColor);
        }

        private void btnSHat_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnPurchase.BackColor);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            setMenuColor(btnOrder.BackColor);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnStock.BackColor);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerRegisterForm());
            setMenuColor(btnCustomer.BackColor);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnEconomy.BackColor);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void NewUI_Load(object sender, EventArgs e)
        {

        }
    }
}
