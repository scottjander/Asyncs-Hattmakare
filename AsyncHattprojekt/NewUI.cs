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
            CustomizeDesign();
            OpenChildForm(new Home());
        }

        private void CustomizeDesign()
        {
            panelPurchaseSubmenu.Visible = false;
            panelOrderSubMenu.Visible = false;
            panelStorageSubMenu.Visible = false;
            panelEconomySubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelPurchaseSubmenu.Visible == true)
                panelPurchaseSubmenu.Visible = false;

            if (panelOrderSubMenu.Visible == true)
                panelOrderSubMenu.Visible = false;

            if (panelStorageSubMenu.Visible == true)
                panelStorageSubMenu.Visible = false;

            if (panelEconomySubMenu.Visible == true)
                panelEconomySubMenu.Visible = false;
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
            panelBoarder.BackColor = color;
            panelOrder.BackColor = color;
            panelMenu.BackColor = color;
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
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

        public static void SetOrderInfo(string orderID,string customer)
        {
            lblOrder.Text = orderID;
            lblCustomer.Text = customer;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnHome.BackColor);
            OpenChildForm(new Home());

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

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnPurchase.BackColor);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOrderSubMenu);

        }

        private void btnListOfCreatedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            OpenChildForm(new ListOfCreatedOrders());


        }

        private void btnListOfStartedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            OpenChildForm(new ListOfStartedOrders());

        }

        private void btnListOfFinishedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            OpenChildForm(new ListOfFinishedOrders());

        }

        private void btnOrderHantering_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            //OpenChildForm(new OrderHantering());

        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStorageSubMenu);

        }

        private void btlMatrialVy_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnStorage.BackColor);
            OpenChildForm(new MaterialVy());

        }

        private void btnAddFabric_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnStorage.BackColor);

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnCustomer.BackColor);
            OpenChildForm(new CustomerRegisterForm());

        }

        private void btnEconomy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEconomySubMenu);
        }

        private void btnCreateInvoiceFromSupplier_Click(object sender, EventArgs e)
        {
            setMenuColor(btnEconomy.BackColor);
            OpenChildForm(new CreateInvoiceFromSupplier());

        }

        private void btnTaxSummary_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnEconomy.BackColor);
            OpenChildForm(new TaxesSummary());

        }

        private void NewUI_Load(object sender, EventArgs e)
        {

        }

        private void btnChoseCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateOrder());
        }
    }
}
