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
            this.prisTxtBx = new System.Windows.Forms.RichTextBox();
            this.valjfargLbl = new System.Windows.Forms.Label();
            this.prisLbl = new System.Windows.Forms.Label();
            this.storlekChckBx = new System.Windows.Forms.CheckedListBox();
            this.storlekLbl = new System.Windows.Forms.Label();
            this.fargTxtBx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(377, 510);
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
            this.kommentarTxtBx.Location = new System.Drawing.Point(333, 316);
            this.kommentarTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kommentarTxtBx.Name = "kommentarTxtBx";
            this.kommentarTxtBx.Size = new System.Drawing.Size(219, 117);
            this.kommentarTxtBx.TabIndex = 1;
            this.kommentarTxtBx.Text = "";
            // 
            // kommentarLbl
            // 
            this.kommentarLbl.AutoSize = true;
            this.kommentarLbl.Location = new System.Drawing.Point(401, 297);
            this.kommentarLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kommentarLbl.Name = "kommentarLbl";
            this.kommentarLbl.Size = new System.Drawing.Size(75, 16);
            this.kommentarLbl.TabIndex = 2;
            this.kommentarLbl.Text = "Kommentar";
            this.kommentarLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // prisTxtBx
            // 
            this.prisTxtBx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.prisTxtBx.Location = new System.Drawing.Point(360, 458);
            this.prisTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prisTxtBx.Name = "prisTxtBx";
            this.prisTxtBx.ReadOnly = true;
            this.prisTxtBx.Size = new System.Drawing.Size(168, 43);
            this.prisTxtBx.TabIndex = 4;
            this.prisTxtBx.Text = "";
            this.prisTxtBx.TextChanged += new System.EventHandler(this.prisTxtBx_TextChanged);
            // 
            // valjfargLbl
            // 
            this.valjfargLbl.AutoSize = true;
            this.valjfargLbl.Location = new System.Drawing.Point(373, 57);
            this.valjfargLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valjfargLbl.Name = "valjfargLbl";
            this.valjfargLbl.Size = new System.Drawing.Size(103, 16);
            this.valjfargLbl.TabIndex = 5;
            this.valjfargLbl.Text = "Skriv ner en färg";
            // 
            // prisLbl
            // 
            this.prisLbl.AutoSize = true;
            this.prisLbl.Location = new System.Drawing.Point(425, 438);
            this.prisLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prisLbl.Name = "prisLbl";
            this.prisLbl.Size = new System.Drawing.Size(30, 16);
            this.prisLbl.TabIndex = 6;
            this.prisLbl.Text = "Pris";
            // 
            // storlekChckBx
            // 
            this.storlekChckBx.FormattingEnabled = true;
            this.storlekChckBx.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.storlekChckBx.Location = new System.Drawing.Point(395, 222);
            this.storlekChckBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.storlekChckBx.Name = "storlekChckBx";
            this.storlekChckBx.Size = new System.Drawing.Size(85, 55);
            this.storlekChckBx.TabIndex = 7;
            // 
            // storlekLbl
            // 
            this.storlekLbl.AutoSize = true;
            this.storlekLbl.Location = new System.Drawing.Point(404, 202);
            this.storlekLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storlekLbl.Name = "storlekLbl";
            this.storlekLbl.Size = new System.Drawing.Size(49, 16);
            this.storlekLbl.TabIndex = 8;
            this.storlekLbl.Text = "Storlek";
            // 
            // fargTxtBx
            // 
            this.fargTxtBx.Location = new System.Drawing.Point(333, 76);
            this.fargTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fargTxtBx.Name = "fargTxtBx";
            this.fargTxtBx.Size = new System.Drawing.Size(219, 117);
            this.fargTxtBx.TabIndex = 9;
            this.fargTxtBx.Text = "";
            // 
            // StandardHatOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 642);
            this.Controls.Add(this.fargTxtBx);
            this.Controls.Add(this.storlekLbl);
            this.Controls.Add(this.storlekChckBx);
            this.Controls.Add(this.prisLbl);
            this.Controls.Add(this.valjfargLbl);
            this.Controls.Add(this.prisTxtBx);
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
        private System.Windows.Forms.RichTextBox prisTxtBx;
        private System.Windows.Forms.Label valjfargLbl;
        private System.Windows.Forms.Label prisLbl;
        private System.Windows.Forms.CheckedListBox storlekChckBx;
        private System.Windows.Forms.Label storlekLbl;
        private System.Windows.Forms.RichTextBox fargTxtBx;
    }
}