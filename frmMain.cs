using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
     
        }
        private void LoadForm(Form frm)
        {
            // Xóa form con cũ nếu có
            panelMain.Controls.Clear();

            // Thiết lập form con để nhúng vào panel
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

         
            // Thêm form con vào panel và hiển thị
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmMuonTra());
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmDangnhap frmLogin = new FrmDangnhap();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Nếu đăng nhập thành công, hiển thị lại form main
                this.Show();
            }
            else
            {
                // Nếu bấm hủy, thoát chương trình
                this.Close();
            }
        }

        private void phiếuPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmPP());
        }

        private void tiêuĐềTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new frmTaiLieu());
        }
    }
}
