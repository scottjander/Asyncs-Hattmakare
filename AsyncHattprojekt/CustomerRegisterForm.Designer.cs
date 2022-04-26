
namespace AsyncHattprojekt
{
    partial class CustomerRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listviewCust = new System.Windows.Forms.ListView();
            this.clmnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPostcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnBonus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listviewCust
            // 
            this.listviewCust.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnId,
            this.clmnFName,
            this.clmnLName,
            this.clmnPhone,
            this.clmnMail,
            this.clmnTown,
            this.clmnPostcode,
            this.clmnStreet,
            this.clmnBonus});
            this.listviewCust.HideSelection = false;
            this.listviewCust.Location = new System.Drawing.Point(12, 12);
            this.listviewCust.Name = "listviewCust";
            this.listviewCust.Size = new System.Drawing.Size(767, 538);
            this.listviewCust.TabIndex = 1;
            this.listviewCust.UseCompatibleStateImageBehavior = false;
            this.listviewCust.View = System.Windows.Forms.View.Details;
            this.listviewCust.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmnId
            // 
            this.clmnId.Text = "Kund ID";
            this.clmnId.Width = 59;
            // 
            // clmnFName
            // 
            this.clmnFName.Text = "Förnamn";
            this.clmnFName.Width = 76;
            // 
            // clmnLName
            // 
            this.clmnLName.Text = "Efternamn";
            this.clmnLName.Width = 79;
            // 
            // clmnPhone
            // 
            this.clmnPhone.Text = "Telefonnummer";
            this.clmnPhone.Width = 113;
            // 
            // clmnMail
            // 
            this.clmnMail.Text = "E-Mail";
            this.clmnMail.Width = 91;
            // 
            // clmnTown
            // 
            this.clmnTown.Text = "Stad";
            this.clmnTown.Width = 85;
            // 
            // clmnPostcode
            // 
            this.clmnPostcode.Text = "Postkod";
            this.clmnPostcode.Width = 65;
            // 
            // clmnStreet
            // 
            this.clmnStreet.Text = "Gatuadress";
            this.clmnStreet.Width = 113;
            // 
            // clmnBonus
            // 
            this.clmnBonus.Text = "Bonuspoäng";
            this.clmnBonus.Width = 77;
            // 
            // CustomerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(795, 566);
            this.Controls.Add(this.listviewCust);
            this.Name = "CustomerRegisterForm";
            this.Text = "CustomerRegisterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewCust;
        private System.Windows.Forms.ColumnHeader clmnId;
        private System.Windows.Forms.ColumnHeader clmnFName;
        private System.Windows.Forms.ColumnHeader clmnLName;
        private System.Windows.Forms.ColumnHeader clmnPhone;
        private System.Windows.Forms.ColumnHeader clmnMail;
        private System.Windows.Forms.ColumnHeader clmnTown;
        private System.Windows.Forms.ColumnHeader clmnPostcode;
        private System.Windows.Forms.ColumnHeader clmnStreet;
        private System.Windows.Forms.ColumnHeader clmnBonus;
    }
}