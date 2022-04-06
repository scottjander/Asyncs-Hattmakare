namespace AsyncHattprojekt
{
    partial class SpecialHatForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFabric = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDecoration = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDecoration = new System.Windows.Forms.TextBox();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.cmbBoxFabric = new System.Windows.Forms.ComboBox();
            this.btnAddHat = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtBoxComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(126, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn";
            // 
            // lblFabric
            // 
            this.lblFabric.AutoSize = true;
            this.lblFabric.Location = new System.Drawing.Point(126, 147);
            this.lblFabric.Name = "lblFabric";
            this.lblFabric.Size = new System.Drawing.Size(56, 20);
            this.lblFabric.TabIndex = 1;
            this.lblFabric.Text = "Matrial";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(126, 252);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(59, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Storlek";
            // 
            // lblDecoration
            // 
            this.lblDecoration.AutoSize = true;
            this.lblDecoration.Location = new System.Drawing.Point(126, 202);
            this.lblDecoration.Name = "lblDecoration";
            this.lblDecoration.Size = new System.Drawing.Size(125, 20);
            this.lblDecoration.TabIndex = 3;
            this.lblDecoration.Text = "Antal dekoration";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(307, 94);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 26);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxDecoration
            // 
            this.txtBoxDecoration.Location = new System.Drawing.Point(307, 196);
            this.txtBoxDecoration.Name = "txtBoxDecoration";
            this.txtBoxDecoration.Size = new System.Drawing.Size(100, 26);
            this.txtBoxDecoration.TabIndex = 5;
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(307, 252);
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(100, 26);
            this.txtBoxSize.TabIndex = 6;
            // 
            // cmbBoxFabric
            // 
            this.cmbBoxFabric.FormattingEnabled = true;
            this.cmbBoxFabric.Location = new System.Drawing.Point(307, 138);
            this.cmbBoxFabric.Name = "cmbBoxFabric";
            this.cmbBoxFabric.Size = new System.Drawing.Size(121, 28);
            this.cmbBoxFabric.TabIndex = 7;
            // 
            // btnAddHat
            // 
            this.btnAddHat.Location = new System.Drawing.Point(130, 465);
            this.btnAddHat.Name = "btnAddHat";
            this.btnAddHat.Size = new System.Drawing.Size(179, 31);
            this.btnAddHat.TabIndex = 8;
            this.btnAddHat.Text = "Lägg till hatt i order";
            this.btnAddHat.UseVisualStyleBackColor = true;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(130, 408);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(129, 28);
            this.btnAddImage.TabIndex = 9;
            this.btnAddImage.Text = "Lägg till bild";
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Location = new System.Drawing.Point(307, 314);
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.Size = new System.Drawing.Size(347, 26);
            this.txtBoxComment.TabIndex = 10;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(134, 317);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(78, 20);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Komentar";
            // 
            // SpecialHatForm
            // 
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtBoxComment);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAddHat);
            this.Controls.Add(this.cmbBoxFabric);
            this.Controls.Add(this.txtBoxSize);
            this.Controls.Add(this.txtBoxDecoration);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblDecoration);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFabric);
            this.Controls.Add(this.lblName);
            this.Name = "SpecialHatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFabric;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDecoration;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDecoration;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.ComboBox cmbBoxFabric;
        private System.Windows.Forms.Button btnAddHat;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtBoxComment;
        private System.Windows.Forms.Label lblComment;
    }
}