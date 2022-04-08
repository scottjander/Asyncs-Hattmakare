namespace AsyncHattprojekt
{
    partial class FärdigFaktura
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
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblSummaAttBetala = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblKundID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(152, 126);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(68, 25);
            this.lblNamn.TabIndex = 0;
            this.lblNamn.Text = "Namn";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(141, 189);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(79, 25);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "Adress";
            // 
            // lblSummaAttBetala
            // 
            this.lblSummaAttBetala.AutoSize = true;
            this.lblSummaAttBetala.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaAttBetala.Location = new System.Drawing.Point(94, 258);
            this.lblSummaAttBetala.Name = "lblSummaAttBetala";
            this.lblSummaAttBetala.Size = new System.Drawing.Size(179, 25);
            this.lblSummaAttBetala.TabIndex = 2;
            this.lblSummaAttBetala.Text = "Summa att betala";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(12, 20);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(96, 25);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "OrderNR";
            // 
            // lblKundID
            // 
            this.lblKundID.AutoSize = true;
            this.lblKundID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKundID.Location = new System.Drawing.Point(12, 84);
            this.lblKundID.Name = "lblKundID";
            this.lblKundID.Size = new System.Drawing.Size(82, 25);
            this.lblKundID.TabIndex = 4;
            this.lblKundID.Text = "KundID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // FärdigFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 713);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKundID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblSummaAttBetala);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblNamn);
            this.Name = "FärdigFaktura";
            this.Text = "FärdigFaktura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblSummaAttBetala;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblKundID;
        private System.Windows.Forms.Label label4;
    }
}