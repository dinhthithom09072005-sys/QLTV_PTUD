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
    public partial class FrmDangnhap : Form
    {     // Tạo danh sách tài khoản mẫu (tên đăng nhập - mật khẩu)
        private Dictionary<string, string> taiKhoan = new Dictionary<string, string>()
        {
            { "11221432@neulib.com", "123456" },
            { "user1", "abc123" },
            {"11235660@gmail.com","090705" },
            {"11235576@gmail.com","220605" },
            {"11235538@gmail.com","230505" }
        };
        private Dictionary<string, string> ghiNhoTaiKhoan = new Dictionary<string, string>();

        public FrmDangnhap()
        {
            InitializeComponent();
            // Khi form load, kiểm tra có ghi nhớ tài khoản trước đó không
            
            if (Properties.Settings.Default.Username != "")
            {
                txttendn.Text = Properties.Settings.Default.Username;
                txtmk.Text = Properties.Settings.Default.Password;
                chkgnmk.Checked = true;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SavedAccounts))
            {
                var pairs = Properties.Settings.Default.SavedAccounts.Split(';');
                foreach (var p in pairs)
                {
                    if (string.IsNullOrWhiteSpace(p)) continue;
                    var parts = p.Split('|');
                    if (parts.Length == 2)
                        ghiNhoTaiKhoan[parts[0]] = parts[1];
                }
            }
            // Gợi ý auto-complete cho TextBox tên đăng nhập
            var auto = new AutoCompleteStringCollection();
            auto.AddRange(ghiNhoTaiKhoan.Keys.ToArray());
            txttendn.AutoCompleteCustomSource = auto;
            txttendn.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txttendn.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Khi người dùng đổi tên đăng nhập -> tự điền mật khẩu
            txttendn.TextChanged += txttendn_TextChanged;
        }

        private void txttendn_TextChanged(object sender, EventArgs e)
        {
            string username = txttendn.Text.Trim();
            if (ghiNhoTaiKhoan.ContainsKey(username))
                txtmk.Text = ghiNhoTaiKhoan[username];
            else
                txtmk.Clear();
        }
        private void FrmDangnhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe)
            {
                txttendn.Text = Properties.Settings.Default.Username;   // >>> THÊM MỚI
                txtmk.Text = Properties.Settings.Default.Password;       // >>> THÊM MỚI
                chkgnmk.Checked = true;                                  // >>> THÊM MỚI
            }
            else
            {
                txttendn.Text = Properties.Settings.Default.Username;   // >>> THÊM MỚI
                txtmk.Text = "";                                        // >>> THÊM MỚI
                chkgnmk.Checked = false;                                // >>> THÊM MỚI
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            string username = txttendn.Text.Trim();
            string password = txtmk.Text;

            // Kiểm tra tên đăng nhập và mật khẩu có đúng không
            if (taiKhoan.ContainsKey(username) && taiKhoan[username] == password)
            {
                // Nếu chọn ghi nhớ mật khẩu
                if (chkgnmk.Checked)
                {
                    ghiNhoTaiKhoan[username] = password;
                    // Lưu lại vào Settings
                    Properties.Settings.Default.SavedAccounts = string.Join(";", ghiNhoTaiKhoan.Select(kv => kv.Key + "|" + kv.Value));
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    // Nếu bỏ ghi nhớ
                    if (ghiNhoTaiKhoan.ContainsKey(username))
                        ghiNhoTaiKhoan.Remove(username);

                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.RememberMe = false;
                }

                Properties.Settings.Default.Save();
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttendn.Clear();
                txtmk.Clear();
                txttendn.Focus();
            }           
        }
    }   
}
  
