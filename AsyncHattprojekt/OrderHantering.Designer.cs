
namespace AsyncHattprojekt
{
    partial class OrderHantering
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTownPost = new System.Windows.Forms.Label();
            this.richTxtBoxComment = new System.Windows.Forms.RichTextBox();
            this.cbStatusEnum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewHat = new System.Windows.Forms.ListView();
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(671, 579);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 48);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Skriv ut fraktsedel";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(46, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Spara ändringar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(41, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Namn";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(41, 132);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 25);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Telefon";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(41, 177);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 25);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail";
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(41, 219);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 25);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Adress";
            // 
            // lblTownPost
            // 
            this.lblTownPost.AutoSize = true;
            this.lblTownPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTownPost.Location = new System.Drawing.Point(41, 266);
            this.lblTownPost.Name = "lblTownPost";
            this.lblTownPost.Size = new System.Drawing.Size(166, 25);
            this.lblTownPost.TabIndex = 6;
            this.lblTownPost.Text = "Stad och Postkod";
            // 
            // richTxtBoxComment
            // 
            this.richTxtBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxComment.Location = new System.Drawing.Point(46, 355);
            this.richTxtBoxComment.Name = "richTxtBoxComment";
            this.richTxtBoxComment.Size = new System.Drawing.Size(303, 177);
            this.richTxtBoxComment.TabIndex = 7;
            this.richTxtBoxComment.Text = "";
            // 
            // cbStatusEnum
            // 
            this.cbStatusEnum.FormattingEnabled = true;
            this.cbStatusEnum.Location = new System.Drawing.Point(595, 113);
            this.cbStatusEnum.Name = "cbStatusEnum";
            this.cbStatusEnum.Size = new System.Drawing.Size(195, 21);
            this.cbStatusEnum.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status";
            // 
            // listViewHat
            // 
            this.listViewHat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnPrice});
            this.listViewHat.HideSelection = false;
            this.listViewHat.Location = new System.Drawing.Point(542, 355);
            this.listViewHat.Name = "listViewHat";
            this.listViewHat.Size = new System.Drawing.Size(248, 177);
            this.listViewHat.TabIndex = 10;
            this.listViewHat.UseCompatibleStateImageBehavior = false;
            this.listViewHat.View = System.Windows.Forms.View.Details;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Namn";
            this.clmnName.Width = 122;
            // 
            // clmnPrice
            // 
            this.clmnPrice.Text = "Pris";
            this.clmnPrice.Width = 117;
            // 
            // OrderHantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(888, 697);
            this.Controls.Add(this.listViewHat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatusEnum);
            this.Controls.Add(this.richTxtBoxComment);
            this.Controls.Add(this.lblTownPost);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Name = "OrderHantering";
            this.Text = "OrderHantering";
            this.Load += new System.EventHandler(this.OrderHantering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTownPost;
        private System.Windows.Forms.RichTextBox richTxtBoxComment;
        private System.Windows.Forms.ComboBox cbStatusEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewHat;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnPrice;
    }
}