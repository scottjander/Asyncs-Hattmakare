namespace AsyncHattprojekt
{
    partial class MaterialVy
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMangd = new System.Windows.Forms.TextBox();
            this.btnOkaLager = new System.Windows.Forms.Button();
            this.lblOkaLager = new System.Windows.Forms.Label();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(128, 80);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(959, 442);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Namn";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pris";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Antal i lager";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Färg";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Id";
            // 
            // txtMangd
            // 
            this.txtMangd.Location = new System.Drawing.Point(128, 558);
            this.txtMangd.Name = "txtMangd";
            this.txtMangd.Size = new System.Drawing.Size(162, 26);
            this.txtMangd.TabIndex = 1;
            // 
            // btnOkaLager
            // 
            this.btnOkaLager.Location = new System.Drawing.Point(394, 558);
            this.btnOkaLager.Name = "btnOkaLager";
            this.btnOkaLager.Size = new System.Drawing.Size(188, 35);
            this.btnOkaLager.TabIndex = 2;
            this.btnOkaLager.Text = "Öka lagerantal";
            this.btnOkaLager.UseVisualStyleBackColor = true;
            this.btnOkaLager.Click += new System.EventHandler(this.btnOkaLager_Click);
            // 
            // lblOkaLager
            // 
            this.lblOkaLager.AutoSize = true;
            this.lblOkaLager.Location = new System.Drawing.Point(128, 531);
            this.lblOkaLager.Name = "lblOkaLager";
            this.lblOkaLager.Size = new System.Drawing.Size(244, 20);
            this.lblOkaLager.TabIndex = 3;
            this.lblOkaLager.Text = "Önskat belopp att öka lagret med";
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(899, 558);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(188, 35);
            this.btnTillbaka.TabIndex = 4;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // MaterialVy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1309, 741);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.lblOkaLager);
            this.Controls.Add(this.btnOkaLager);
            this.Controls.Add(this.txtMangd);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaterialVy";
            this.Text = "MaterialVy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtMangd;
        private System.Windows.Forms.Button btnOkaLager;
        private System.Windows.Forms.Label lblOkaLager;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}