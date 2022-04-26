namespace AsyncHattprojekt
{
    partial class StartPage
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
            this.btnSeKundRegister = new System.Windows.Forms.Button();
            this.btnLagerStatus = new System.Windows.Forms.Button();
            this.btnSeOrder = new System.Windows.Forms.Button();
            this.btnBestall = new System.Windows.Forms.Button();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeKundRegister
            // 
            this.btnSeKundRegister.Location = new System.Drawing.Point(1196, 503);
            this.btnSeKundRegister.Name = "btnSeKundRegister";
            this.btnSeKundRegister.Size = new System.Drawing.Size(236, 85);
            this.btnSeKundRegister.TabIndex = 10;
            this.btnSeKundRegister.Text = "Registrera leverantörsfaktura";
            this.btnSeKundRegister.UseVisualStyleBackColor = true;
            this.btnSeKundRegister.Click += new System.EventHandler(this.btnSeKundRegister_Click);
            // 
            // btnLagerStatus
            // 
            this.btnLagerStatus.Location = new System.Drawing.Point(841, 503);
            this.btnLagerStatus.Name = "btnLagerStatus";
            this.btnLagerStatus.Size = new System.Drawing.Size(236, 85);
            this.btnLagerStatus.TabIndex = 9;
            this.btnLagerStatus.Text = "Lagerstatus";
            this.btnLagerStatus.UseVisualStyleBackColor = true;
            this.btnLagerStatus.Click += new System.EventHandler(this.btnLagerStatus_Click);
            // 
            // btnSeOrder
            // 
            this.btnSeOrder.Location = new System.Drawing.Point(472, 503);
            this.btnSeOrder.Name = "btnSeOrder";
            this.btnSeOrder.Size = new System.Drawing.Size(236, 85);
            this.btnSeOrder.TabIndex = 8;
            this.btnSeOrder.Text = "Se orderhistorik";
            this.btnSeOrder.UseVisualStyleBackColor = true;
            this.btnSeOrder.Click += new System.EventHandler(this.btnSeOrder_Click);
            // 
            // btnBestall
            // 
            this.btnBestall.Location = new System.Drawing.Point(91, 503);
            this.btnBestall.Name = "btnBestall";
            this.btnBestall.Size = new System.Drawing.Size(236, 85);
            this.btnBestall.TabIndex = 7;
            this.btnBestall.Text = "Ny order";
            this.btnBestall.UseVisualStyleBackColor = true;
            this.btnBestall.Click += new System.EventHandler(this.btnBestall_Click);
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(1333, 12);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(196, 60);
            this.btnLoggaUt.TabIndex = 11;
            this.btnLoggaUt.Text = "Logga Ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 75);
            this.label1.TabIndex = 12;
            this.label1.Text = "Välkommen";
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(795, 55);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(231, 75);
            this.lblNamn.TabIndex = 13;
            this.lblNamn.Text = "Namn!";
            this.lblNamn.Click += new System.EventHandler(this.lblNamn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 85);
            this.button1.TabIndex = 14;
            this.button1.Text = "Momssammanställning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1541, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoggaUt);
            this.Controls.Add(this.btnSeKundRegister);
            this.Controls.Add(this.btnLagerStatus);
            this.Controls.Add(this.btnSeOrder);
            this.Controls.Add(this.btnBestall);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeKundRegister;
        private System.Windows.Forms.Button btnLagerStatus;
        private System.Windows.Forms.Button btnSeOrder;
        private System.Windows.Forms.Button btnBestall;
        private System.Windows.Forms.Button btnLoggaUt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Button button1;
    }
}