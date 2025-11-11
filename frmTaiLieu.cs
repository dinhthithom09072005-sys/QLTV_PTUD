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
    public partial class frmTaiLieu : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string str, sql;
        DataTable dtCuon;
        public frmTaiLieu()
        {
            InitializeComponent();
        }
        private void frmTaiLieu_Load(object sender, EventArgs e)
        {
            str = "Data Source = LAPTOP-W3DTHM; Initial Catalog = QLTV; Integrated Security = True; Encrypt = False";
            conn = new SqlConnection(str);
            conn.Open();

            LoadgrdListTG();
            LoadcboTheLoai();
            LoadcboNXB();
            LoadcboCD();
            LoadgrdDSdTL();

            //Tạo bảng nhớ tạm trong ListCuon
            dtCuon = new DataTable();
            dtCuon.Columns.Add("Ma_Tai_Lieu", typeof(string));
            dtCuon.Columns.Add("MaTTTL", typeof(string));
            dtCuon.Columns.Add("Tinh_Trang", typeof(string));
            dtCuon.Columns.Add("Lib_Only", typeof(int));
            grdListCuon.DataSource = dtCuon;
            grdListCuon.AutoGenerateColumns = false; //ko cho tự tạo cột, nếu ko có lệnh này sẽ bị lặp lại cột

            grdDSdTL.ClearSelection();
            ClearInputFields();
        }

        private void LoadgrdListTG()
        {
            sql = "SELECT * FROM TAC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdListTG.DataSource = dt;
        }
        private void LoadcboTheLoai()
        {
            sql = "SELECT * FROM THE_LOAI";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboTheLoai.DataSource = dt;
            cboTheLoai.DisplayMember = "Ten_TL";
            cboTheLoai.ValueMember = "Ma_TL";
            cboTheLoai.SelectedIndex = -1;
        }
        private void LoadcboNXB()
        {
            sql = "SELECT * FROM NXB";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboNXB.DataSource = dt;
            cboNXB.DisplayMember = "Ten_NXB";
            cboNXB.ValueMember = "Ma_NXB";
            cboNXB.SelectedIndex = -1;
        }
        private void LoadcboCD()
        {
            sql = "SELECT * FROM CHU_DE";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboCD.DataSource = dt;
            cboCD.DisplayMember = "Ten_Chu_De";
            cboCD.ValueMember = "Ma_Chu_De";
            cboCD.SelectedIndex = -1;
        }
        private void LoadgrdDSdTL()
        {
            sql = "SELECT * FROM TTTL";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdDSdTL.DataSource = dt;
            grdDSdTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void ClearInputFields()
        {
            txtMaTTTL.Clear();
            txtTenTTTL.Clear();
            cboTheLoai.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
            cboCD.SelectedIndex = -1;
            txtGiabia.Clear();
            txtNamXB.Clear();
            if (dtCuon != null)
            {
                dtCuon.Clear();
            }
        }
        private void MoKhoaONhapLieu()
        {
            txtMaTTTL.Enabled = true;
            txtTenTTTL.Enabled = true;
            txtGiabia.Enabled = true;
            txtNamXB.Enabled = true;
            cboTheLoai.Enabled = true;
            cboNXB.Enabled = true;
            cboCD.Enabled = true;
            txtMaCuon.Enabled = true;
            txtTinhTrang.Enabled = true;
            rabtnTrue.Enabled = true;
            rabtnFalse.Enabled = true;

            grdListTG.ReadOnly = false;
            grdListCuon.ReadOnly = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void KhoaONhapLieu()
        {
            btnSua.Enabled = true;
            btnLuu.Visible = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnCapnhat.Visible = false;
            btnXoa.Enabled = true;

            txtMaTTTL.Enabled = false;
            txtTenTTTL.Enabled = false;
            txtGiabia.Enabled = false;
            txtNamXB.Enabled = false;
            cboTheLoai.Enabled = false;
            cboNXB.Enabled = false;
            cboCD.Enabled = false;
            txtMaCuon.Enabled = false;
            txtTinhTrang.Enabled = false;
            rabtnTrue.Enabled = false;
            rabtnFalse.Enabled = false;

            grdListCuon.ReadOnly = true;
            if (grdListCuon.Columns.Contains("btngrdXoa"))
            {
                grdListCuon.Columns["btngrdXoa"].Visible = false;
            }
        }
        private void ResetForm()
        {
            txtMaTTTL.Clear();
            txtTenTTTL.Clear();
            txtGiabia.Clear();
            txtNamXB.Clear();

            cboTheLoai.SelectedIndex = -1;
            cboNXB.SelectedIndex = -1;
            cboCD.SelectedIndex = -1;
            txtMaCuon.Clear();
            txtTinhTrang.Clear();
            rabtnTrue.Checked = false;
            rabtnFalse.Checked = false;

            dtCuon.Clear();
            grdListCuon.DataSource = dtCuon;

            foreach (DataGridViewRow row in grdListTG.Rows)
            {
                if (row.Cells["Chon"] != null)
                    row.Cells["Chon"].Value = false;
            }

            MoKhoaONhapLieu();
            btnCapnhat.Enabled = false;
            btnCapnhat.Visible = false;
            btnLuu.Visible = true;
            btnLuu.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCuon = txtMaCuon.Text.Trim();
            string maTTTL = txtMaTTTL.Text.Trim();
            string tinhTrang = txtTinhTrang.Text.Trim();
            int libOnly = rabtnTrue.Checked ? 1 : 0;

            if (string.IsNullOrEmpty(maCuon) || string.IsNullOrEmpty(maTTTL))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            //Thêm dữ liệu vào DataTable tạm
            dtCuon.Rows.Add(maCuon, maTTTL, tinhTrang, libOnly);
            //Cập nhật lại DataGridView
            grdListCuon.DataSource = dtCuon;

            //Xóa trắng các TextBox sau khi thêm
            txtMaCuon.Clear();
            txtTinhTrang.Clear();
            rabtnTrue.Checked = false;
            rabtnFalse.Checked = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaONhapLieu();
            txtMaTTTL.Enabled = false; // mã đầu tài liệu luôn khóa

            btnLuu.Enabled = false;
            btnLuu.Visible = false;
            btnCapnhat.Visible = true;
            btnCapnhat.Enabled = true;
            btnXoa.Enabled = true;

            grdListCuon.Columns["btngrdXoa"].Visible = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTTTL.Text))
            {
                MessageBox.Show("Vui lòng chọn đầu tài liệu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maTTTL = txtMaTTTL.Text.Trim();
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa thông tin tài liệu {maTTTL} cùng thông tin tất cả các cuốn sách/tạp chí liên quan không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.No)
                return;
            SqlTransaction tran = null;
            try
            {
                // Bắt đầu giao dịch để xóa an toàn
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                tran = conn.BeginTransaction();

                // Xóa chi tiết TTTL_TG trước
                string sql1 = "DELETE FROM TTTL_TG WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd1 = new SqlCommand(sql1, conn, tran))
                {
                    cmd1.Parameters.AddWithValue("@MaTTTL", maTTTL);
                    cmd1.ExecuteNonQuery();
                }

                // Xóa các tài liệu thuộc đầu tài liệu này
                string sql2 = "DELETE FROM TAI_LIEU WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd2 = new SqlCommand(sql2, conn, tran))
                {
                    cmd2.Parameters.AddWithValue("@MaTTTL", maTTTL);
                    cmd2.ExecuteNonQuery();
                }

                // Xóa đầu tài liệu trong bảng TTTL
                string sql3 = "DELETE FROM TTTL WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd3 = new SqlCommand(sql3, conn, tran))
                {
                    cmd3.Parameters.AddWithValue("@MaTTTL", maTTTL);
                    cmd3.ExecuteNonQuery();
                }

                // Commit transaction
                tran.Commit();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadgrdDSdTL();

                ResetForm();
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                MessageBox.Show("Lỗi khi xóa tài liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (grdDSdTL.CurrentRow == null)
            {
                MessageBox.Show("Chọn một thông tin để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string MaTTTL = txtMaTTTL.Text.Trim();
            try
            {
                SqlTransaction tran = conn.BeginTransaction();

                // Cập nhật thông tin đầu tài liệu trong bảng TTTL
                string sqlUpdateTTTL = @"UPDATE TTTL 
                               SET Ten_TTTL = @Ten_TTTL,
                                     Ma_TL = @Ma_TL,
                                     Ma_NXB = @Ma_NXB,
                                     Ma_Chu_De = @Ma_Chu_De,
                                     Gia_Bia = @Gia_Bia,
                                     Nam_Xuat_Ban = @Nam_Xuat_Ban
                                 WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd = new SqlCommand(sqlUpdateTTTL, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaTTTL", txtMaTTTL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten_TTTL", txtTenTTTL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ma_TL", cboTheLoai.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ma_NXB", cboNXB.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ma_Chu_De", cboCD.SelectedValue);
                    cmd.Parameters.AddWithValue("@Gia_Bia", string.IsNullOrEmpty(txtGiabia.Text) ? 0 : decimal.Parse(txtGiabia.Text));
                    cmd.Parameters.AddWithValue("@Nam_Xuat_Ban", int.Parse(txtNamXB.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }

                // Xóa các cuốn tài liệu cũ
                string sqlDel = "DELETE FROM TAI_LIEU WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd = new SqlCommand(sqlDel, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaTTTL", MaTTTL);
                    cmd.ExecuteNonQuery();
                }

                // Thêm lại các cuốn tài liệu từ dtCuon hiện tại 
                foreach (DataRow row in dtCuon.Select("", "", DataViewRowState.CurrentRows))
                {
                    string sqlInsert = @"INSERT INTO TAI_LIEU (Ma_Tai_Lieu, MaTTTL, Tinh_Trang, Lib_Only)
                                 VALUES (@Ma_Tai_Lieu, @MaTTTL, @Tinh_Trang, @Lib_Only)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@Ma_Tai_Lieu", row["Ma_Tai_Lieu"]);
                        cmd.Parameters.AddWithValue("@MaTTTL", MaTTTL);
                        cmd.Parameters.AddWithValue("@Tinh_Trang", row["Tinh_Trang"]);
                        cmd.Parameters.AddWithValue("@Lib_Only", row["Lib_Only"]);
                        cmd.ExecuteNonQuery();
                    }
                }

                //Xóa các tác giả cũ
                string sqlDelTG = "DELETE FROM TTTL_TG WHERE MaTTTL = @MaTTTL";
                using (SqlCommand cmd = new SqlCommand(sqlDelTG, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaTTTL", MaTTTL);
                    cmd.ExecuteNonQuery();
                }
                // Thêm lại các tác giả được chọn
                foreach (DataGridViewRow row in grdListTG.Rows)
                {
                    bool isChecked = false;
                    if (row.Cells["Chon"].Value != null)
                        isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);
                    if (isChecked)
                    {
                        string maTG = row.Cells["Ma_Tac_Gia"].Value.ToString();
                        string sqlInsertTG = @"INSERT INTO TTTL_TG (MaTTTL, Ma_Tac_Gia) VALUES (@MaTTTL, @Ma_Tac_Gia)";
                        using (SqlCommand cmdTG = new SqlCommand(sqlInsertTG, conn, tran))
                        {
                            cmdTG.Parameters.AddWithValue("@MaTTTL", MaTTTL);
                            cmdTG.Parameters.AddWithValue("@Ma_Tac_Gia", maTG);
                            cmdTG.ExecuteNonQuery();
                        }
                    }
                }
                tran.Commit();
                MessageBox.Show("Đã cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadgrdDSdTL();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTTTL.Text) || string.IsNullOrEmpty(txtTenTTTL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin 'Mã đầu tài liệu và Tên tài liệu'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string sqlInsertTTTL = "INSERT INTO TTTL (MaTTTL, Ten_TTTL, Ma_TL, Ma_NXB, Ma_Chu_De, Gia_Bia, Nam_Xuat_Ban) " +
                                     "VALUES (@MaTTTL, @Ten_TTTL, @Ma_TL, @Ma_NXB, @Ma_Chu_De ,@Gia_Bia,@Nam_Xuat_Ban)";
                using (SqlCommand cmd = new SqlCommand(sqlInsertTTTL, conn))
                {
                    cmd.Parameters.AddWithValue("@MaTTTL", txtMaTTTL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten_TTTL", txtTenTTTL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ma_TL", cboTheLoai.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ma_NXB", cboNXB.SelectedValue);
                    cmd.Parameters.AddWithValue("@Ma_Chu_De", cboCD.SelectedValue);
                    cmd.Parameters.AddWithValue("@Gia_Bia", string.IsNullOrEmpty(txtGiabia.Text) ? 0 : decimal.Parse(txtGiabia.Text)); ;
                    cmd.Parameters.AddWithValue("@Nam_Xuat_Ban", int.Parse(txtNamXB.Text.Trim()));
                    cmd.ExecuteNonQuery();
                }
                
                // Thêm chi tiết cuốn sách từ dtCuon vào bảng TAI_LIEU
                foreach (DataRow row in dtCuon.Rows)
                {
                    string sqlInsertCuon = @"INSERT INTO TAI_LIEU (Ma_Tai_Lieu, MaTTTL, Tinh_Trang, Lib_Only)
                                   VALUES (@MaCuon, @MaTTTL, @Tinh_trang, @libOnly)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsertCuon, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCuon", row["Ma_Tai_Lieu"].ToString());
                        cmd.Parameters.AddWithValue("@MaTTTL", row["MaTTTL"].ToString());
                        cmd.Parameters.AddWithValue("@Tinh_trang", row["Tinh_Trang"].ToString());
                        cmd.Parameters.AddWithValue("@libOnly", Convert.ToBoolean(row["Lib_Only"]));
                        cmd.ExecuteNonQuery();
                    }
                }
                //Thêm tác giả cho đầu tài liệu (vào TTTL_TAC_GIA)
                foreach (DataGridViewRow row in grdListTG.Rows)
                {
                    bool isChecked = false;
                    if(row.Cells["Chon"].Value != null) 
                        isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);
                    if(isChecked)
                    {
                        string maTG = row.Cells["Ma_Tac_Gia"].Value.ToString();
                        string sqlInsertTG = @"INSERT INTO TTTL_TG (MaTTTL, Ma_Tac_Gia) VALUES (@MaTTTL, @Ma_Tac_Gia)";
                        using (SqlCommand cmdTG = new SqlCommand(sqlInsertTG, conn))
                        {
                            cmdTG.Parameters.AddWithValue("@MaTTTL", txtMaTTTL.Text.Trim());
                            cmdTG.Parameters.AddWithValue("@Ma_Tac_Gia", maTG);
                            cmdTG.ExecuteNonQuery();
                        }
                    }
                }
                LoadgrdDSdTL();
                // Xóa dữ liệu tạm trong dtCuon sau khi lưu
                ClearInputFields();
                txtSearch.Clear();
                comTruong.SelectedIndex = -1;
                comGT.SelectedIndex = -1;

                grdDSdTL.ClearSelection();//Bỏ chọn dòng

                ResetForm();
                MessageBox.Show("Lưu thông tin tài liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu phạt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdListCuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdListCuon.Columns[e.ColumnIndex].Name == "btngrdXoa" && e.RowIndex >= 0)
                grdListCuon.Rows.RemoveAt(e.RowIndex);
        }

        private void NapgrdListCuon(string maTTTL)
        {
            // Lấy thông tin các cuốn tài liệu có đầu sách là MaTTTL
            string sql = "SELECT Ma_Tai_Lieu, MaTTTL, Tinh_Trang, CAST(Lib_Only AS INT) AS Lib_Only FROM TAI_LIEU WHERE MaTTTL = @maTTTL";
            using (SqlConnection conn2 = new SqlConnection(conn.ConnectionString))
            {
                conn2.Open();
                SqlCommand cmd = new SqlCommand(sql, conn2);
                cmd.Parameters.AddWithValue("@maTTTL", maTTTL);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                dtCuon = dt;
                grdListCuon.DataSource = dtCuon;
            }
        }
        private void NapgrdListTG(string maTTTL)
        {
            string sqlCheck = "SELECT COUNT(*) FROM TTTL_TG WHERE MaTTTL = @maTTTL AND Ma_Tac_Gia = @maTG";
            using (SqlConnection conn2 = new SqlConnection(conn.ConnectionString))//tạo conn riêng, tránh conflict với conn chính
            {
                conn2.Open();
                int n = grdListTG.Rows.Count;
                for (int i = 0; i<n; i++)
                {  //i=0, lấy dòng đầu tiên trong TAC_GIA ghép với MaTTTL hiện tại => cmd chạy kiểm tra tất cả các bản ghi trong TTTL_TG (mỗi MaTTTL và mỗi MaTG chỉ tồn tại 0 or 1 bản ghi) => count chỉ nhận 0/1
                    DataGridViewRow row = grdListTG.Rows[i];
                    string maTG = row.Cells["Ma_Tac_Gia"].Value.ToString();
                    using (SqlCommand cmd = new SqlCommand(sqlCheck, conn2))
                    {
                        cmd.Parameters.AddWithValue("@maTTTL", maTTTL);
                        cmd.Parameters.AddWithValue("@maTG", maTG);
                        int count = (int)cmd.ExecuteScalar(); //scalar trả về 1 giá trị duy nhất từ ô SELECT COUNT(*)
                        if (count > 0)
                            row.Cells["Chon"].Value = true;
                        else
                            row.Cells["Chon"].Value = false;
                    }
                }    
            }
        }
        private void NapCT()
        {
            //Nạp chi tiết của dòng hiện tại trong grdDSdTL vào các ô nhập
            if (grdDSdTL.CurrentRow == null || grdDSdTL.Rows.Count == 0) //ktra có dòng nào đc chọn ko + bảng có dòng nào ko
                return;
            int r = grdDSdTL.CurrentRow.Index;
            if (r < 0 || r >= grdDSdTL.Rows.Count)
                return;
            txtMaTTTL.Text = grdDSdTL.Rows[r].Cells[0].Value.ToString();
            txtTenTTTL.Text = grdDSdTL.Rows[r].Cells[1].Value.ToString();
            cboTheLoai.SelectedValue = grdDSdTL.Rows[r].Cells[2].Value.ToString();
            cboNXB.SelectedValue = grdDSdTL.Rows[r].Cells[3].Value.ToString();
            cboCD.SelectedValue = grdDSdTL.Rows[r].Cells[4].Value.ToString();
            txtGiabia.Text = grdDSdTL.Rows[r].Cells[5].Value.ToString();
            txtNamXB.Text = grdDSdTL.Rows[r].Cells[6].Value.ToString();

            //Nạp chi tiết thông tin tác giả và cuốn tài liệu có cùng MaTTTL
            string maTTTL = grdDSdTL.CurrentRow.Cells[0].Value.ToString();
            NapgrdListTG(maTTTL);
            NapgrdListCuon(maTTTL);
            grdListTG.ReadOnly = true;
            grdListCuon.ReadOnly = true;
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDSdTL.ClearSelection();
            grdDSdTL.CurrentCell = grdDSdTL[0, 0];
            NapCT();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdDSdTL.Rows.Count - 1;
            grdDSdTL.CurrentCell = grdDSdTL[0, i];
            NapCT();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDSdTL.CurrentRow.Index;
            if (i < grdDSdTL.Rows.Count - 1) //nếu chx đến dòng cuối cùng thì nhảy đến dòng tiếp
            {
                grdDSdTL.CurrentCell = grdDSdTL[0, i + 1];
                NapCT();
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            int i = grdDSdTL.CurrentCell.RowIndex;
            if (i > 0)
            {
                grdDSdTL.CurrentCell = grdDSdTL[0, i - 1];
                NapCT();
            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comTruong.Text))
                return;
            sql = "select distinct " + comTruong.Text + " from TTTL";
            da = new SqlDataAdapter(sql, conn); //Khai báo đối tượng DataAdapter để lấy DL
            DataTable dt1 = new DataTable(); //tạo DataTable
            da.Fill(dt1);

            comGT.DataSource = dt1; //Gán nguồn DL cho combogiaTri
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comTruong.Text) || string.IsNullOrWhiteSpace(comGT.Text))
            {
                MessageBox.Show("Vui lòng chọn trường và giá trị lọc!");
                return;
            }
            sql = "SELECT * FROM TTTL WHERE " + comTruong.Text + "=N'" + comGT.Text + "'";
            try
            {
                SqlDataAdapter daFilter = new SqlDataAdapter(sql, conn);
                DataTable dtFilter = new DataTable(); //Tạo mới DataTable mỗi lần lọc
                daFilter.Fill(dtFilter);

                grdDSdTL.DataSource = dtFilter;
                if (dtFilter.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy đầu tài liệu nào phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Hãy nhập tên tài liệu cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM TTTL WHERE Ten_TTTL LIKE @keyword";

            try
            {
                SqlDataAdapter daSearch = new SqlDataAdapter(sql, conn);
                daSearch.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                grdDSdTL.DataSource = dtSearch;

                comTruong.SelectedIndex = -1;
                comGT.SelectedIndex = -1;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy đầu tài liệu nào phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void grdDSdTL_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grdDSdTL.CurrentRow != null && grdDSdTL.CurrentRow.Index >= 0)
            {
                NapCT();
                KhoaONhapLieu();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            comTruong.SelectedIndex = -1;
            comGT.SelectedIndex = -1;

            LoadgrdDSdTL();
            grdDSdTL.ClearSelection();//Bỏ chọn dòng

            ResetForm();

            btnLuu.Visible = true;
            btnCapnhat.Visible = false;
        }
    }
}
