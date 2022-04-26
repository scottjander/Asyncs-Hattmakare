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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDecoration = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxDecoration = new System.Windows.Forms.TextBox();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.btnAddHat = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtBoxComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblFabricLength = new System.Windows.Forms.Label();
            this.txtBoxFabricLength = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.lblFabric = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblChosenFabric = new System.Windows.Forms.Label();
            this.txtBoxChosenFabric = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(52, 304);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Storlek";
            // 
            // lblDecoration
            // 
            this.lblDecoration.AutoSize = true;
            this.lblDecoration.Location = new System.Drawing.Point(52, 275);
            this.lblDecoration.Name = "lblDecoration";
            this.lblDecoration.Size = new System.Drawing.Size(84, 13);
            this.lblDecoration.TabIndex = 3;
            this.lblDecoration.Text = "Antal dekoration";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(233, 33);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxDecoration
            // 
            this.txtBoxDecoration.Location = new System.Drawing.Point(233, 268);
            this.txtBoxDecoration.Name = "txtBoxDecoration";
            this.txtBoxDecoration.Size = new System.Drawing.Size(40, 20);
            this.txtBoxDecoration.TabIndex = 5;
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(233, 301);
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(40, 20);
            this.txtBoxSize.TabIndex = 6;
            // 
            // btnAddHat
            // 
            this.btnAddHat.Location = new System.Drawing.Point(56, 519);
            this.btnAddHat.Name = "btnAddHat";
            this.btnAddHat.Size = new System.Drawing.Size(179, 31);
            this.btnAddHat.TabIndex = 8;
            this.btnAddHat.Text = "Lägg till hatt i order";
            this.btnAddHat.UseVisualStyleBackColor = true;
            this.btnAddHat.Click += new System.EventHandler(this.btnAddHat_Click);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(685, 304);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(129, 28);
            this.btnAddImage.TabIndex = 9;
            this.btnAddImage.Text = "Lägg till bild";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Location = new System.Drawing.Point(233, 334);
            this.txtBoxComment.Multiline = true;
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.Size = new System.Drawing.Size(308, 102);
            this.txtBoxComment.TabIndex = 10;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(53, 385);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(60, 13);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Kommentar";
            // 
            // lblFabricLength
            // 
            this.lblFabricLength.AutoSize = true;
            this.lblFabricLength.Location = new System.Drawing.Point(52, 234);
            this.lblFabricLength.Name = "lblFabricLength";
            this.lblFabricLength.Size = new System.Drawing.Size(106, 13);
            this.lblFabricLength.TabIndex = 12;
            this.lblFabricLength.Text = "Tygföbrukningsmeter";
            // 
            // txtBoxFabricLength
            // 
            this.txtBoxFabricLength.Location = new System.Drawing.Point(233, 231);
            this.txtBoxFabricLength.Name = "txtBoxFabricLength";
            this.txtBoxFabricLength.Size = new System.Drawing.Size(40, 20);
            this.txtBoxFabricLength.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(620, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 231);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Enabled = false;
            this.txtBoxFileName.Location = new System.Drawing.Point(620, 268);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.ReadOnly = true;
            this.txtBoxFileName.Size = new System.Drawing.Size(255, 20);
            this.txtBoxFileName.TabIndex = 16;
            this.txtBoxFileName.Text = "Filväg";
            this.txtBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFabric
            // 
            this.lblFabric.AutoSize = true;
            this.lblFabric.Location = new System.Drawing.Point(53, 70);
            this.lblFabric.Name = "lblFabric";
            this.lblFabric.Size = new System.Drawing.Size(44, 13);
            this.lblFabric.TabIndex = 18;
            this.lblFabric.Text = "Material";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(233, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 116);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fabric";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Meters in stock";
            this.columnHeader3.Width = 98;
            // 
            // lblChosenFabric
            // 
            this.lblChosenFabric.AutoSize = true;
            this.lblChosenFabric.Location = new System.Drawing.Point(53, 200);
            this.lblChosenFabric.Name = "lblChosenFabric";
            this.lblChosenFabric.Size = new System.Drawing.Size(64, 13);
            this.lblChosenFabric.TabIndex = 20;
            this.lblChosenFabric.Text = "Valt material";
            // 
            // txtBoxChosenFabric
            // 
            this.txtBoxChosenFabric.Location = new System.Drawing.Point(233, 197);
            this.txtBoxChosenFabric.Name = "txtBoxChosenFabric";
            this.txtBoxChosenFabric.ReadOnly = true;
            this.txtBoxChosenFabric.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChosenFabric.TabIndex = 21;
            // 
            // SpecialHatForm
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.txtBoxChosenFabric);
            this.Controls.Add(this.lblChosenFabric);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblFabric);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtBoxFabricLength);
            this.Controls.Add(this.lblFabricLength);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtBoxComment);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAddHat);
            this.Controls.Add(this.txtBoxSize);
            this.Controls.Add(this.txtBoxDecoration);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblDecoration);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Name = "SpecialHatForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.SpecialHatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDecoration;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxDecoration;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.Button btnAddHat;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox txtBoxComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblFabricLength;
        private System.Windows.Forms.TextBox txtBoxFabricLength;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Label lblFabric;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblChosenFabric;
        private System.Windows.Forms.TextBox txtBoxChosenFabric;
    }
}