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
    public partial class frmTG : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        DataView dv;
        string str, sql;
        public frmTG()
        {
            InitializeComponent();
        }

        public void NapCT ()
        {
            int i = dgv_TG.CurrentRow.Index;
            txt_MaTG.Text = dgv_TG.Rows[i].Cells[0].Value.ToString();
            txt_TenTG.Text = dgv_TG.Rows[i].Cells[1].Value.ToString();
            dt_NS.Value = Convert.ToDateTime(dgv_TG.Rows[i].Cells[2].Value);
        }

        private void frmTG_Load(object sender, EventArgs e)
        {
            str = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();

            dv = new DataView(dt);         // thêm dòng này
            dgv_TG.DataSource = dv;

            NapCT();

            dgv_TG.Columns["Nam_Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void LoadData()
        {
            sql = "SELECT * FROM TAC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_TG.DataSource = dt;

            // Nếu bạn dùng DataView để tìm kiếm, cập nhật lại luôn
            dv = new DataView(dt);
            dgv_TG.DataSource = dv;

            dgv_TG.Columns["Nam_Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgv_TG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void ClearForm()
        {
            txt_MaTG.Clear();
            txt_TenTG.Clear();
            dt_NS.Value = DateTime.Now;
            txt_MaTG.Enabled = true; // Cho phép nhập lại Số thẻ (phòng TH sửa khóa ô này)
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false; // Khóa nút Sửa, tránh nhầm
            btn_Xoa.Enabled = false; // Khóa nút Xóa, tránh nhầm
            txt_MaTG.Focus(); // Focus lại vào ô đầu tiên            
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            dgv_TG.ClearSelection();
            dgv_TG.CurrentCell = dgv_TG[0, 0];
            NapCT();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int i = dgv_TG.CurrentRow.Index;
            if (i > 0)
            {
                dgv_TG.CurrentCell = dgv_TG[0, i - 1];
                NapCT();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int i = dgv_TG.CurrentRow.Index;
            if (i < dgv_TG.Rows.Count - 1)
            {
                dgv_TG.CurrentCell = dgv_TG[0, i + 1];
                NapCT();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int i = dgv_TG.Rows.Count - 1;
            dgv_TG.CurrentCell = dgv_TG[0, i];
            NapCT();
        }

        private void dgv_TG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_TG.Columns[e.ColumnIndex].Name != "chi_tiet")
            {
                NapCT();
                btn_Them.Enabled = false; // Khóa nút Thêm để tránh nhầm
                btn_Sua.Enabled = true; // Mở nút Sửa
                btn_Xoa.Enabled = true; // Mở nút Xóa
                txt_MaTG.Enabled = false; // Khóa ô Mã NXB để tránh sửa khóa chính
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maTG = txt_MaTG.Text.Trim();
            string tenTG = txt_TenTG.Text.Trim();
            DateTime ns = dt_NS.Value;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                string query = "INSERT INTO TAC_GIA (Ma_Tac_Gia, Ten_Tac_Gia, Nam_Sinh) " +
                               "VALUES (@maTG, @tenTG, @ns)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Transaction = tran; // ⚠ Gán transaction vào command          


                cmd.Parameters.AddWithValue("@maTG", txt_MaTG.Text);
                cmd.Parameters.AddWithValue("@tenTG", txt_TenTG.Text);
                cmd.Parameters.AddWithValue("@ns", dt_NS.Value);

                int rows = cmd.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Thêm tác giả thành công!");

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
            string query = "UPDATE TAC_GIA SET Ten_Tac_Gia = @tenTG, Nam_Sinh = @ns WHere Ma_Tac_Gia = @maTG";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maTG", txt_MaTG.Text.Trim()); // KHÔNG CHO SỬA KEY
            cmd.Parameters.AddWithValue("@tenTG", txt_TenTG.Text.Trim());
            cmd.Parameters.AddWithValue("@ns", dt_NS.Value);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Cập nhật thông tin thành công!");
            else
                MessageBox.Show("Không có dữ liệu nào được cập nhật!");

            LoadData();

            ClearForm();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaTG.Text))
            {
                MessageBox.Show("Vui lòng chọn tác giả cần xóa!", "Thông báo");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM TAC_GIA WHERE Ma_Tac_Gia = @maTG";

                    using (SqlConnection conn = new SqlConnection("Data Source = ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False")) // <-- Tạo kết nối mới an toàn
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@maTG", txt_MaTG.Text);
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
                    txt_MaTG.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
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

        private void com_truong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_Truong.SelectedIndex == -1 || string.IsNullOrEmpty(com_Truong.Text))
                return;
            sql = "select distinct " + com_Truong.Text + " from TAC_GIA";
            da = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comGT.DataSource = dt1;
            comGT.DisplayMember = com_Truong.Text;
            comGT.ValueMember = com_Truong.Text;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (com_Truong.SelectedIndex == -1 || comGT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trường và giá trị cần lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string truong = com_Truong.Text;
            string giatri = comGT.Text;

            string sqlLoc;
            sqlLoc = "SELECT * FROM TAC_GIA WHERE " + truong + " = @GiaTri";
            SqlCommand cmd = new SqlCommand(sqlLoc, conn);
            DataTable dt1 = new DataTable();
            cmd.Parameters.AddWithValue("@GiaTri", giatri);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            dgv_TG.DataSource = dt1;
            da = new SqlDataAdapter(cmd);
            
            /*
            sql = "SELECT * FROM TAC_GIA " + "WHERE " + com_Truong.Text + " =N '" + comGT + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_TG.DataSource = dt;
            dgv_TG.Refresh();
            NapCT();
            */
             
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {           
           /* LoadData(); // Nạp lại toàn bộ dữ liệu gốc từ DB
            com_Truong.SelectedIndex = -1;
            comGT.DataSource = null;*/
            
            sql = "SELECT * FROM TAC_GIA ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_TG.DataSource = dt;
            dgv_TG.Refresh();
            NapCT();
             
        }
        /* Muốn bấm phím enter như phím tab, set keypreview = true ở properties của form
           sau đó vào event chọn keyPress*/
        private void frmTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }


    }
}
