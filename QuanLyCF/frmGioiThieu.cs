﻿using System;
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
    public partial class frmGioiThieu: Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult = DialogResult.OK;
            
        }
    }
}
