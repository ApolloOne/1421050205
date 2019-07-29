namespace NguyenNgocTien1421050205.CustomControls
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PIC_ProductImage = new System.Windows.Forms.PictureBox();
            this.TXT_FirstDecr = new System.Windows.Forms.TextBox();
            this.TXT_SecondDecr = new System.Windows.Forms.TextBox();
            this.BTN_Buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC_ProductImage
            // 
            this.PIC_ProductImage.Location = new System.Drawing.Point(14, 33);
            this.PIC_ProductImage.Name = "PIC_ProductImage";
            this.PIC_ProductImage.Size = new System.Drawing.Size(214, 138);
            this.PIC_ProductImage.TabIndex = 0;
            this.PIC_ProductImage.TabStop = false;
            // 
            // TXT_FirstDecr
            // 
            this.TXT_FirstDecr.Location = new System.Drawing.Point(236, 87);
            this.TXT_FirstDecr.Multiline = true;
            this.TXT_FirstDecr.Name = "TXT_FirstDecr";
            this.TXT_FirstDecr.ReadOnly = true;
            this.TXT_FirstDecr.Size = new System.Drawing.Size(175, 84);
            this.TXT_FirstDecr.TabIndex = 1;
            this.TXT_FirstDecr.Text = "Tên sp: Máy lạnh sanyo\r\nXuất xứ: Pháp\r\n";
            // 
            // TXT_SecondDecr
            // 
            this.TXT_SecondDecr.Location = new System.Drawing.Point(14, 187);
            this.TXT_SecondDecr.Multiline = true;
            this.TXT_SecondDecr.Name = "TXT_SecondDecr";
            this.TXT_SecondDecr.ReadOnly = true;
            this.TXT_SecondDecr.Size = new System.Drawing.Size(395, 104);
            this.TXT_SecondDecr.TabIndex = 2;
            this.TXT_SecondDecr.Text = "Điện áp: 25Kw\r\nMàu sắc: Đỏ";
            // 
            // BTN_Buy
            // 
            this.BTN_Buy.Location = new System.Drawing.Point(236, 33);
            this.BTN_Buy.Name = "BTN_Buy";
            this.BTN_Buy.Size = new System.Drawing.Size(175, 37);
            this.BTN_Buy.TabIndex = 3;
            this.BTN_Buy.Text = "Buy";
            this.BTN_Buy.UseVisualStyleBackColor = true;
            this.BTN_Buy.Click += new System.EventHandler(this.BTN_Buy_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.BTN_Buy);
            this.Controls.Add(this.TXT_SecondDecr);
            this.Controls.Add(this.TXT_FirstDecr);
            this.Controls.Add(this.PIC_ProductImage);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(422, 311);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_ProductImage;
        private System.Windows.Forms.TextBox TXT_FirstDecr;
        private System.Windows.Forms.TextBox TXT_SecondDecr;
        private System.Windows.Forms.Button BTN_Buy;
    }
}
