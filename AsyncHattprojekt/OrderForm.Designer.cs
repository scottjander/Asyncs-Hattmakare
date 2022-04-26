
namespace AsyncHattprojekt
{
    partial class OrderForm
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
            if (disposing && (components != null))
            {
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
            this.btnCreateStandard = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCreateSpecial = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listViewHats = new System.Windows.Forms.ListView();
            this.Hatt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuggestedDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDiscount = new System.Windows.Forms.TextBox();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateStandard
            // 
            this.btnCreateStandard.Location = new System.Drawing.Point(1004, 907);
            this.btnCreateStandard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateStandard.Name = "btnCreateStandard";
            this.btnCreateStandard.Size = new System.Drawing.Size(157, 55);
            this.btnCreateStandard.TabIndex = 0;
            this.btnCreateStandard.Text = "Lägg till Standardhatt";
            this.btnCreateStandard.UseVisualStyleBackColor = true;
            this.btnCreateStandard.Click += new System.EventHandler(this.btnCreateStandard_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(868, 921);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(68, 25);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "0,00 :-";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // btnCreateSpecial
            // 
            this.btnCreateSpecial.Location = new System.Drawing.Point(1004, 970);
            this.btnCreateSpecial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateSpecial.Name = "btnCreateSpecial";
            this.btnCreateSpecial.Size = new System.Drawing.Size(157, 55);
            this.btnCreateSpecial.TabIndex = 5;
            this.btnCreateSpecial.Text = "Lägg Till Specialhatt";
            this.btnCreateSpecial.UseVisualStyleBackColor = true;
            this.btnCreateSpecial.Click += new System.EventHandler(this.btnCreateSpecial_Click);
            // 
            // listViewHats
            // 
            this.listViewHats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hatt,
            this.columnHeader1});
            this.listViewHats.HideSelection = false;
            this.listViewHats.Location = new System.Drawing.Point(13, 22);
            this.listViewHats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewHats.Name = "listViewHats";
            this.listViewHats.Size = new System.Drawing.Size(1027, 408);
            this.listViewHats.TabIndex = 9;
            this.listViewHats.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 927);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ordinarie pris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 976);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Föreslagen rabatt";
            // 
            // lblSuggestedDiscount
            // 
            this.lblSuggestedDiscount.AutoSize = true;
            this.lblSuggestedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSuggestedDiscount.Location = new System.Drawing.Point(868, 970);
            this.lblSuggestedDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuggestedDiscount.Name = "lblSuggestedDiscount";
            this.lblSuggestedDiscount.Size = new System.Drawing.Size(68, 25);
            this.lblSuggestedDiscount.TabIndex = 12;
            this.lblSuggestedDiscount.Text = "0,00 :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 1024);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rabatt:";
            // 
            // txtBoxDiscount
            // 
            this.txtBoxDiscount.Location = new System.Drawing.Point(873, 1015);
            this.txtBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.Size = new System.Drawing.Size(64, 22);
            this.txtBoxDiscount.TabIndex = 14;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Location = new System.Drawing.Point(1117, 1058);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(153, 28);
            this.btnCreateInvoice.TabIndex = 15;
            this.btnCreateInvoice.Text = "Skapa faktura";
            this.btnCreateInvoice.UseVisualStyleBackColor = true;
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 1102);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.txtBoxDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSuggestedDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHats);
            this.Controls.Add(this.btnCreateSpecial);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCreateStandard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStandard;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnCreateSpecial;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView listViewHats;
        private System.Windows.Forms.ColumnHeader Hatt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuggestedDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDiscount;
        private System.Windows.Forms.Button btnCreateInvoice;
    }
}