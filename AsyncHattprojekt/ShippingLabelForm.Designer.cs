
namespace AsyncHattprojekt
{
    partial class ShippingLabelForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(84, 53);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblName.Location = new System.Drawing.Point(43, 123);
            this.lblName.MinimumSize = new System.Drawing.Size(100, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 44);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblStreet.Location = new System.Drawing.Point(43, 236);
            this.lblStreet.MinimumSize = new System.Drawing.Size(100, 40);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(234, 44);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street Name";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.lblTown.Location = new System.Drawing.Point(43, 370);
            this.lblTown.MinimumSize = new System.Drawing.Size(100, 40);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(329, 44);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "00000 TownName";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(572, 481);
            this.lblDate.MinimumSize = new System.Drawing.Size(100, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(169, 40);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "DateTimeNow";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 1117);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 55);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Skriv ut";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 179);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // shippinglabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 1184);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.linkLabel1);
            this.Name = "shippinglabel";
            this.Text = "Shipping Label";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}