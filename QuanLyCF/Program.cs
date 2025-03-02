using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCF
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            frmGioiThieu f = new frmGioiThieu();

            if (f.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmLogin());
            }
                
            
        }
    }
}
