
namespace AsyncHattprojekt
{
    partial class InitialPage
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
            this.cbVäljAnvändare = new System.Windows.Forms.ComboBox();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.btnSkapaAnvändare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbVäljAnvändare
            // 
            this.cbVäljAnvändare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVäljAnvändare.FormattingEnabled = true;
            this.cbVäljAnvändare.IntegralHeight = false;
            this.cbVäljAnvändare.ItemHeight = 22;
            this.cbVäljAnvändare.Location = new System.Drawing.Point(117, 116);
            this.cbVäljAnvändare.MaxDropDownItems = 99;
            this.cbVäljAnvändare.Name = "cbVäljAnvändare";
            this.cbVäljAnvändare.Size = new System.Drawing.Size(201, 30);
            this.cbVäljAnvändare.TabIndex = 1;
            this.cbVäljAnvändare.Text = "Välj Användare";
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggaIn.Location = new System.Drawing.Point(167, 192);
            this.btnLoggaIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(130, 33);
            this.btnLoggaIn.TabIndex = 3;
            this.btnLoggaIn.Text = "Logga In";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click_1);
            // 
            // btnSkapaAnvändare
            // 
            this.btnSkapaAnvändare.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkapaAnvändare.Location = new System.Drawing.Point(324, 333);
            this.btnSkapaAnvändare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkapaAnvändare.Name = "btnSkapaAnvändare";
            this.btnSkapaAnvändare.Size = new System.Drawing.Size(130, 54);
            this.btnSkapaAnvändare.TabIndex = 4;
            this.btnSkapaAnvändare.Text = "Skapa ny användare";
            this.btnSkapaAnvändare.UseVisualStyleBackColor = true;
            this.btnSkapaAnvändare.Click += new System.EventHandler(this.btnSkapaAnvändare_Click);
            // 
            // InitialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 417);
            this.Controls.Add(this.btnSkapaAnvändare);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.cbVäljAnvändare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InitialPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVäljAnvändare;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.Button btnSkapaAnvändare;
    }
}

