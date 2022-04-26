namespace AsyncHattprojekt
{
    partial class Testform
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
            this.btnSpecialBeställning = new System.Windows.Forms.Button();
            this.btnStandardBeställning = new System.Windows.Forms.Button();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpecialBeställning
            // 
            this.btnSpecialBeställning.Location = new System.Drawing.Point(50, 165);
            this.btnSpecialBeställning.Name = "btnSpecialBeställning";
            this.btnSpecialBeställning.Size = new System.Drawing.Size(240, 73);
            this.btnSpecialBeställning.TabIndex = 0;
            this.btnSpecialBeställning.Text = "Specialbeställning";
            this.btnSpecialBeställning.UseVisualStyleBackColor = true;
            this.btnSpecialBeställning.Click += new System.EventHandler(this.btnSpecialBeställning_Click);
            // 
            // btnStandardBeställning
            // 
            this.btnStandardBeställning.Location = new System.Drawing.Point(452, 165);
            this.btnStandardBeställning.Name = "btnStandardBeställning";
            this.btnStandardBeställning.Size = new System.Drawing.Size(222, 73);
            this.btnStandardBeställning.TabIndex = 1;
            this.btnStandardBeställning.Text = "Standardbeställning";
            this.btnStandardBeställning.UseVisualStyleBackColor = true;
            this.btnStandardBeställning.Click += new System.EventHandler(this.btnStandardBeställning_Click);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(634, 12);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(141, 50);
            this.btnTillbaka.TabIndex = 2;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // Testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(787, 457);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.btnStandardBeställning);
            this.Controls.Add(this.btnSpecialBeställning);
            this.Name = "Testform";
            this.Text = "Testform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpecialBeställning;
        private System.Windows.Forms.Button btnStandardBeställning;
        private System.Windows.Forms.Button btnTillbaka;
    }
}