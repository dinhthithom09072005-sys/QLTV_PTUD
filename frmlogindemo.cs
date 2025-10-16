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
    public partial class frmlogindemo : Form
    {
        private Dictionary<string, string> taiKhoan = new Dictionary<string, string>()
        {
            { "11221432@neulib.com", "123456" },
            { "user1@gmail.com", "abc123" },
            {"11235630@gmail.com","070905" },
            {"11235576@gmail.com","220605" },
            {"11235538@gmail.com","230505" }
        };
        public frmlogindemo()
        {
            InitializeComponent();
        }

        private void frmlogindemo_Load(object sender, EventArgs e)
        {

        }

        private void btnlaymk_Click(object sender, EventArgs e)
        {
            string tenDN = txttendn.Text.Trim();

            // >>> THÊM MỚI: kiểm tra tên đăng nhập có tồn tại hay không
            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (taiKhoan.ContainsKey(tenDN))
            {
                // >>> Nếu có trong danh sách tài khoản
                MessageBox.Show("Mật khẩu đã được gửi về mail của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // >>> Nếu không có
                MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmDangnhap f = new FrmDangnhap();
            f.Show();
            this.Close();

        }
    }
}
