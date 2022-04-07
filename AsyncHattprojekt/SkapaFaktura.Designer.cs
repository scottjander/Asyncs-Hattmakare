namespace AsyncHattprojekt
{
    partial class SkapaFaktura
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
            this.btnSkapaFaktura = new System.Windows.Forms.Button();
            this.lblFaktura = new System.Windows.Forms.Label();
            this.chbBetald = new System.Windows.Forms.CheckBox();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.tbFaktureringsadress = new System.Windows.Forms.TextBox();
            this.tbSummaAttBetala = new System.Windows.Forms.TextBox();
            this.lblFaktureringsadress = new System.Windows.Forms.Label();
            this.lblSummaAttBetala = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSkapaFaktura
            // 
            this.btnSkapaFaktura.Location = new System.Drawing.Point(92, 516);
            this.btnSkapaFaktura.Name = "btnSkapaFaktura";
            this.btnSkapaFaktura.Size = new System.Drawing.Size(194, 57);
            this.btnSkapaFaktura.TabIndex = 0;
            this.btnSkapaFaktura.Text = "Skapa Faktura";
            this.btnSkapaFaktura.UseVisualStyleBackColor = true;
            this.btnSkapaFaktura.Click += new System.EventHandler(this.btnSkapaFaktura_Click);
            // 
            // lblFaktura
            // 
            this.lblFaktura.AutoSize = true;
            this.lblFaktura.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaktura.Location = new System.Drawing.Point(112, 49);
            this.lblFaktura.Name = "lblFaktura";
            this.lblFaktura.Size = new System.Drawing.Size(152, 42);
            this.lblFaktura.TabIndex = 1;
            this.lblFaktura.Text = "Faktura";
            // 
            // chbBetald
            // 
            this.chbBetald.AutoSize = true;
            this.chbBetald.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBetald.Location = new System.Drawing.Point(92, 472);
            this.chbBetald.Name = "chbBetald";
            this.chbBetald.Size = new System.Drawing.Size(91, 28);
            this.chbBetald.TabIndex = 2;
            this.chbBetald.Text = "Betald?";
            this.chbBetald.UseVisualStyleBackColor = true;
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(92, 378);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(194, 20);
            this.tbOrderID.TabIndex = 3;
            // 
            // tbFaktureringsadress
            // 
            this.tbFaktureringsadress.Location = new System.Drawing.Point(92, 186);
            this.tbFaktureringsadress.Name = "tbFaktureringsadress";
            this.tbFaktureringsadress.Size = new System.Drawing.Size(194, 20);
            this.tbFaktureringsadress.TabIndex = 5;
            // 
            // tbSummaAttBetala
            // 
            this.tbSummaAttBetala.Location = new System.Drawing.Point(92, 288);
            this.tbSummaAttBetala.Name = "tbSummaAttBetala";
            this.tbSummaAttBetala.Size = new System.Drawing.Size(194, 20);
            this.tbSummaAttBetala.TabIndex = 6;
            // 
            // lblFaktureringsadress
            // 
            this.lblFaktureringsadress.AutoSize = true;
            this.lblFaktureringsadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaktureringsadress.Location = new System.Drawing.Point(91, 146);
            this.lblFaktureringsadress.Name = "lblFaktureringsadress";
            this.lblFaktureringsadress.Size = new System.Drawing.Size(170, 24);
            this.lblFaktureringsadress.TabIndex = 7;
            this.lblFaktureringsadress.Text = "Faktureringsadress";
            // 
            // lblSummaAttBetala
            // 
            this.lblSummaAttBetala.AutoSize = true;
            this.lblSummaAttBetala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaAttBetala.Location = new System.Drawing.Point(88, 239);
            this.lblSummaAttBetala.Name = "lblSummaAttBetala";
            this.lblSummaAttBetala.Size = new System.Drawing.Size(153, 24);
            this.lblSummaAttBetala.TabIndex = 8;
            this.lblSummaAttBetala.Text = "Summa att betala";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(91, 339);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(76, 24);
            this.lblOrderID.TabIndex = 10;
            this.lblOrderID.Text = "OrderID";
            // 
            // SkapaFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 609);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblSummaAttBetala);
            this.Controls.Add(this.lblFaktureringsadress);
            this.Controls.Add(this.tbSummaAttBetala);
            this.Controls.Add(this.tbFaktureringsadress);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.chbBetald);
            this.Controls.Add(this.lblFaktura);
            this.Controls.Add(this.btnSkapaFaktura);
            this.Name = "SkapaFaktura";
            this.Text = "SkapaFaktura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSkapaFaktura;
        private System.Windows.Forms.Label lblFaktura;
        private System.Windows.Forms.CheckBox chbBetald;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.TextBox tbFaktureringsadress;
        private System.Windows.Forms.TextBox tbSummaAttBetala;
        private System.Windows.Forms.Label lblFaktureringsadress;
        private System.Windows.Forms.Label lblSummaAttBetala;
        private System.Windows.Forms.Label lblOrderID;
    }
}