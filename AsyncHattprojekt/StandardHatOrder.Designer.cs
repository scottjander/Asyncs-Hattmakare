namespace AsyncHattprojekt
{
    partial class StandardHatOrder
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.kommentarTxtBx = new System.Windows.Forms.RichTextBox();
            this.kommentarLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(399, 444);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(132, 48);
            this.registerBtn.TabIndex = 0;
            this.registerBtn.Text = "Registrera";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // kommentarTxtBx
            // 
            this.kommentarTxtBx.Location = new System.Drawing.Point(344, 289);
            this.kommentarTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kommentarTxtBx.Name = "kommentarTxtBx";
            this.kommentarTxtBx.Size = new System.Drawing.Size(219, 117);
            this.kommentarTxtBx.TabIndex = 1;
            this.kommentarTxtBx.Text = "";
            // 
            // kommentarLbl
            // 
            this.kommentarLbl.AutoSize = true;
            this.kommentarLbl.Location = new System.Drawing.Point(409, 270);
            this.kommentarLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kommentarLbl.Name = "kommentarLbl";
            this.kommentarLbl.Size = new System.Drawing.Size(75, 16);
            this.kommentarLbl.TabIndex = 2;
            this.kommentarLbl.Text = "Kommentar";
            this.kommentarLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(279, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(383, 170);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Storlek";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Färg";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pris";
            this.columnHeader2.Width = 88;
            // 
            // StandardHatOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 642);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.kommentarLbl);
            this.Controls.Add(this.kommentarTxtBx);
            this.Controls.Add(this.registerBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StandardHatOrder";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.RichTextBox kommentarTxtBx;
        private System.Windows.Forms.Label kommentarLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}