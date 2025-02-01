namespace QuanLyCF
{
    partial class ctrlSanPham
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
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAnh
            // 
            this.pbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAnh.Image = global::QuanLyCF.Properties.Resources.logocf;
            this.pbAnh.Location = new System.Drawing.Point(8, 11);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(96, 92);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 0;
            this.pbAnh.TabStop = false;
            this.pbAnh.Click += new System.EventHandler(this.pbAnh_Click);
            this.pbAnh.MouseLeave += new System.EventHandler(this.pbAnh_MouseLeave);
            this.pbAnh.MouseHover += new System.EventHandler(this.pbAnh_MouseHover);
            // 
            // lbTenSP
            // 
            this.lbTenSP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(109, 0);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(108, 87);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            this.lbTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbGia.Location = new System.Drawing.Point(132, 87);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(66, 16);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá Tiền";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbAnh);
            this.panel1.Controls.Add(this.lbGia);
            this.panel1.Controls.Add(this.lbTenSP);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 117);
            this.panel1.TabIndex = 3;
            // 
            // ctrlSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctrlSanPham";
            this.Size = new System.Drawing.Size(231, 125);
            this.Load += new System.EventHandler(this.ctrlSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Panel panel1;
    }
}
