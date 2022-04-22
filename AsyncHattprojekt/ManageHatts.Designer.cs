namespace AsyncHattprojekt
{
    partial class ManageHatts
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSizeAmount = new System.Windows.Forms.Label();
            this.btnAddHats = new System.Windows.Forms.Button();
            this.cmbBoxColor = new System.Windows.Forms.ComboBox();
            this.txtBoxAddHats = new System.Windows.Forms.TextBox();
            this.cmbBoxSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnChangePrice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveHats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(472, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standardhattar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(441, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // lblSizeAmount
            // 
            this.lblSizeAmount.AutoSize = true;
            this.lblSizeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSizeAmount.Location = new System.Drawing.Point(465, 233);
            this.lblSizeAmount.Name = "lblSizeAmount";
            this.lblSizeAmount.Size = new System.Drawing.Size(23, 25);
            this.lblSizeAmount.TabIndex = 5;
            this.lblSizeAmount.Text = "0";
            // 
            // btnAddHats
            // 
            this.btnAddHats.Location = new System.Drawing.Point(832, 233);
            this.btnAddHats.Name = "btnAddHats";
            this.btnAddHats.Size = new System.Drawing.Size(88, 23);
            this.btnAddHats.TabIndex = 12;
            this.btnAddHats.Text = "+";
            this.btnAddHats.UseVisualStyleBackColor = true;
            this.btnAddHats.Click += new System.EventHandler(this.btnAddHats_Click);
            // 
            // cmbBoxColor
            // 
            this.cmbBoxColor.FormattingEnabled = true;
            this.cmbBoxColor.Location = new System.Drawing.Point(241, 298);
            this.cmbBoxColor.Name = "cmbBoxColor";
            this.cmbBoxColor.Size = new System.Drawing.Size(169, 24);
            this.cmbBoxColor.TabIndex = 37;
            this.cmbBoxColor.SelectedIndexChanged += new System.EventHandler(this.cmbBoxColor_SelectedIndexChanged);
            // 
            // txtBoxAddHats
            // 
            this.txtBoxAddHats.Location = new System.Drawing.Point(556, 233);
            this.txtBoxAddHats.Name = "txtBoxAddHats";
            this.txtBoxAddHats.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAddHats.TabIndex = 8;
            // 
            // cmbBoxSize
            // 
            this.cmbBoxSize.FormattingEnabled = true;
            this.cmbBoxSize.Location = new System.Drawing.Point(241, 233);
            this.cmbBoxSize.Name = "cmbBoxSize";
            this.cmbBoxSize.Size = new System.Drawing.Size(169, 24);
            this.cmbBoxSize.TabIndex = 39;
            this.cmbBoxSize.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSize_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(735, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ta bort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(839, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Lägg till";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(441, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "Pris";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(556, 403);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrice.TabIndex = 43;
            // 
            // btnChangePrice
            // 
            this.btnChangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnChangePrice.Location = new System.Drawing.Point(722, 403);
            this.btnChangePrice.Name = "btnChangePrice";
            this.btnChangePrice.Size = new System.Drawing.Size(87, 23);
            this.btnChangePrice.TabIndex = 44;
            this.btnChangePrice.Text = "Ändra";
            this.btnChangePrice.UseVisualStyleBackColor = true;
            this.btnChangePrice.Click += new System.EventHandler(this.btnChangePrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(488, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ändra pris på standardhatt";
            // 
            // btnRemoveHats
            // 
            this.btnRemoveHats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnRemoveHats.Location = new System.Drawing.Point(722, 233);
            this.btnRemoveHats.Name = "btnRemoveHats";
            this.btnRemoveHats.Size = new System.Drawing.Size(87, 23);
            this.btnRemoveHats.TabIndex = 46;
            this.btnRemoveHats.Text = "-";
            this.btnRemoveHats.UseVisualStyleBackColor = true;
            this.btnRemoveHats.Click += new System.EventHandler(this.btnRemoveHats_Click);
            // 
            // ManageHatts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 557);
            this.Controls.Add(this.btnRemoveHats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnChangePrice);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBoxSize);
            this.Controls.Add(this.cmbBoxColor);
            this.Controls.Add(this.btnAddHats);
            this.Controls.Add(this.txtBoxAddHats);
            this.Controls.Add(this.lblSizeAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageHatts";
            this.Text = "ManageHatts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSizeAmount;
        private System.Windows.Forms.Button btnAddHats;
        private System.Windows.Forms.ComboBox cmbBoxColor;
        private System.Windows.Forms.TextBox txtBoxAddHats;
        private System.Windows.Forms.ComboBox cmbBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnChangePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveHats;
    }
}