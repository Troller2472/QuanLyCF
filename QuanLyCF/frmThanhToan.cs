using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyCF
{
    public partial class frmThanhToan : Form
    {
        QuanLyCFEntities db = new QuanLyCFEntities();
        private DataTable cthd;


        public frmThanhToan()
        {
            InitializeComponent();

            
        }
        public void tinhTongTien()
        {

            decimal totalAmount = 0;
            foreach (DataRow row in cthd.Rows)
            {
                totalAmount += (decimal)row["Tong1"];
            }
            lbTong.Text = "Tổng: " + totalAmount.ToString();
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "MaLoaiSP";
            comboBox1.DisplayMember = "TenLoaiSP";
            comboBox1.DataSource = db.LoaiSP.ToList();
            

            cthd = new DataTable();
            cthd.Columns.Add("TenSP1");
            cthd.Columns.Add("SL1", typeof(int));
            cthd.Columns.Add("DonGia1", typeof(decimal));
            cthd.Columns.Add("Tong1", typeof(decimal), "SL1 * DonGia1");
            cthd.Columns.Add("GhiChu1", typeof(string));

            dataGridView1.DataSource = cthd;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView2.DataSource = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(comboBox1.SelectedValue.ToString()));

            flowLayoutPanel1.Controls.Clear();
            var database = db.SanPham_SP_ChonSPTheoLoai1(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
            foreach (var i in database)
            {
                Byte[] anhcf = (byte[])i.Anh;
                MemoryStream stmdata = new MemoryStream(anhcf);
                Image img = Image.FromStream(stmdata);

                var sp = new ctrlSanPham()
                {
                    PName = i.TenSP,
                    PPrice = Convert.ToInt32(i.Gia),
                    PImage = img
                };
                sp.onSelect += (ss, ee) =>
                {
                    foreach (DataRow row in cthd.Rows)
                    {
                        if(row["TenSP1"].ToString() == i.TenSP)
                        {
                            row["SL1"] = (int)row["SL1"] + 1;

                            tinhTongTien();
                            return;
                        }
                    }

                    cthd.Rows.Add(i.TenSP, 1, i.Gia);
                    tinhTongTien();
                };
                flowLayoutPanel1.Controls.Add(sp);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.SanPham_SP_GETALL1();

            flowLayoutPanel1.Controls.Clear();
            var database = db.SanPham_SP_GETALL1();
            foreach (var i in database)
            {
                Byte[] anhcf = (byte[])i.Anh;
                MemoryStream stmdata = new MemoryStream(anhcf);
                Image img = Image.FromStream(stmdata);
                var sp = new ctrlSanPham()
                {
                    PName = i.TenSP,
                    PPrice = Convert.ToInt32(i.Gia),
                    PImage = img

                };
                sp.onSelect += (ss, ee) =>
                {
                    foreach (DataRow row in cthd.Rows)
                    {
                        if (row["TenSP1"].ToString() == i.TenSP)
                        {
                            row["SL1"] = (int)row["SL1"] + 1;

                            tinhTongTien();
                            return;
                        }
                    }

                    cthd.Rows.Add(i.TenSP, 1, i.Gia);
                    tinhTongTien();
                };
                flowLayoutPanel1.Controls.Add(sp);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string productName = dataGridView2.CurrentRow.Cells["TenSP"].Value.ToString();
            decimal price = Convert.ToDecimal(dataGridView2.CurrentRow.Cells["GiaBan"].Value.ToString());

            foreach (DataRow row in cthd.Rows)
            {
                if (row["TenSP1"].ToString() == productName)
                {

                    row["SL1"] = (int)row["SL1"] + 1;

                    tinhTongTien();
                    return;
                }
            }
            
            cthd.Rows.Add(productName, 1 , price);
            tinhTongTien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                tinhTongTien();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có chắc muốn lưu hoá đơn?", "Lưu Hoá đơn",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            db.HoaDon_LuuHoaDon(tbxTenKH.Text);
            foreach(DataRow row in cthd.Rows)
            {
                MessageBox.Show(row["Tong1"].ToString());

                db.CTHD_ThemHDCuoi("", row["TenSP1"].ToString(),
                    Convert.ToDouble(row["DonGia1"].ToString()),
                    Convert.ToInt32(row["SL1"].ToString()),
                    row["GhiChu1"].ToString(),
                    DateTime.Now);
            }
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["SoLuong"].Index)
            {
                // Lấy giá trị nhập vào
                string newValue = e.FormattedValue.ToString();
                tinhTongTien();
                int quantity;
                // Kiểm tra nếu giá trị nhập vào không phải là số nguyên
                if (!int.TryParse(newValue, out quantity) || quantity < 0)
                {
                    // Nếu không hợp lệ, hiển thị thông báo lỗi
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên không âm).");
                    e.Cancel = true; // Hủy việc rời khỏi ô
                }
            }
        }

        private void pnlThanhToan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
