using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmPP : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string str, sql;
        DataTable dtCTPP;
        public frmPP()
        {
            InitializeComponent();
        }
        private void frmPP_Load(object sender, EventArgs e)
        {
            dtpNgayPhat.Value = DateTime.Now;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            str = "Data Source = LAPTOP-W3DTHM; Initial Catalog = QLTV; Integrated Security = True; Encrypt = False";
            conn = new SqlConnection(str);
            conn.Open();

            LoadgrdDSPP();
            LoadmaPM();
            LoadThuThu();
            LoadVP();
            KhoiTaogrdCTPP();

            grdCTPP.CellValueChanged += grdCTPP_CellValueChanged;
            txtSoTien.Text = "0";

            grdDSPP.ClearSelection();
        }

        private void LoadgrdDSPP()
        {
            sql = "select * from PHIEU_PHAT";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdDSPP.DataSource = dt;

            //Đổi tên hiển thị header cho grdDSPP
            grdDSPP.Columns["Ma_Phieu_Phat"].HeaderText = "Mã phiếu phạt";
            grdDSPP.Columns["Ma_Phieu_Muon"].HeaderText = "Mã phiếu mượn";
            grdDSPP.Columns["Ma_Thu_Thu"].HeaderText = "Mã thủ thư";
            grdDSPP.Columns["Ngay_Phat"].HeaderText = "Ngày phạt";
            grdDSPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void LoadmaPM()
        {
            sql = "select Ma_Phieu_Muon from PHIEU_MUON";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection(); //Tạo bộ sưu tập chuỗi tự động hoàn thành dự theo từng kt nhập vào
            while (dr.Read())            
            {
                auto.Add(dr["Ma_Phieu_Muon"].ToString());
            }
            dr.Close();
            txtMaPM.AutoCompleteCustomSource = auto;
        }
        private void LoadThuThu()
        {
            sql = "select Ma_Thu_Thu from THU_THU";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboMaTT.DataSource = dt;
            cboMaTT.DisplayMember = "Ma_Thu_Thu"; //Hiển thị mã thủ thư vào combobox
            cboMaTT.ValueMember = "Ma_Thu_Thu";
            cboMaTT.SelectedIndex = -1; // không chọn mặc định
        }
        private void LoadVP()
        {
            sql = "select Ten_Vi_Pham, Ma_Vi_Pham from VI_PHAM";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboTenVP.DataSource = dt;
            cboTenVP.DisplayMember = "Ten_Vi_Pham";
            cboTenVP.ValueMember = "Ma_Vi_Pham";
            cboTenVP.SelectedIndex = -1; // không chọn mặc định
        }
        private void LoadTLtuPM()
        {
            if (string.IsNullOrWhiteSpace(txtMaPM.Text))
            {
                cboMaTL.DataSource = null;
                lblTenTL.Text = "";
                return;
            }
            sql = @"SELECT TL.Ma_Tai_Lieu 
                           FROM CT_PHIEU_MUON CT 
                           JOIN TAI_LIEU TL ON CT.Ma_Tai_Lieu = TL.Ma_Tai_Lieu
                           WHERE CT.Ma_Phieu_Muon = @maPM";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@maPM", txtMaPM.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtTL = new DataTable();
                da.Fill(dtTL);

                if (dtTL.Rows.Count > 0)
                {
                    cboMaTL.DataSource = dtTL;
                    cboMaTL.DisplayMember = "Ma_Tai_Lieu";
                    cboMaTL.ValueMember = "Ma_Tai_Lieu"; 
                    cboMaTL.SelectedIndex = -1;
                    lblTenTL.Text = "";
                }
                else
                {
                    cboMaTL.DataSource = null;
                }
            }
        }
        private void MoKhoaONhapLieu()
        {
            txtMaPM.Enabled = true;
            dtpNgayPhat.Enabled = true;
            cboMaTT.Enabled = true;
            txtSoTien.Enabled = true;
            txtMota.Enabled = true;
            cboTenVP.Enabled = true;
            cboMaTL.Enabled = true;
        }
        private void KhoiTaogrdCTPP()
        {
            dtCTPP = new DataTable();
            dtCTPP.Columns.Add("Ma_Phieu_Muon", typeof(string));
            dtCTPP.Columns.Add("Ma_Vi_Pham", typeof(string));
            dtCTPP.Columns.Add("Ma_Tai_Lieu", typeof(string));
            dtCTPP.Columns.Add("Ten_Vi_Pham", typeof(string));
            dtCTPP.Columns.Add("Nop_phat", typeof(decimal));
            dtCTPP.Columns.Add("Mo_Ta", typeof(string));

            grdCTPP.AutoGenerateColumns = true; //cho phép tự sinh cột
            grdCTPP.DataSource = dtCTPP;

            if (grdCTPP.Columns.Contains("Ma_Tai_Lieu"))
                grdCTPP.Columns["Ma_Tai_Lieu"].HeaderText = "Mã TL";
            if (grdCTPP.Columns.Contains("Ten_Vi_Pham"))
                grdCTPP.Columns["Ten_Vi_Pham"].HeaderText = "Tên vi phạm";
            if (grdCTPP.Columns.Contains("Nop_Phat"))
            {
                grdCTPP.Columns["Nop_Phat"].HeaderText = "Số tiền";
                grdCTPP.Columns["Nop_Phat"].DefaultCellStyle.Format = "N0";
            }    
            if (grdCTPP.Columns.Contains("Mo_Ta"))
                grdCTPP.Columns["Mo_Ta"].HeaderText = "Mô tả";

            grdCTPP.Refresh();

            // Ẩn cột ngay từ đầu
            if (grdCTPP.Columns.Contains("Ma_Phieu_Muon"))
                grdCTPP.Columns["Ma_Phieu_Muon"].Visible = false;

            if (grdCTPP.Columns.Contains("Ma_Vi_Pham"))
                grdCTPP.Columns["Ma_Vi_Pham"].Visible = false;

            // Chỉnh sửa kích thước từng cột
            grdCTPP.Columns["Ma_Tai_Lieu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCTPP.Columns["Ten_Vi_Pham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCTPP.Columns["Nop_Phat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grdCTPP.Columns["Mo_Ta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private string TaoMaPPTuDong()
        {
            sql = "SELECT TOP 1 Ma_Phieu_Phat FROM PHIEU_PHAT ORDER BY Ma_Phieu_Phat DESC";
            string lastMa = "";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                    lastMa = result.ToString();
            }

            int number = 1;
            if (!string.IsNullOrEmpty(lastMa) && lastMa.Length > 2)
                number = int.Parse(lastMa.Substring(2)) + 1;

            return "PP" + number.ToString("D3");
        }
     
        private void anbtn_othongtin()
        {
            btnSua.Enabled = true;
            btnLuu.Visible = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnCapnhat.Visible = false;
            btnXoa.Enabled = true;

            txtMaPM.Enabled = false;
            dtpNgayPhat.Enabled = false;
            cboMaTT.Enabled = false;
            txtSoTien.Enabled = false;
            txtMota.Enabled = false;
            cboTenVP.Enabled = false;
            cboMaTL.Enabled = false;

            if (grdCTPP.Columns.Contains("btngrdXoa"))
            {
                grdCTPP.Columns["btngrdXoa"].Visible = false;
            }
        }
        public void NapCT()
        {
            if (grdDSPP.CurrentRow == null || grdDSPP.Rows.Count == 0)
                return;

            int i = grdDSPP.CurrentRow.Index;
            if (i < 0 || i >= grdDSPP.Rows.Count)
                return;

            txtMaPM.Text = grdDSPP.Rows[i].Cells["Ma_Phieu_Muon"].Value.ToString();
            cboMaTT.SelectedValue = grdDSPP.Rows[i].Cells["Ma_Thu_Thu"].Value.ToString();
            dtpNgayPhat.Value = Convert.ToDateTime(grdDSPP.Rows[i].Cells["Ngay_Phat"].Value);
            string maPP = grdDSPP.Rows[i].Cells["Ma_Phieu_Phat"].Value.ToString();
            LoadThongTinCTPP(maPP); //Load thông tin vào grdCTPP
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            anbtn_othongtin();
        }

        private void ResetForm()
        {
            txtMaPM.Clear();
            cboMaTT.SelectedIndex = -1;
            dtpNgayPhat.Value = DateTime.Now;

            cboMaTL.SelectedIndex = -1;
            lblTenTL.Text = "";
            cboTenVP.SelectedIndex = -1;
            lblHTP.Text = "";
            txtSoTien.Clear();
            txtMota.Clear();

            dtCTPP.Clear();
            grdCTPP.DataSource = dtCTPP;

            MoKhoaONhapLieu();
            btnCapnhat.Visible = false;
            btnLuu.Visible = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            SumNopPhat();

            comTruong.SelectedIndex = -1;
            comGT.SelectedIndex = -1;
        }
        private void LoadThongTinCTPP(string maPP)
        {
            try
            {
                // Lấy thông tin phiếu phạt
                string sqlPP = "SELECT * FROM PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                SqlCommand cmdPP = new SqlCommand(sqlPP, conn);
                cmdPP.Parameters.AddWithValue("@MaPP", maPP);
                SqlDataAdapter daPP = new SqlDataAdapter(cmdPP);
                DataTable dtPP = new DataTable();
                daPP.Fill(dtPP);

                if (dtPP.Rows.Count > 0)
                {
                    txtMaPM.Text = dtPP.Rows[0]["Ma_Phieu_Muon"].ToString();
                    LoadTLtuPM();
                    cboMaTT.SelectedValue = dtPP.Rows[0]["Ma_Thu_Thu"].ToString();
                    dtpNgayPhat.Value = Convert.ToDateTime(dtPP.Rows[0]["Ngay_Phat"]);
                }

                // Lấy chi tiết phiếu phạt
                string sqlCT = @"SELECT ct.Ma_Tai_Lieu, ct.Ma_Vi_Pham, vp.Ten_Vi_Pham, ct.Nop_Phat, ct.Mo_Ta 
                                FROM CT_PHIEU_PHAT ct 
                                JOIN VI_PHAM vp ON ct.Ma_Vi_Pham = vp.Ma_Vi_Pham 
                                WHERE ct.Ma_Phieu_Phat = @MaPP";

                SqlCommand cmdCT = new SqlCommand(sqlCT, conn);
                cmdCT.Parameters.AddWithValue("@MaPP", maPP);
                SqlDataAdapter daCT = new SqlDataAdapter(cmdCT);

                dtCTPP.Clear();
                daCT.Fill(dtCTPP);
                if (!dtCTPP.Columns.Contains("Ma_Vi_Pham"))
                    dtCTPP.Columns.Add("Ma_Vi_Pham", typeof(string));

                grdCTPP.DataSource = dtCTPP;
                grdCTPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Đặt lại tiêu đề cột
                if (grdCTPP.Columns.Contains("Ma_Tai_Lieu"))
                    grdCTPP.Columns["Ma_Tai_Lieu"].HeaderText = "Mã TL";
                if (grdCTPP.Columns.Contains("Ten_Vi_Pham"))
                    grdCTPP.Columns["Ten_Vi_Pham"].HeaderText = "Tên vi phạm";
                if (grdCTPP.Columns.Contains("Nop_Phat"))
                {
                    grdCTPP.Columns["Nop_Phat"].HeaderText = "Số tiền";
                    grdCTPP.Columns["Nop_Phat"].DefaultCellStyle.Format = "N0";
                }
                if (grdCTPP.Columns.Contains("Mo_Ta"))
                    grdCTPP.Columns["Mo_Ta"].HeaderText = "Mô tả";

                // Ẩn các cột nội bộ
                if (grdCTPP.Columns.Contains("Ma_Vi_Pham"))
                    grdCTPP.Columns["Ma_Vi_Pham"].Visible = false;
                if (grdCTPP.Columns.Contains("Ma_Phieu_Muon"))
                    grdCTPP.Columns["Ma_Phieu_Muon"].Visible = false;

                SumNopPhat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin phiếu phạt: " + ex.Message);
            }

        }

        //Khi chọn Tên VP => hiển thị hình thức phạt tương ứng
        private void cboTenVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTenVP.SelectedIndex != -1)
            {
                sql = "SELECT Hinh_Thuc_Phat FROM VI_PHAM WHERE Ten_Vi_Pham = @TenVP";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tenVP", cboTenVP.Text);
                SqlDataReader dr = cmd.ExecuteReader(); //ExecuteReader trả về 1/N bản ghi
                if (dr.Read())
                {
                    lblHTP.Text = dr["Hinh_Thuc_Phat"].ToString();
                }
                dr.Close();
            }
            else
            {
                lblHTP.Text = "";
            }
        }
        private void cboMaTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Khi chọn Mã TL => hiển thị Tên TL tương ứng
            if (cboMaTL.SelectedIndex != -1)
            {
                sql = "SELECT Ten_TTTL FROM TTTL WHERE MaTTTL = (SELECT MaTTTL FROM TAI_LIEU WHERE Ma_Tai_Lieu = @MaTL)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTL", cboMaTL.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        lblTenTL.Text = dr["Ten_TTTL"].ToString();
                    }
                    dr.Close();
            }
            else
            {
                lblTenTL.Text = "";
            }
                 
        }

        private void txtMaPM_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPM.Text))
                LoadTLtuPM();
            else
            {
                cboMaTL.DataSource = null;
                lblTenTL.Text = "";
            }
        }

        private void grdDSPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDSPP.CurrentRow != null && grdDSPP.CurrentRow.Index >= 0)
            {
                ResetForm();
                NapCT();
            }
        }
        private void grdCTPP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCTPP.Columns[e.ColumnIndex].Name == "btngrdXoa" && e.RowIndex >= 0)
            
                grdCTPP.Rows.RemoveAt(e.RowIndex);
                SumNopPhat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPM.Text) || cboMaTL.SelectedIndex == -1 || cboTenVP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dữ liệu vào bảng CTPP tạm
            DataRow newRow = dtCTPP.NewRow();
            newRow["Ma_Phieu_Muon"] = txtMaPM.Text.Trim();
            newRow["Ma_Vi_Pham"] = cboTenVP.SelectedValue.ToString();
            newRow["Ma_Tai_Lieu"] = cboMaTL.SelectedValue.ToString();
            newRow["Ten_Vi_Pham"] = cboTenVP.Text;
            newRow["Nop_phat"] = decimal.Parse(txtSoTien.Text);
            newRow["Mo_Ta"] = txtMota.Text.Trim();
            dtCTPP.Rows.Add(newRow);

            //Cập nhật lại DataGridView
            //grdCTPP.DataSource = dtCTPP;
            grdCTPP.Refresh();

            //Ẩn cột Ma_Phieu_Muon, Ma_Vi_Pham
            if (grdCTPP.Columns.Contains("Ma_Phieu_Muon"))
                grdCTPP.Columns["Ma_Phieu_Muon"].Visible = false;
            if (grdCTPP.Columns.Contains("Ma_Vi_Pham"))
                grdCTPP.Columns["Ma_Vi_Pham"].Visible = false;

            //Xóa các trường nhập liệu sau khi thêm
            cboMaTL.SelectedIndex = -1;
            cboTenVP.SelectedIndex = -1;
            txtSoTien.Clear();
            txtMota.Clear();
            lblTenTL.Text = "";
            lblHTP.Text = "";

            SumNopPhat();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPM.Text) || cboMaTT.SelectedIndex == -1 || dtCTPP.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string maPP = TaoMaPPTuDong();
                // Thêm phiếu phạt vào bảng PHIEU_PHAT
                string sqlInsertPP = "INSERT INTO PHIEU_PHAT (Ma_Phieu_Phat, Ngay_Phat, Ma_Phieu_Muon, Ma_Thu_Thu) " +
                                     "VALUES (@MaPP, @NgayPhat, @MaPM, @MaTT)";
                using (SqlCommand cmd = new SqlCommand(sqlInsertPP, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPP", maPP);
                    cmd.Parameters.AddWithValue("@NgayPhat", dtpNgayPhat.Value);
                    cmd.Parameters.AddWithValue("@MaPM", txtMaPM.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaTT", cboMaTT.Text);
                    cmd.ExecuteNonQuery();
                }
                // Thêm chi tiết phiếu phạt từ dtCTPP vào bảng CT_PHIEU_PHAT
                foreach (DataRow row in dtCTPP.Rows)
                {
                    string sqlInsertCT = @"INSERT INTO CT_PHIEU_PHAT (Ma_Phieu_Phat, Ma_Tai_Lieu, Ma_Vi_Pham, Nop_Phat, Mo_Ta)
                                   VALUES (@MaPP, @MaTL, @MaVP, @NopPhat, @MoTa)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsertCT, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPP", maPP);
                        cmd.Parameters.AddWithValue("@MaTL", row["Ma_Tai_Lieu"]);
                        cmd.Parameters.AddWithValue("@MaVP", row["Ma_Vi_Pham"]);
                        cmd.Parameters.AddWithValue("@NopPhat", row["Nop_Phat"]);
                        cmd.Parameters.AddWithValue("@MoTa", row["Mo_Ta"]);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadgrdDSPP();
                // Xóa dữ liệu tạm trong dtCTPP sau khi lưu
                dtCTPP.Clear();
                grdCTPP.Refresh();
                txtMaPM.Clear();
                cboMaTT.SelectedIndex = -1;
                cboMaTL.SelectedIndex = -1;
                cboTenVP.SelectedIndex = -1;
                txtSoTien.Clear();
                txtMota.Clear();
                lblTenTL.Text = "";
                lblHTP.Text = "";

                MessageBox.Show("Lưu phiếu phạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu phạt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaONhapLieu();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Visible = false;
            btnCapnhat.Visible = true;
            btnCapnhat.Enabled = true;
            btnSua.Enabled = false;
            grdCTPP.Columns["btngrdXoa"].Visible = true;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if(grdDSPP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu phạt để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maPP = grdDSPP.CurrentRow.Cells["Ma_Phieu_Phat"].Value.ToString();
            try
            {
                SqlTransaction tran = conn.BeginTransaction();

                // Cập nhật thông tin phiếu phạt
                string sqlUpdatePP = @"UPDATE PHIEU_PHAT 
                               SET Ngay_Phat = @NgayPhat, Ma_Phieu_Muon = @MaPM, Ma_Thu_Thu = @MaTT
                               WHERE Ma_Phieu_Phat = @MaPP";
                using (SqlCommand cmd = new SqlCommand(sqlUpdatePP, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@NgayPhat", dtpNgayPhat.Value);
                    cmd.Parameters.AddWithValue("@MaPM", txtMaPM.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaTT", cboMaTT.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaPP", maPP);
                    cmd.ExecuteNonQuery();
                }

                // Xóa chi tiết cũ
                string sqlDelCT = "DELETE FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                using (SqlCommand cmd = new SqlCommand(sqlDelCT, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaPP", maPP);
                    cmd.ExecuteNonQuery();
                }

                // Thêm lại chi tiết mới từ dtCTPP
                foreach (DataRow row in dtCTPP.Select("", "", DataViewRowState.CurrentRows))
                {
                    string sqlInsertCT = @"INSERT INTO CT_PHIEU_PHAT (Ma_Phieu_Phat, Ma_Tai_Lieu, Ma_Vi_Pham, Nop_Phat, Mo_Ta)
                                   VALUES (@MaPP, @MaTL, @MaVP, @NopPhat, @MoTa)";
                    using (SqlCommand cmd = new SqlCommand(sqlInsertCT, conn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaPP", maPP);
                        cmd.Parameters.AddWithValue("@MaTL", row["Ma_Tai_Lieu"]);
                        cmd.Parameters.AddWithValue("@MaVP", row["Ma_Vi_Pham"]);
                        cmd.Parameters.AddWithValue("@NopPhat", row["Nop_Phat"]);
                        cmd.Parameters.AddWithValue("@MoTa", row["Mo_Ta"]);
                        cmd.ExecuteNonQuery();
                    }
            }
                tran.Commit();
                MessageBox.Show("Đã cập nhật phiếu phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadgrdDSPP();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPM.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu phạt cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Lấy mã phiếu phạt đang hiển thị từ dòng đang chọn trong grdDSPP
            string maPP = grdDSPP.CurrentRow.Cells["Ma_Phieu_Phat"].Value.ToString();
            // Hỏi xác nhận trước khi xóa
            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phiếu phạt {maPP} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm == DialogResult.No)
                return;

            try
            {
                // Bắt đầu giao dịch để xóa an toàn
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // Xóa chi tiết phiếu phạt trước (bảng CT_PHIEU_PHAT)
                    string sqlCT = "DELETE FROM CT_PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                    using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran))
                    {
                        cmdCT.Parameters.AddWithValue("@MaPP", maPP);
                        cmdCT.ExecuteNonQuery();
                    }

                    // Xóa phiếu phạt chính
                    string sqlPP = "DELETE FROM PHIEU_PHAT WHERE Ma_Phieu_Phat = @MaPP";
                    using (SqlCommand cmdPP = new SqlCommand(sqlPP, conn, tran))
                    {
                        cmdPP.Parameters.AddWithValue("@MaPP", maPP);
                        cmdPP.ExecuteNonQuery();
                    }

                    // Commit transaction
                    tran.Commit();

                    MessageBox.Show("Xóa phiếu phạt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadgrdDSPP();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi xóa phiếu phạt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối hoặc xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumNopPhat()
        {
            decimal Sum = 0;
            foreach (DataGridViewRow row in grdCTPP.Rows)
            {
                if(row.Cells["Nop_Phat"].Value != null && row.Cells["Nop_Phat"].Value != null)
                {
                    string val = row.Cells["Nop_Phat"].Value.ToString().Trim();
                    if (decimal.TryParse(val, out decimal giaTri))
                        Sum += giaTri;
                }
                else
                {
                    continue;
                }
            }
            lblSum.Text = Sum.ToString("N0") + " VND";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdDSPP.Rows.Count - 1;
            grdDSPP.CurrentCell = grdDSPP[0, i];
            NapCT();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDSPP.ClearSelection();
            grdDSPP.CurrentCell = grdDSPP[0, 0];
            NapCT();
        }
        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdDSPP.CurrentRow.Index;
            if (i > 0)
            {
                grdDSPP.CurrentCell = grdDSPP[0, i - 1];
                NapCT();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDSPP.CurrentRow.Index;
            if (i < grdDSPP.Rows.Count - 1) //nếu chx đến dòng cuối cùng thì nhảy đến dòng tiếp
            {
                grdDSPP.CurrentCell = grdDSPP[0, i + 1];
                NapCT();
            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comTruong.Text))
                return;
            sql = "select distinct " + comTruong.Text + " from PHIEU_PHAT";
            da = new SqlDataAdapter(sql, conn); //Khai báo đối tượng DataAdapter để lấy DL
            DataTable dt1 = new DataTable(); //tạo DataTable
            da.Fill(dt1);

            comGT.DataSource = dt1; //Gán nguồn DL cho combogiaTri
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(comTruong.Text) || string.IsNullOrWhiteSpace(comGT.Text))
            {
                MessageBox.Show("Vui lòng chọn trường và giá trị để lọc!");
                return;
            }
            sql = "SElECT * FROM PHIEU_PHAT WHERE "+ comTruong.Text +" = N'" +comGT.Text+"' ";
            try
            {
                SqlDataAdapter daFilter = new SqlDataAdapter(sql, conn);
                DataTable dtFilter = new DataTable();
                daFilter.Fill(dtFilter);
                grdDSPP.DataSource = dtFilter;
                if (dtFilter.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu phạt phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();

            LoadgrdDSPP();
            grdDSPP.ClearSelection();
            grdDSPP.Refresh();
        }

        private void grdCTPP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdCTPP.Columns[e.ColumnIndex].Name == "Nop_Phat")
                SumNopPhat();
        }
    }
}
