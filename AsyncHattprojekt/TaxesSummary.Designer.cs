
namespace AsyncHattprojekt
{
    partial class TaxesSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxTotalAmountOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTotalAmountIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxTaxAmountOut = new System.Windows.Forms.TextBox();
            this.txtBoxTaxAmountIn = new System.Windows.Forms.TextBox();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outgoing invoices";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 141);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(351, 173);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 124;
            // 
            // txtBoxTotalAmountOut
            // 
            this.txtBoxTotalAmountOut.Location = new System.Drawing.Point(288, 361);
            this.txtBoxTotalAmountOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTotalAmountOut.Name = "txtBoxTotalAmountOut";
            this.txtBoxTotalAmountOut.ReadOnly = true;
            this.txtBoxTotalAmountOut.Size = new System.Drawing.Size(92, 22);
            this.txtBoxTotalAmountOut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incoming invoices";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(607, 137);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(376, 177);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total amount";
            // 
            // txtBoxTotalAmountIn
            // 
            this.txtBoxTotalAmountIn.Location = new System.Drawing.Point(863, 357);
            this.txtBoxTotalAmountIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTotalAmountIn.Name = "txtBoxTotalAmountIn";
            this.txtBoxTotalAmountIn.ReadOnly = true;
            this.txtBoxTotalAmountIn.Size = new System.Drawing.Size(92, 22);
            this.txtBoxTotalAmountIn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 411);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tax amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tax amount";
            // 
            // txtBoxTaxAmountOut
            // 
            this.txtBoxTaxAmountOut.Location = new System.Drawing.Point(286, 446);
            this.txtBoxTaxAmountOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTaxAmountOut.Name = "txtBoxTaxAmountOut";
            this.txtBoxTaxAmountOut.ReadOnly = true;
            this.txtBoxTaxAmountOut.Size = new System.Drawing.Size(92, 22);
            this.txtBoxTaxAmountOut.TabIndex = 10;
            // 
            // txtBoxTaxAmountIn
            // 
            this.txtBoxTaxAmountIn.Location = new System.Drawing.Point(857, 442);
            this.txtBoxTaxAmountIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxTaxAmountIn.Name = "txtBoxTaxAmountIn";
            this.txtBoxTaxAmountIn.ReadOnly = true;
            this.txtBoxTaxAmountIn.Size = new System.Drawing.Size(92, 22);
            this.txtBoxTaxAmountIn.TabIndex = 11;
            // 
            // cbYears
            // 
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Location = new System.Drawing.Point(450, 35);
            this.cbYears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(160, 24);
            this.cbYears.TabIndex = 12;
            this.cbYears.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filter by year";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(865, 519);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 28);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Exportera";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // TaxesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1111, 614);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbYears);
            this.Controls.Add(this.txtBoxTaxAmountIn);
            this.Controls.Add(this.txtBoxTaxAmountOut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxTotalAmountIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTotalAmountOut);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaxesSummary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtBoxTotalAmountOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTotalAmountIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxTaxAmountOut;
        private System.Windows.Forms.TextBox txtBoxTaxAmountIn;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExport;
    }
}