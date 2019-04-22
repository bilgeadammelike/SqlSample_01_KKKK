namespace SqlSample.WinUI
{
    partial class FormCategory
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
            this.lstboxData = new System.Windows.Forms.ListBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.pictureboxPicture = new System.Windows.Forms.PictureBox();
            this.cmboxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstboxProducts = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lstboxData
            // 
            this.lstboxData.FormattingEnabled = true;
            this.lstboxData.Location = new System.Drawing.Point(397, 246);
            this.lstboxData.Name = "lstboxData";
            this.lstboxData.Size = new System.Drawing.Size(122, 82);
            this.lstboxData.TabIndex = 0;
            this.lstboxData.SelectedValueChanged += new System.EventHandler(this.lstboxData_SelectedValueChanged);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(199, 10);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 23);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // pictureboxPicture
            // 
            this.pictureboxPicture.Location = new System.Drawing.Point(12, 36);
            this.pictureboxPicture.Name = "pictureboxPicture";
            this.pictureboxPicture.Size = new System.Drawing.Size(162, 108);
            this.pictureboxPicture.TabIndex = 2;
            this.pictureboxPicture.TabStop = false;
            // 
            // cmboxCategories
            // 
            this.cmboxCategories.FormattingEnabled = true;
            this.cmboxCategories.Location = new System.Drawing.Point(72, 12);
            this.cmboxCategories.Name = "cmboxCategories";
            this.cmboxCategories.Size = new System.Drawing.Size(121, 21);
            this.cmboxCategories.TabIndex = 3;
            this.cmboxCategories.SelectedValueChanged += new System.EventHandler(this.cmboxCategories_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategoriler";
            // 
            // lstboxProducts
            // 
            this.lstboxProducts.FormattingEnabled = true;
            this.lstboxProducts.Location = new System.Drawing.Point(12, 181);
            this.lstboxProducts.Name = "lstboxProducts";
            this.lstboxProducts.Size = new System.Drawing.Size(339, 147);
            this.lstboxProducts.TabIndex = 5;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(444, 121);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSepeteEkle.TabIndex = 7;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 340);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstboxProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxCategories);
            this.Controls.Add(this.pictureboxPicture);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.lstboxData);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxData;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.PictureBox pictureboxPicture;
        private System.Windows.Forms.ComboBox cmboxCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstboxProducts;
        private System.Windows.Forms.Button btnSepeteEkle;
    }
}