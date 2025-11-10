using DevExpress.XtraReports.UI;
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
    public partial class frmDMDG : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        DataView dv;    
        string str, sql;

        public frmDMDG()
        {
            InitializeComponent();
        }

        private void NapCT()
        {            
            int index = dgv_DMDG.CurrentRow.Index;
            txt_ST.Text = dt.Rows[index]["So_The_Doc_Gia"].ToString();
            txt_Hoten.Text = dt.Rows[index]["Ho_Ten"].ToString();
            txt_Malop.Text = dt.Rows[index]["Ma_Lop"].ToString();
            txt_Makhoa.Text = dt.Rows[index]["Ma_Khoa_Vien"].ToString();
            txt_Nghenghiep.Text = dt.Rows[index]["Chuc_Vu"].ToString();

            if (DateTime.TryParse(dt.Rows[index]["Ngay_Cap_The"].ToString(), out DateTime ngayCap))
                dt_Ngaycap.Value = ngayCap;

            dgv_DMDG.ClearSelection();
            dgv_DMDG.Rows[index].Selected = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            sql = "select * from DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgv_DMDG.DataSource = dt;
        }

        private void frmDMDGcs_Load(object sender, EventArgs e)
        {
            str = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
            conn.Open();    
            loadData();
            //tạo dataview từ dt
            dv = new DataView(dt);
            dgv_DMDG.DataSource = dv;

            // đổi tên cột trong dgv
            dgv_DMDG.Columns["So_The_Doc_Gia"].HeaderText = "Số thẻ độc giả";
            dgv_DMDG.Columns["Ho_Ten"].HeaderText = "Họ tên";
            dgv_DMDG.Columns["Ma_Lop"].HeaderText = "Mã lớp";
            dgv_DMDG.Columns["Ma_Khoa_Vien"].HeaderText = "Mã khoa viện";
            dgv_DMDG.Columns["Ngay_Cap_The"].HeaderText = "Ngày cấp thẻ";
            dgv_DMDG.Columns["Chuc_Vu"].HeaderText = "Nghề nghiệp";
            dgv_DMDG.Columns["Ngay_Cap_The"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ST.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa!", "Thông báo");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM DOC_GIA WHERE So_The_Doc_Gia = @SoThe";

                    using (SqlConnection conn = new SqlConnection("Data Source = ACER\\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True;Encrypt=False")) // <-- Tạo kết nối mới an toàn
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@SoThe", txt_ST.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Đã xóa thành công!");

                    // Load lại DGV
                    loadData();

                    ClearForm();
                    btn_Them.Enabled = true;
                    btn_Sua.Enabled = false;
                    btn_Xoa.Enabled = false;
                    txt_ST.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }                
            }
        }
 

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {       
            string soThe = txt_ST.Text.Trim();
            string hoTen = txt_Hoten.Text.Trim();
            string maLop = txt_Malop.Text.ToString();
            string maKhoaVien = txt_Makhoa.Text.ToString();
            string ngheNghiep = txt_Nghenghiep.Text.Trim();
            DateTime ngayCap = dt_Ngaycap.Value;
            // mở DB        
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            { 
            string query = "INSERT INTO DOC_GIA (So_The_Doc_Gia, Ho_Ten, Ma_Lop, Ma_Khoa_Vien, Chuc_Vu, Ngay_Cap_The) " +
                           "VALUES (@SoThe, @HoTen, @MaLop, @MaKhoaVien, @NgheNghiep, @NgayCap)";         
                           
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Transaction = tran; // ⚠ Gán transaction vào command          
            
            
                cmd.Parameters.AddWithValue("@SoThe", txt_ST.Text);
                cmd.Parameters.AddWithValue("@HoTen", txt_Hoten.Text);
                cmd.Parameters.AddWithValue("@MaLop", txt_Malop.Text);
                cmd.Parameters.AddWithValue("@MaKhoaVien", txt_Makhoa.Text);
                cmd.Parameters.AddWithValue("@NgheNghiep", txt_Nghenghiep.Text);
                cmd.Parameters.AddWithValue("@NgayCap", dt_Ngaycap.Value);
                // ⚠ THIẾU DÒNG NÀY NÊN KHÔNG INSERT VÀO DB
                int rows = cmd.ExecuteNonQuery();

                tran.Commit();
                MessageBox.Show("Thêm độc giả thành công!");

                loadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
     
        

        private void txt_ST_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Malop_TextChanged(object sender, EventArgs e)
        {

        }

        private void grb_DMDG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                       
         
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

            string query = "UPDATE DOC_GIA SET Ho_Ten = @HoTen, Ma_Lop = @MaLop, Ma_Khoa_Vien = @MaKhoaVien, " +
                           "Chuc_Vu = @NgheNghiep, Ngay_Cap_The = @NgayCap WHERE So_The_Doc_Gia = @SoThe";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@SoThe", txt_ST.Text.Trim()); // KHÔNG CHO SỬA KEY
            cmd.Parameters.AddWithValue("@HoTen", txt_Hoten.Text.Trim());
            cmd.Parameters.AddWithValue("@MaLop", txt_Malop.Text.Trim());
            cmd.Parameters.AddWithValue("@MaKhoaVien", txt_Makhoa.Text.Trim());
            cmd.Parameters.AddWithValue("@NgheNghiep", txt_Nghenghiep.Text.Trim());
            cmd.Parameters.AddWithValue("@NgayCap", dt_Ngaycap.Value);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Cập nhật thông tin thành công!");
            else
                MessageBox.Show("Không có dữ liệu nào được cập nhật!");

            // Load lại dữ liệu dgv
            loadData();

            ClearForm();
        }

        private void dgv_DMDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh lỗi khi click header
            {
                DataGridViewRow row = dgv_DMDG.Rows[e.RowIndex];

                txt_ST.Text = row.Cells["So_The_Doc_Gia"].Value.ToString();
                txt_Hoten.Text = row.Cells["Ho_Ten"].Value.ToString();
                txt_Malop.Text = row.Cells["Ma_Lop"].Value.ToString();
                txt_Makhoa.Text = row.Cells["Ma_Khoa_Vien"].Value.ToString();
                txt_Nghenghiep.Text = row.Cells["Chuc_Vu"].Value.ToString();

                // Chuyển đổi ngày
                dt_Ngaycap.Value = Convert.ToDateTime(row.Cells["Ngay_Cap_The"].Value);

                txt_ST.Enabled = false; // Không cho đổi mã thẻ khi sửa
                btn_Them.Enabled = false;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;

               
            }
        }

        private void dgv_DMDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void com_truong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_truong.SelectedIndex == -1 || string.IsNullOrEmpty(com_truong.Text))
                return;
            sql = "select distinct " + com_truong.Text + " from DOC_GIA ";
            da = new SqlDataAdapter(sql, conn);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comGT.DataSource = dt1;
            comGT.DisplayMember = com_truong.Text;
            comGT.ValueMember = com_truong.Text;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if (com_truong.SelectedIndex == -1 || comGT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trường và giá trị cần lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string truong = com_truong.Text;
            string giatri = comGT.Text;

            string sqlLoc;
            sqlLoc = "SELECT * FROM DOC_GIA WHERE " + truong + " = @GiaTri";
            SqlCommand cmd = new SqlCommand(sqlLoc, conn);
            DataTable dt1 = new DataTable();
            cmd.Parameters.AddWithValue("@GiaTri", giatri);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            dgv_DMDG.DataSource = dt1;
            da = new SqlDataAdapter(cmd);
           

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            loadData();     // Nạp lại toàn bộ dữ liệu gốc từ DB
            com_truong.SelectedIndex = -1;
            comGT.DataSource = null;
        }

        
        private void btn_first_Click(object sender, EventArgs e)
        {
            dgv_DMDG.ClearSelection();
            dgv_DMDG.CurrentCell = dgv_DMDG[0, 0];
            NapCT();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            int i = dgv_DMDG.CurrentRow.Index;
            if (i > 0)
            {
                dgv_DMDG.CurrentCell = dgv_DMDG[0, i - 1];
                NapCT();
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int i = dgv_DMDG.CurrentRow.Index;
            if (i < dgv_DMDG.Rows.Count - 1)
            {
                dgv_DMDG.CurrentCell = dgv_DMDG[0, i + 1];
                NapCT();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int i = dgv_DMDG.Rows.Count - 1;
            dgv_DMDG.CurrentCell = dgv_DMDG[0, i];
            NapCT();
        }

        private void ClearForm()
        {
            txt_ST.Clear();
            txt_Hoten.Clear();
            txt_Malop.Clear();
            txt_Makhoa.Clear();
            txt_Nghenghiep.Clear();
            dt_Ngaycap.Value = DateTime.Now;

            txt_ST.Enabled = true; // Cho phép nhập lại Số thẻ (phòng TH sửa khóa ô này)
            btn_Them.Enabled = true;
            btn_Sua.Enabled = false; // Khóa nút Sửa, tránh nhầm
            btn_Xoa.Enabled = false; // Khóa nút Xóa, tránh nhầm
            txt_ST.Focus(); // Focus lại vào ô đầu tiên
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            /*rptDMDG rpt = new rptDMDG();
            string sql = "Select * from DOC_GIA where " + com_truong.Text + " = N '" + comGT.Text + "' " ;
            da1 = new SqlDataAdapter(sql, conn);
            DataTable rdt = new DataTable();
            da1.Fill(rdt);
            rpt.rptNgayin.Text = String.Format("NEU, Ngày {0} tháng {1} năm {2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            rpt.DataSource = rdt;
            rpt.ShowPreview();*/

            string sql = "SELECT * FROM DOC_GIA WHERE " + com_truong.Text + " = @Value";

            // 2. Dùng lại kết nối conn đã khai báo ở trên form
            SqlDataAdapter da1 = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@Value", comGT.Text);

            // 3. Đổ dữ liệu vào DataTable
            DataTable rdt = new DataTable();
            da.Fill(rdt);

            // 4. Tạo report và truyền dữ liệu vào
            rptDMDG rpt = new rptDMDG();
            rpt.rptNgayin.Text = string.Format("NEU, ngày {0} tháng {1} năm {2}",
                DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            rpt.xr_groupby.Text = string.Format("Điều kiện lọc {0}: {1}", com_truong.Text, comGT.Text);

            rpt.DataSource = rdt;
            rpt.ShowPreview();
        }

        private void frmDMDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

    }
}

