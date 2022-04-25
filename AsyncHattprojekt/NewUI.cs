using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Controllers;
using DataLayer;
using DataLayer.Models;

namespace AsyncHattprojekt
{
    public partial class NewUI : Form
    {

        private Form activeForm = null;
        private OrderControllerScottRobin orderController = new OrderControllerScottRobin();
        private SpecialHatController specialHatController = new SpecialHatController();

        public NewUI()
        {
            
            InitializeComponent();
            lblUser.Text = InitialPage.username;
            CustomizeDesign();
            OpenChildForm(new Home());
            UpdateOrder();
            UpdatePrice();
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

        public void UpdateOrder()
        {
            if (lblOrder.Text == "0") {
                listViewHats.Items.Clear();
                return;
            }
            List<Hat> hatsInOrder = specialHatController.GetHatsOnOrderId(Convert.ToInt32(lblOrder.Text));
            List<SpecialHat> specialHatsInOrder =
                specialHatController.GetSpecialHatsOnOrderId(Convert.ToInt32(lblOrder.Text));

            listViewHats.Items.Clear();
                foreach (Hat hat in hatsInOrder) {
                    ListViewItem lvi = new ListViewItem(hat.itemName);
                    lvi.SubItems.Add(hat.Price.ToString());
                    listViewHats.Items.Add(lvi);
                }
                foreach (SpecialHat hat in specialHatsInOrder) {
                    ListViewItem lvi = new ListViewItem(hat.Name);
                lvi.SubItems.Add(hat.Price.ToString());
                    listViewHats.Items.Add(lvi);
                }
                UpdatePrice();
        }

        public void UpdatePrice()
        {
            if (lblOrder.Text == "0") return;
            int orderID = Int32.Parse(lblOrder.Text);
            //var currentOrder = orderController.getOrderOnId(orderID);
            Order currentOrder;
            using (HatDbContext _context = new HatDbContext()) {
                currentOrder = _context.Orders.FirstOrDefault(x => x.Id == orderID);
           

            lblTotalPrice.Text = currentOrder.TotalPrice + ":-" ?? "0.00:-";
            var customerPoints = currentOrder.Customer.CustomerBonusPoints;
            var discount = orderController.GetDiscount(customerPoints);
            lblSuggestedDiscount.Text = (currentOrder.TotalPrice - (currentOrder.TotalPrice * discount)) + ":-";
            txtBoxDiscount.Text = (currentOrder.TotalPrice - (currentOrder.TotalPrice * discount)).ToString();
            }
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
            int id = Int32.Parse(lblOrder.Text);
            if (id != 0) {
                StandardHatOrder form = new StandardHatOrder(id);
                form.parent = this;
                OpenChildForm(form);
            }
            else 
            {
                MessageBox.Show("Välj kund först.");
            }

        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnPurchase.BackColor);
            int id = Int32.Parse(lblOrder.Text);
            if (id != 0) {
                SpecialHatForm form = new SpecialHatForm(id);
                form.parent = this;
                OpenChildForm(form);
            }
            else {
                MessageBox.Show("Välj kund först.");
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOrderSubMenu);

        }

        private void btnListOfCreatedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            ListOfCreatedOrders form = new ListOfCreatedOrders();
            form.parent = this;
            OpenChildForm(form);


        }

        private void btnListOfStartedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            ListOfStartedOrders form = new ListOfStartedOrders();
            form.parent = this;
            OpenChildForm(form);

        }

        private void btnListOfFinishedOrders_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            setMenuColor(btnOrder.BackColor);
            ListOfFinishedOrders form = new ListOfFinishedOrders();
            form.parent = this;
            OpenChildForm(form);

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
            hideSubMenu();
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
            CreateOrder form = new CreateOrder();
            form.parent = this;
            OpenChildForm(form);
        }

        public void updateOrderAndCustomer(string orderId, string customerName)
        {
            lblOrder.Text = orderId;
            lblCustomer.Text = customerName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
