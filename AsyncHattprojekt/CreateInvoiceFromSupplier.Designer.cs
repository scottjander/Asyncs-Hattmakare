namespace AsyncHattprojekt
{
    partial class CreateInvoiceFromSupplier
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(197, 150);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(197, 231);
            this.txtSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(76, 20);
            this.txtSum.TabIndex = 1;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(80, 150);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(82, 235);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(95, 13);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Summa Inkl. moms";
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(82, 324);
            this.btnSaveInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(56, 19);
            this.btnSaveInvoice.TabIndex = 4;
            this.btnSaveInvoice.Text = "Spara faktura";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // CreateInvoiceFromSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(576, 457);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.dateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateInvoiceFromSupplier";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnSaveInvoice;
    }
}