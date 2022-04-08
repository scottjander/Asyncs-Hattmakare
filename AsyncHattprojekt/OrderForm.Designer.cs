
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
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCreateSpecial = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateStandard
            // 
            this.btnCreateStandard.Location = new System.Drawing.Point(753, 757);
            this.btnCreateStandard.Name = "btnCreateStandard";
            this.btnCreateStandard.Size = new System.Drawing.Size(118, 45);
            this.btnCreateStandard.TabIndex = 0;
            this.btnCreateStandard.Text = "Lägg till Standardhatt";
            this.btnCreateStandard.UseVisualStyleBackColor = true;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(753, 166);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(118, 45);
            this.btnCreateCustomer.TabIndex = 1;
            this.btnCreateCustomer.Text = "Ny kund";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(100, 714);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(281, 134);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnCreateSpecial
            // 
            this.btnCreateSpecial.Location = new System.Drawing.Point(753, 825);
            this.btnCreateSpecial.Name = "btnCreateSpecial";
            this.btnCreateSpecial.Size = new System.Drawing.Size(118, 45);
            this.btnCreateSpecial.TabIndex = 5;
            this.btnCreateSpecial.Text = "Lägg Till Specialhatt";
            this.btnCreateSpecial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 250);
            this.dataGridView1.TabIndex = 7;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 895);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreateSpecial);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.btnCreateStandard);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStandard;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCreateSpecial;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}