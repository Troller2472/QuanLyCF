namespace QuanLyCF
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.fplnDSSP = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlSanPham2 = new QuanLyCF.ctrlSanPham();
            this.ctrlSanPham1 = new QuanLyCF.ctrlSanPham();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTenSP = new System.Windows.Forms.TextBox();
            this.tbxGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fplnDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fplnDSSP
            // 
            this.fplnDSSP.AutoScroll = true;
            this.fplnDSSP.Controls.Add(this.ctrlSanPham2);
            this.fplnDSSP.Controls.Add(this.ctrlSanPham1);
            this.fplnDSSP.Location = new System.Drawing.Point(196, 12);
            this.fplnDSSP.Name = "fplnDSSP";
            this.fplnDSSP.Size = new System.Drawing.Size(257, 414);
            this.fplnDSSP.TabIndex = 0;
            // 
            // ctrlSanPham2
            // 
            this.ctrlSanPham2.id = 0;
            this.ctrlSanPham2.Location = new System.Drawing.Point(3, 3);
            this.ctrlSanPham2.Name = "ctrlSanPham2";
            this.ctrlSanPham2.PCategory = null;
            this.ctrlSanPham2.PImage = ((System.Drawing.Image)(resources.GetObject("ctrlSanPham2.PImage")));
            this.ctrlSanPham2.PName = "Tên Sản Phẩm";
            this.ctrlSanPham2.PPrice = 0;
            this.ctrlSanPham2.Size = new System.Drawing.Size(236, 125);
            this.ctrlSanPham2.TabIndex = 1;
            // 
            // ctrlSanPham1
            // 
            this.ctrlSanPham1.id = 0;
            this.ctrlSanPham1.Location = new System.Drawing.Point(3, 134);
            this.ctrlSanPham1.Name = "ctrlSanPham1";
            this.ctrlSanPham1.PCategory = null;
            this.ctrlSanPham1.PImage = ((System.Drawing.Image)(resources.GetObject("ctrlSanPham1.PImage")));
            this.ctrlSanPham1.PName = "Tên Sản Phẩm";
            this.ctrlSanPham1.PPrice = 0;
            this.ctrlSanPham1.Size = new System.Drawing.Size(236, 125);
            this.ctrlSanPham1.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lấy Giá Tiền";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxTenSP
            // 
            this.tbxTenSP.Location = new System.Drawing.Point(54, 34);
            this.tbxTenSP.Name = "tbxTenSP";
            this.tbxTenSP.Size = new System.Drawing.Size(100, 20);
            this.tbxTenSP.TabIndex = 3;
            // 
            // tbxGia
            // 
            this.tbxGia.Location = new System.Drawing.Point(54, 72);
            this.tbxGia.Name = "tbxGia";
            this.tbxGia.Size = new System.Drawing.Size(100, 20);
            this.tbxGia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lấy tên SP";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(706, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxGia);
            this.Controls.Add(this.tbxTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fplnDSSP);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.fplnDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fplnDSSP;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGia;
        private System.Windows.Forms.TextBox tbxTenSP;
        private System.Windows.Forms.Button button2;
        private ctrlSanPham ctrlSanPham2;
        private ctrlSanPham ctrlSanPham1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}