namespace AsyncHattprojekt
{
    partial class RegKund
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
            this.RegistreraBtn = new System.Windows.Forms.Button();
            this.LastNameTxd = new System.Windows.Forms.TextBox();
            this.FirstNameTxd = new System.Windows.Forms.TextBox();
            this.Phonetxd = new System.Windows.Forms.TextBox();
            this.EmailTxd = new System.Windows.Forms.TextBox();
            this.AddressTxd = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CommentTxt = new System.Windows.Forms.RichTextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistreraBtn
            // 
            this.RegistreraBtn.Location = new System.Drawing.Point(665, 382);
            this.RegistreraBtn.Name = "RegistreraBtn";
            this.RegistreraBtn.Size = new System.Drawing.Size(93, 35);
            this.RegistreraBtn.TabIndex = 0;
            this.RegistreraBtn.Text = "Registrera";
            this.RegistreraBtn.UseVisualStyleBackColor = true;
            this.RegistreraBtn.Click += new System.EventHandler(this.RegistreraBtn_Click);
            // 
            // LastNameTxd
            // 
            this.LastNameTxd.Location = new System.Drawing.Point(517, 104);
            this.LastNameTxd.Name = "LastNameTxd";
            this.LastNameTxd.Size = new System.Drawing.Size(241, 22);
            this.LastNameTxd.TabIndex = 2;
            // 
            // FirstNameTxd
            // 
            this.FirstNameTxd.Location = new System.Drawing.Point(517, 48);
            this.FirstNameTxd.Name = "FirstNameTxd";
            this.FirstNameTxd.Size = new System.Drawing.Size(241, 22);
            this.FirstNameTxd.TabIndex = 3;
            // 
            // Phonetxd
            // 
            this.Phonetxd.Location = new System.Drawing.Point(517, 157);
            this.Phonetxd.Name = "Phonetxd";
            this.Phonetxd.Size = new System.Drawing.Size(241, 22);
            this.Phonetxd.TabIndex = 4;
            // 
            // EmailTxd
            // 
            this.EmailTxd.Location = new System.Drawing.Point(517, 215);
            this.EmailTxd.Name = "EmailTxd";
            this.EmailTxd.Size = new System.Drawing.Size(241, 22);
            this.EmailTxd.TabIndex = 5;
            // 
            // AddressTxd
            // 
            this.AddressTxd.Location = new System.Drawing.Point(517, 276);
            this.AddressTxd.Name = "AddressTxd";
            this.AddressTxd.Size = new System.Drawing.Size(241, 22);
            this.AddressTxd.TabIndex = 6;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(262, 51);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(43, 16);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "Namn";
            this.FirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(262, 110);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(67, 16);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "Efternamn";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(262, 163);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(101, 16);
            this.PhoneLabel.TabIndex = 10;
            this.PhoneLabel.Text = "Telefonnummer";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(262, 221);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 16);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Mejl";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(262, 282);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(58, 16);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address";
            // 
            // CommentTxt
            // 
            this.CommentTxt.Location = new System.Drawing.Point(263, 321);
            this.CommentTxt.Name = "CommentTxt";
            this.CommentTxt.Size = new System.Drawing.Size(343, 96);
            this.CommentTxt.TabIndex = 13;
            this.CommentTxt.Text = "";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(110, 352);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(75, 16);
            this.CommentLabel.TabIndex = 14;
            this.CommentLabel.Text = "Kommentar";
            this.CommentLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RegKund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.CommentTxt);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AddressTxd);
            this.Controls.Add(this.EmailTxd);
            this.Controls.Add(this.Phonetxd);
            this.Controls.Add(this.FirstNameTxd);
            this.Controls.Add(this.LastNameTxd);
            this.Controls.Add(this.RegistreraBtn);
            this.Name = "RegKund";
            this.Text = "RegKund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistreraBtn;
        private System.Windows.Forms.TextBox LastNameTxd;
        private System.Windows.Forms.TextBox FirstNameTxd;
        private System.Windows.Forms.TextBox EmailTxd;
        private System.Windows.Forms.TextBox AddressTxd;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox Phonetxd;
        private System.Windows.Forms.RichTextBox CommentTxt;
        private System.Windows.Forms.Label CommentLabel;
    }
}