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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        QuanLyCFEntities db = new QuanLyCFEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var database = db.TaiKhoan.ToList();
            foreach(var i in database)
            {
                if (textBox1.Text == i.TenTK && textBox2.Text == i.MatKhau)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    string username = i.TenTK.ToString();
                    string pass = i.MatKhau.ToString();
                    int admin = i.admin.Value;

                    frmMain f = new frmMain(username,pass,admin);
                    f.Show();
                    this.Hide();
                   

                    return;
                }
            }
            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
