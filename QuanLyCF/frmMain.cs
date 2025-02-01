using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thoát Chương trình!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listviewsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Clear();
            frmThanhToan f = new frmThanhToan() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            pnlThanhToan.Controls.Add(f);
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Clear();
            frmSanPham f = new frmSanPham() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            pnlThanhToan.Controls.Add(f);
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool movePosition;
        int xCoordinate;
        int yCoordinate;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movePosition = true;
            xCoordinate = e.X;
            yCoordinate = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (movePosition)
            {
                this.SetDesktopLocation(MousePosition.X - xCoordinate, MousePosition.Y - yCoordinate);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            movePosition = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlThanhToan.Controls.Clear();
            frmTongDoanhThu f = new frmTongDoanhThu() { TopLevel = false, TopMost = true };
            f.FormBorderStyle = FormBorderStyle.None;
            pnlThanhToan.Controls.Add(f);
            f.Show();
        }

    }
}
