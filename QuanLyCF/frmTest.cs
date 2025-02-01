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
    public partial class frmTest : Form
    {
        QuanLyCFEntities db = new QuanLyCFEntities();
        public frmTest()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dssp = db.SanPham_SP_GETALL1();
            foreach(var item in dssp)
            {
                var w = new ctrlSanPham()
                {
                    PName = item.TenSP,

                    PPrice = Convert.ToInt32(item.Gia)
                };

                w.onSelect += (ss, ee) =>
                {
                    var wdg = (ctrlSanPham)ss;
                    label1.Text = wdg.PPrice.ToString();
                    label2.Text = wdg.PName.ToString();
                };
                fplnDSSP.Controls.Add(w);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fplnDSSP.Controls.Clear();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.SanPham_SP_GETALL1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
        }
    }
}
