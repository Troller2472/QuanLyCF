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
    public partial class frmTongDoanhThu : Form
    {
        QuanLyCFEntities db = new QuanLyCFEntities();
        public frmTongDoanhThu()
        {
            InitializeComponent();
        }

        private void frmTongDoanhThu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.HoaDon_GetALL();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = db.CTHD_SanPhamTheoMaHD(Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaHD"].Value.ToString()));
        }
    }
}
