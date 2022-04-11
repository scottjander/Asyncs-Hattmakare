
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
            this.SuspendLayout();
            // 
            // btnCreateStandard
            // 
            this.btnCreateStandard.Location = new System.Drawing.Point(753, 737);
            this.btnCreateStandard.Name = "btnCreateStandard";
            this.btnCreateStandard.Size = new System.Drawing.Size(118, 45);
            this.btnCreateStandard.TabIndex = 0;
            this.btnCreateStandard.Text = "Lägg till Standardhatt";
            this.btnCreateStandard.UseVisualStyleBackColor = true;
            this.btnCreateStandard.Click += new System.EventHandler(this.btnCreateStandard_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(749, 714);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(53, 20);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "0,00 :-";
            // 
            // btnCreateSpecial
            // 
            this.btnCreateSpecial.Location = new System.Drawing.Point(753, 788);
            this.btnCreateSpecial.Name = "btnCreateSpecial";
            this.btnCreateSpecial.Size = new System.Drawing.Size(118, 45);
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
            this.listViewHats.Location = new System.Drawing.Point(100, 338);
            this.listViewHats.Name = "listViewHats";
            this.listViewHats.Size = new System.Drawing.Size(771, 332);
            this.listViewHats.TabIndex = 9;
            this.listViewHats.UseCompatibleStateImageBehavior = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 895);
            this.Controls.Add(this.listViewHats);
            this.Controls.Add(this.btnCreateSpecial);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCreateStandard);
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
    }
}