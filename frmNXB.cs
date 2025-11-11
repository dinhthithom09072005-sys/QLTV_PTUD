using DevExpress.Data;
using DevExpress.Data.Mask.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmNXB : Form
    {
        SqlConnection conn; 
        SqlDataAdapter da;
        DataTable dt;
        DataView dv;
        string str, sql;
        public frmNXB()
        {
            InitializeComponent();
        }

        public void NapCT()
        {
            int i = dgv_NXB.CurrentRow.Index;
            txt_MaNXB.Text = dgv_NXB.Rows[i].Cells[0].Value.ToString();
            txt_TenNXB.Text = dgv_NXB.Rows[i].Cells[1].Value.ToString();
            txt_email.Text = dgv_NXB.Rows[i].Cells[2].Value.ToString();
        }

        private void dgv_NXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void ClearForm()
        {            
            txt_MaNXB.Clear();
            txt_TenNXB.Clear();
            txt_email.Clear();

            txt_MaNXB.Enabled = true; // Cho phép nhập lại Số thẻ (phòng TH sửa khóa ô này)
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false; // Khóa nút Sửa, tránh nhầm
            btn_Xoa.Enabled = false; // Khóa nút Xóa, tránh nhầm
            txt_MaNXB.Focus(); // Focus lại vào ô đầu tiên
        }



        private void btn_first_Click(object sender, EventArgs e)
        {
            dgv_NXB.ClearSelection();
            dgv_NXB.CurrentCell = dgv_NXB[0, 0];
            NapCT();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int i= dgv_NXB.Rows.Count - 1;
            dgv_NXB.CurrentCell = dgv_NXB[0, i];
            NapCT();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int i = dgv_NXB.CurrentRow.Index;
            if (i < dgv_NXB.Rows.Count - 1)
            {
                dgv_NXB.CurrentCell = dgv_NXB[0, i + 1];
                NapCT();
            }   
        }

        private void btn_prv_Click(object sender, EventArgs e)
        {
            int i = dgv_NXB.CurrentRow.Index;
            if (i > 0)
            {
                dgv_NXB.CurrentCell = dgv_NXB[0, i - 1];
                NapCT();
            }
        }

        

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maNXB = txt_MaNXB.Text.Trim();
            string tenNXB = txt_TenNXB.Text.Trim();
            string email = txt_email.Text.ToString();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                string query = "INSERT INTO NXB (Ma_NXB, Ten_NXB, email) " +
                               "VALUES (@maNXB, @tenNXB, @email)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Transaction = tran; // ⚠ Gán transaction vào command          


                cmd.Parameters.AddWithValue("@maNXB", txt_MaNXB.Text); 
                cmd.Parameters.AddWithValue("@tenNXB", txt_TenNXB.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
               
                int rows = cmd.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Thêm NXB thành công!");

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = "UPDATE NXB SET Ten_NXB = @tenNXB, email = @email WHere Ma_NXB = @maNXB";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maNXB", txt_MaNXB.Text.Trim()); // KHÔNG CHO SỬA KEY
            cmd.Parameters.AddWithValue("@tenNXB", txt_TenNXB.Text.Trim());
            cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim());

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Cập nhật thông tin thành công!");
            else
                MessageBox.Show("Không có dữ liệu nào được cập nhật!");

            // Load lại dữ liệu dgv
            LoadData();

            ClearForm();
        }

        private void btn_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaNXB.Text))
            {
                MessageBox.Show("Vui lòng chọn NXB cần xóa!", "Thông báo");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa NXB này?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM NXB WHERE Ma_NXB = @maNXB";

                    using (SqlConnection conn = new SqlConnection("Data Source = ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False")) // <-- Tạo kết nối mới an toàn
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@maNXB", txt_MaNXB.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã xóa thành công!");

                    // Load lại DGV
                    LoadData();

                    ClearForm();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    txt_MaNXB.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm ();
        }

        private void dgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {
                NapCT();
                btn_Them.Enabled = false; // Khóa nút Thêm để tránh nhầm
                btn_Sua.Enabled = true; // Mở nút Sửa
                btn_Xoa.Enabled = true; // Mở nút Xóa
                txt_MaNXB.Enabled = false; // Khóa ô Mã NXB để tránh sửa khóa chính
                }   
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv_NXB.DataSource = dt; // Gán lại dữ liệu gốc
           
        }

        private void grb_filter_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void LoadData()
        {
            sql = "select * from NXB";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_NXB.DataSource = dt;
        }

        private void btn_search_TextChanged(object sender, EventArgs e)
        {
            // kiểm tra xem dv có tồn tại không 
            if (dv == null) return;
            // lấy chuỗi tìm kiếm từ btn_search, replace đề phòng lỗi
            string filterText = btn_search.Text.Trim().Replace("'", "''");
            //nếu chuỗi tìm kiếm rỗng thì bỏ lọc
            if (string.IsNullOrEmpty(filterText))
            {
                dv.RowFilter = "";
            }
            else
            {
                //tạo chuỗi lọc
                string filter = "";
                //duyệt qua các cột kiểu string để tạo điều kiện lọc
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType == typeof(string))
                    {
                        //Tự động tạo câu lệnh "TênCột LIKE '%NộiDung%'" và nối bằng OR
                        if (filter != "") filter += " OR ";
                        filter += $"{col.ColumnName} LIKE '%{filterText}%'";
                    }
                }
                // gán điều kiện lọc vào dataview
                dv.RowFilter = filter;
            }
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            str = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
            dv = new DataView(dt);
            dgv_NXB.DataSource = dv;

        }
        private void frmNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
