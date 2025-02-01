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
    
    public partial class ctrlSanPham : UserControl
    {
        public ctrlSanPham()
        {
            InitializeComponent();
            
        }

        public event EventHandler onSelect = null;
        public int id { get; set; }
        public int PPrice { get; set;}
        public string PCategory { get; set; }
        public string PName 
        {
            get { return lbTenSP.Text; }
            set { lbTenSP.Text = value; }
        }          
        public Image PImage 
        {
            get { return pbAnh.Image; }
            set { pbAnh.Image = value; }
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void pbAnh_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Wheat;
        }

        private void pbAnh_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void ctrlSanPham_Load(object sender, EventArgs e)
        {
            lbGia.Text = PPrice.ToString() + " VNĐ";
        }
    }
}
