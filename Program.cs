using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_QLTV
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
            using (FrmDangnhap loginForm = new FrmDangnhap())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMain());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
