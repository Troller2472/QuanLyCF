using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCF
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        
        QuanLyCFEntities db = new QuanLyCFEntities();
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.LoaiSP_GetALL();
            load_combobox();
        }
        private void load_combobox()
        {
            cbxLoaiSP.ValueMember = "MaLoaiSP";
            cbxLoaiSP.DisplayMember = "TenLoaiSP";
            cbxLoaiSP.DataSource = db.LoaiSP_GetALL();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                db.LoaiSP_XoaLoaiSP(Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaLoaiSP"].Value));
                dataGridView1.DataSource = db.LoaiSP_GetALL();
            }

            pictureBox1.Image = QuanLyCF.Properties.Resources.logocf;

            dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(dataGridView1[1,dataGridView1.CurrentRow.Index].Value.ToString()));
            cbxLoaiSP.SelectedIndex = dataGridView1.CurrentRow.Index;
            tbxTenSP.Clear();
            tbxGiaBan.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxLoaiSP.TextLength >= 2)
            {
                db.LoaiSP_ThemLoaiSP(tbxLoaiSP.Text);
                tbxLoaiSP.Clear();
                dataGridView1.DataSource = db.LoaiSP_GetALL();
                load_combobox();
            }
            else
            {
                MessageBox.Show("Bạn Nên Đặt Tên Loại SP Dài Hơn");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.SanPham_SP_GETALL1();
        }

        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

            //dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai(Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()));
           // tbxTenSP.Clear();
            //tbxGiaBan.Clear();
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            {
                return;
            }
            if (e.ColumnIndex == dataGridView2.Columns["Xoa1"].Index && e.RowIndex >= 0)
            {
                db.SanPham_XoaSP(Convert.ToInt32(dataGridView2.CurrentRow.Cells["MaSP"].Value));

                dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()));
                return;
            }

            int curror = dataGridView2.CurrentRow.Index;
            tbxTenSP.Text = dataGridView2.CurrentRow.Cells["TenSP"].Value.ToString();
            tbxGiaBan.Text = dataGridView2.CurrentRow.Cells["GiaBan"].Value.ToString();


            Byte[] sp = (byte[])dataGridView2.CurrentRow.Cells["Anh"].Value;
            MemoryStream stmdata = new MemoryStream(sp);
            pictureBox1.Image = Image.FromStream(stmdata);


            //Click
            // Example value you want to set as selected

            int i = 0;
            foreach (var item in db.LoaiSP_GetALL())
            {
                
                if (item.MaLoaiSP.ToString() == dataGridView2.CurrentRow.Cells["MaLoaiSP1"].Value.ToString())
                {
                    break;
                }
                i++;


            }
            cbxLoaiSP.SelectedIndex = i;

        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxGiaBan.Text, out int check))
            {
                MessageBox.Show("Bạn Phải Nhập số vào trường này!");
                return;

            }
            if (tbxGiaBan.TextLength <= 0 || tbxTenSP.TextLength <= 0)
            {
                MessageBox.Show("Không được để trống Các ô!");
                return;
            }

            var Anh = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));


            db.SanPham_ThemSP(tbxTenSP.Text, Convert.ToDouble(tbxGiaBan.Text), "", Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()), (byte[])Anh);
            dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()));
            tbxTenSP.Clear();
            tbxGiaBan.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxGiaBan.Text, out int check))
            {
                MessageBox.Show("Bạn Phải Nhập số vào trường này!");
                return;

            }
            if (tbxGiaBan.TextLength <= 0 || tbxTenSP.TextLength <= 0)
            {
                MessageBox.Show("Không được để trống Các ô!");
                return;
            }

            if (MessageBox.Show("Bạn có Chắc muốn thay đổi?","Cảnh báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var Anh = new ImageConverter().ConvertTo(pictureBox1.Image, typeof(Byte[]));
                db.SanPham_SuaSP(Convert.ToInt32(dataGridView2.CurrentRow.Cells["MaSP"].Value.ToString()),
                tbxTenSP.Text, Convert.ToDouble(tbxGiaBan.Text), "", Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()),(byte[])Anh);
                dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(cbxLoaiSP.SelectedValue.ToString()));
                tbxTenSP.Clear();
                tbxGiaBan.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoTen(tbxSearch.Text);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoTen(tbxSearch.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chonanh = new OpenFileDialog();
                chonanh.FileName = "";
                chonanh.Filter = "Images|*.jpg;*.jpeg;*.png";
                if (chonanh.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(chonanh.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi Hình ảnh , vui lòng chọn lại!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
        }
    }
}
