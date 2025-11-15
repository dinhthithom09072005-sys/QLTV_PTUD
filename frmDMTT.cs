using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;    
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmDMTT : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        DataView dv;
        string str, sql;
        public frmDMTT()
        {
            InitializeComponent();
        }

        private void NapCT()
        {
            int i = dgv_DMTT.CurrentRow.Index;
            txt_MaTT.Text = dgv_DMTT.Rows[i].Cells[0].Value.ToString();
            txt_TenTT.Text = dgv_DMTT.Rows[i].Cells[1].Value.ToString();
            txt_SDT.Text = dgv_DMTT.Rows[i].Cells[2].Value.ToString();
            dgv_DMTT.ClearSelection();
            dgv_DMTT.Rows[i].Selected = true;

        }

        private void btn_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_MaTT_Click(object sender, EventArgs e)
        {

        }

        private void frmDMTT_Load(object sender, EventArgs e)
        {
            str = "Data Source = LAPTOP-W3DTHM; Initial Catalog = QLTV; Integrated Security = True; Encrypt = False";
            conn = new SqlConnection(str);
            conn.Open();
            sql = "select * from THU_THU";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_DMTT.DataSource = dt;
            //tạo dataview từ dt
            dv = new DataView(dt);
            dgv_DMTT.DataSource = dv;

            // đổi tên cột trong dgv
            dgv_DMTT.Columns["Ma_Thu_Thu"].HeaderText = "Mã thủ thư";
            dgv_DMTT.Columns["Ten_Thu_Thu"].HeaderText = "Tên thủ thư";
            dgv_DMTT.Columns["SDT"].HeaderText = "SĐT";
           
        }

        private void dgv_DMTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh lỗi khi click header
            {
                DataGridViewRow row = dgv_DMTT.Rows[e.RowIndex];

                txt_MaTT.Text = row.Cells["Ma_Thu_Thu"].Value.ToString();
                txt_TenTT.Text = row.Cells["Ten_Thu_Thu"].Value.ToString();
                txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                              
                txt_MaTT.Enabled = false; // Không cho đổi mã thẻ khi sửa
                btn_Them.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
            }
        }
        private void ClearForm()
        {
            txt_MaTT.Clear();
            txt_TenTT.Clear();
            txt_SDT.Clear();
           
            txt_MaTT.Enabled = true; // Cho phép nhập lại Số thẻ (phòng TH sửa khóa ô này)
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false; // Khóa nút Sửa, tránh nhầm
            btn_Xoa.Enabled = false; // Khóa nút Xóa, tránh nhầm
            txt_MaTT.Focus(); // Focus lại vào ô đầu tiên
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaTT = txt_MaTT.Text.Trim();
            string hoTen = txt_TenTT.Text.Trim();
            string sdt = txt_SDT.Text.ToString();
            
            // mở DB        
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                string query = "INSERT INTO THU_THU (Ma_Thu_Thu,Ten_Thu_Thu, SDT) " +
                               "VALUES (@MaTT, @HoTen, @SDT)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Transaction = tran; // ⚠ Gán transaction vào command          


                cmd.Parameters.AddWithValue("@MaTT", txt_MaTT.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_TenTT.Text);
                cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
               
                // ⚠ THIẾU DÒNG NÀY NÊN KHÔNG INSERT VÀO DB
                int rows = cmd.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Thêm thủ thư thành công!");

                dt.Clear();
                da.Fill(dt);
                ClearForm();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "UPDATE THU_THU SET Ten_Thu_Thu = @HoTen, SDT = @SDT WHere Ma_Thu_Thu = @MaTT";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaTT", txt_MaTT.Text.Trim()); // KHÔNG CHO SỬA KEY
            cmd.Parameters.AddWithValue("@HoTen", txt_TenTT.Text.Trim());
            cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text.Trim());
            
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Cập nhật thông tin thành công!");
            else
                MessageBox.Show("Không có dữ liệu nào được cập nhật!");

            // Load lại dữ liệu dgv
            dt.Clear();
            da.Fill(dt);

            ClearForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTT.Text))
            {
                MessageBox.Show("Vui lòng chọn thủ thư cần xóa!", "Thông báo");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa thủ thư này?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM THU_THU WHERE Ma_Thu_Thu = @MaTT";

                    using (SqlConnection conn = new SqlConnection("Data Source = ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False")) // <-- Tạo kết nối mới an toàn
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaTT", txt_MaTT.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã xóa thành công!");

                    // Load lại DGV
                    dt.Clear();
                    da.Fill(dt);

                    ClearForm();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    txt_MaTT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            dgv_DMTT.ClearSelection();
            dgv_DMTT.CurrentCell = dgv_DMTT[0, 0];
            NapCT();
        }

                     

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int i = dgv_DMTT.CurrentRow.Index;
            if (i > 0)
            {
                dgv_DMTT.CurrentCell = dgv_DMTT[0, i - 1];
                NapCT();
            }
        }

        private void btn_next_Click_1(object sender, EventArgs e)
        {
            int i = dgv_DMTT.CurrentRow.Index;
            if (i < dgv_DMTT.Rows.Count - 1)
            {
                dgv_DMTT.CurrentCell = dgv_DMTT[0, i + 1];
                NapCT();
            }
        }

        private void btn_last_Click_1(object sender, EventArgs e)
        {
            int i = dgv_DMTT.Rows.Count - 1;
            dgv_DMTT.CurrentCell = dgv_DMTT[0, i];
            NapCT();
        }

        private void dgv_DMTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmDMTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
