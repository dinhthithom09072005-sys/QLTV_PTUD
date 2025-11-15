using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmMuonTra : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        DataTable dtDSTL = new DataTable();
        string str, sql;
        string maPM_DangChon = ""; // Biến toàn cục để lưu mã phiếu mượn đang chọn
        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            dateNgayMuon.Value = DateTime.Today; //Hiển thị ngày hiện tại, khi chưa chọn ngày khác
            dateNgayMuon.ValueChanged += DateNgayMuon_ValueChanged; 
            dateNgayThucTra.CustomFormat = " ";
            dateHanTra.Enabled = false;
            btnFix.Enabled = false;
            btnXoa.Enabled = false;

            str = "Data Source = LAPTOP-W3DTHM; Initial Catalog = QLTV; Integrated Security = True; Encrypt = False";
            conn = new SqlConnection(str);
            conn.Open();

            sql = "select * from PHIEU_MUON";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdDSPM.DataSource = dt;

            LoadDocGia();
            LoadThuThu();
            LoadKieuMuon();
            LoadMaTL();
            SetupgrdDSTLmuon();
            LoadgrdDSPM();
        }

        private void DateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            if (cboKieuMuon.SelectedValue != null)
            {
                string kieuMuon = cboKieuMuon.SelectedValue.ToString();
                if (kieuMuon == "MV")
                    dateHanTra.Value = dateNgayMuon.Value.AddDays(15);
                else if (kieuMuon == "TC")
                    dateHanTra.Value = dateNgayMuon.Value; // cùng ngày
            }
        }
        private void LoadDocGia()
        {
            sql = "select * from DOC_GIA";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                auto.Add(row["So_The_Doc_Gia"].ToString());
            }
            txtSoTheDG.AutoCompleteCustomSource = auto;
        }
        private void LoadThuThu()
        {
            sql = "select * from THU_THU";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboTenTT.DataSource = dt;
            cboTenTT.DisplayMember = "Ten_Thu_Thu";
            cboTenTT.ValueMember = "Ma_Thu_Thu";
            cboTenTT.SelectedIndex = -1;
        }
        private void LoadKieuMuon()
        {
            sql = "select * from KIEU_MUON";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            cboKieuMuon.DataSource = dt;
            cboKieuMuon.DisplayMember = "Ten_Kieu_Muon"; //Hiển thị kiểu mượn vào combobox
            cboKieuMuon.ValueMember = "Ma_Kieu_Muon";
            cboKieuMuon.SelectedIndex = -1; // không chọn mặc định
        }
        private void LoadMaTL()
        {
            sql = "select * from TAI_LIEU";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                auto.Add(row["Ma_Tai_Lieu"].ToString());
            }
            txtMaTL.AutoCompleteCustomSource = auto;
        }
        private void LoadgrdDSPM()
        {
        sql = "select * from PHIEU_MUON";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdDSPM.DataSource = dt;
            grdDSPM.Columns["Ma_Phieu_Muon"].HeaderText = "Mã phiếu mượn";
            grdDSPM.Columns["So_The_Doc_Gia"].HeaderText = "Số thẻ ĐG";
            grdDSPM.Columns["Ma_Kieu_Muon"].HeaderText = "Kiểu mượn";
            grdDSPM.Columns["Ngay_Muon"].HeaderText = "Ngày mượn";
            grdDSPM.Columns["Han_Tra"].HeaderText = "Hạn trả";
            grdDSPM.Columns["Ngay_Thuc_Tra"].HeaderText = "Ngày thực trả";
            grdDSPM.Columns["Ma_Thu_Thu"].HeaderText = "Mã thủ thư";
            grdDSPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

       
        private void ResetForm()
        {
            txtSoTheDG.Clear();
            cboTenTT.SelectedIndex = -1;
            cboKieuMuon.SelectedIndex = -1;

            dateNgayMuon.Value = DateTime.Now;
            dateHanTra.Value = DateTime.Today;
            dateNgayThucTra.CustomFormat = " ";
            txtMaTL.Clear();
            lblTenTL.Text = "";
            txtMota.Clear();

            dtDSTL.Clear();
            grdDSTLmuon.DataSource = dtDSTL;

            maPM_DangChon = "";
            btnThem.Enabled = true;
            btnFix.Enabled = false;
            btnXoa.Enabled = false;
            btnsave.Text = "Lưu";
            btnsave.Enabled = true;

            MoKhoaONhapLieu();
        }
        private void dateNgayThucTra_ValueChanged(object sender, EventArgs e)
        {
            dateNgayThucTra.CustomFormat = "dd/MM/yyyy";
        }
        private void SetupgrdDSTLmuon()
        {
            if (!dtDSTL.Columns.Contains("Ma_Tai_Lieu"))
                dtDSTL.Columns.Add("Ma_Tai_Lieu", typeof(string));

            if (!dtDSTL.Columns.Contains("Ten_TTTL"))
                dtDSTL.Columns.Add("Ten_TTTL", typeof(string));

            if (!dtDSTL.Columns.Contains("Mo_Ta"))
                dtDSTL.Columns.Add("Mo_Ta", typeof(string));

            grdDSTLmuon.DataSource = dtDSTL;

            grdDSTLmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void grdDSTLmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDSTLmuon.Columns[e.ColumnIndex].Name == "btngrdXoa" && e.RowIndex >= 0)
                grdDSTLmuon.Rows.RemoveAt(e.RowIndex);
        }
        private string TaoMaPMTuDong()
        {
            sql = "SELECT TOP 1 Ma_Phieu_Muon FROM PHIEU_MUON ORDER BY Ma_Phieu_Muon DESC";
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

            return "PM" + number.ToString("D2");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPM_DangChon))
                UpdatePM();// Đang ở chế độ sửa (vì đang có mã phiếu mượn được chọn)
            else
                LuuPMmoi();
        }
        private void LuuPMmoi()
        {
            if (string.IsNullOrWhiteSpace(txtSoTheDG.Text) ||
                cboTenTT.SelectedIndex == -1 ||
                cboKieuMuon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu mượn");
                return;
            }
            try
            {
                string maPM = TaoMaPMTuDong();
                //Lưu DL vào phiếu mượn
                string sqlInsertPM = @"INSERT INTO PHIEU_MUON (Ma_Phieu_Muon, So_The_Doc_Gia, Ma_Thu_Thu, Ma_Kieu_Muon, Ngay_Muon, Ngay_Thuc_Tra) VALUES (@MaPM, @SoTheDG, @MaTT, @MaKieuMuon, @NgayMuon, @NgayThucTra)";
                using (SqlCommand cmd = new SqlCommand(sqlInsertPM, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPM", maPM);
                    cmd.Parameters.AddWithValue("@SoTheDG", txtSoTheDG.Text);
                    cmd.Parameters.AddWithValue("@MaTT", cboTenTT.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaKieuMuon", cboKieuMuon.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayMuon", dateNgayMuon.Value);
                    if (dateNgayThucTra.CustomFormat == " ")
                        cmd.Parameters.AddWithValue("@NgayThucTra", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@NgayThucTra", dateNgayThucTra.Value);
                    cmd.ExecuteNonQuery();
                }

                //Lưu vào CT_PHIEU_MUON
                foreach (DataRow row in dtDSTL.Rows)
                {
                    string sqlInsertCT = @"INSERT INTO CT_PHIEU_MUON(Ma_Phieu_Muon, Ma_Tai_Lieu, Mo_Ta) VALUES(@MaPM, @MaTL, @MoTa)";
                    using (SqlCommand cmdCT = new SqlCommand(sqlInsertCT, conn))
                    {
                        cmdCT.Parameters.AddWithValue("MaPM", maPM);
                        cmdCT.Parameters.AddWithValue("@MaTL", row["Ma_Tai_Lieu"].ToString());
                        cmdCT.Parameters.AddWithValue("@MoTa", row["Mo_Ta"].ToString());
                        cmdCT.ExecuteNonQuery();
                    }         
                }
                MessageBox.Show("Tạo phiếu mượn thành công!");

                //Xóa DL dtDSTL sau khi tạo PM thành công
                dtDSTL.Clear();
                txtSoTheDG.Clear();
                cboTenTT.SelectedIndex = -1;
                cboKieuMuon.SelectedIndex = -1;
                dateNgayMuon.Value = DateTime.Now;
                dateHanTra.Value = DateTime.Now;
                dateNgayThucTra.CustomFormat = " ";
                txtMaTL.Clear();
                txtMota.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu mượn:" +ex.Message);
            }
            LoadgrdDSPM();
        }
        private void UpdatePM()
        {
            if(grdDSPM.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn để cập nhật");
                return;
            }
            string maPM = grdDSPM.CurrentRow.Cells["Ma_Phieu_Muon"].Value.ToString();
            try
            {
                SqlTransaction tran = conn.BeginTransaction();

                // Cập nhật PHIEU_MUON
                string sqlUpdatePM = @"UPDATE PHIEU_MUON
                                   SET So_The_Doc_Gia = @SoTheDG,
                                       Ma_Thu_Thu = @MaTT,
                                       Ma_Kieu_Muon = @MaKieuMuon,
                                       Ngay_Muon = @NgayMuon,
                                       Ngay_Thuc_Tra = @NgayThucTra
                                   WHERE Ma_Phieu_Muon = @MaPM";
                SqlCommand cmd = new SqlCommand(sqlUpdatePM, conn, tran);
                cmd.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                cmd.Parameters.AddWithValue("@SoTheDG", txtSoTheDG.Text);
                cmd.Parameters.AddWithValue("@MaTT", cboTenTT.SelectedValue);
                cmd.Parameters.AddWithValue("@MaKieuMuon", cboKieuMuon.SelectedValue);
                cmd.Parameters.AddWithValue("@NgayMuon", dateNgayMuon.Value);
                if (dateNgayThucTra.CustomFormat == " ")
                    cmd.Parameters.AddWithValue("@NgayThucTra", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@NgayThucTra", dateNgayThucTra.Value);
                cmd.ExecuteNonQuery();

                // Xóa CT cũ để ghi lại
                string sqlDelCT = "DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM";
                using (SqlCommand cmdDel = new SqlCommand(sqlDelCT, conn, tran))
                {
                    cmdDel.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                    cmdDel.ExecuteNonQuery();
                }

                //Thêm lại CT mới từ dtDSTL
                foreach (DataRow row in dtDSTL.Rows)
                {
                    string sqlInsertCT = @"INSERT INTO CT_PHIEU_MUON(Ma_Phieu_Muon, Ma_Tai_Lieu, Mo_Ta) VALUES(@MaPM, @MaTL, @MoTa)";
                    using (SqlCommand cmdCT = new SqlCommand(sqlInsertCT, conn, tran))
                    {
                        cmdCT.Parameters.AddWithValue("MaPM", maPM_DangChon);
                        cmdCT.Parameters.AddWithValue("@MaTL", row["Ma_Tai_lieu"].ToString());
                        cmdCT.Parameters.AddWithValue("@MoTa", row["Mo_Ta"].ToString());
                        cmdCT.ExecuteNonQuery();
                    }
                }
                
                tran.Commit();
                MessageBox.Show("Cập nhật phiếu mượn thành công!");
                LoadgrdDSPM();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " +ex.Message);
            }
            ResetForm();
        }

        private void txtMaTL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text))
            {
                lblTenTL.Text = "";
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT Ten_TTTL FROM TTTL WHERE MaTTTL = (SELECT MaTTTL FROM TAI_LIEU WHERE Ma_Tai_Lieu = @MaTL)", conn);
            cmd.Parameters.AddWithValue("@MaTL", txtMaTL.Text);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                lblTenTL.Text = result.ToString();
            }
            else
            {
                lblTenTL.Text = "";
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTL.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Tài liệu");
                return;
            }
           
            DataRow row = dtDSTL.NewRow();
            row["Ma_Tai_Lieu"] = txtMaTL.Text;
            row["Ten_TTTL"] = lblTenTL.Text;
            row["Mo_Ta"] = txtMota.Text;
            dtDSTL.Rows.Add(row);
           

            //Làm trống các ô nhập liệu
            txtMaTL.Clear();
            lblTenTL.Text = "";
            txtMota.Clear();
        }
        private void cboKieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu có chọn kiểu mượn và ngày mượn đã có giá trị
            if (cboKieuMuon.SelectedValue != null)
            {
                string KM = cboKieuMuon.SelectedValue.ToString();

                if (KM == "MV")
                    dateHanTra.Value = dateNgayMuon.Value.AddDays(15);
                else if (KM == "TC")
                    dateHanTra.Value = dateNgayMuon.Value;
            }
        }

        private void LoadThongTingrdDSTLmuon(string maPM)
        {
            try
            {
                //Lấy thông tin các cột hiển thị trong grdDSTLmuon
                maPM_DangChon = maPM;
                string sqlCT = @"SELECT ct.Ma_Tai_Lieu, tttl.Ten_TTTL, ct.Mo_Ta
                                 FROM CT_PHIEU_MUON ct
                                 JOIN TAI_LIEU t ON ct.Ma_Tai_Lieu = t.Ma_Tai_Lieu
                                 JOIN TTTL tttl on tttl.MaTTTL = t.MaTTTL
                                 WHERE ct.Ma_Phieu_Muon = @MaPM";
                SqlCommand cmd = new SqlCommand(sqlCT, conn);
                cmd.Parameters.AddWithValue("@MaPM", maPM);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtDSTL.Clear(); // xóa data cũ từ bảng đã gọi ở biến toàn cục (ko cần gọi thêm new DataTable)
                                // Đảm bảo dtDSTL có cột: "Mã tài liệu", "Tên tài liệu", "Mô tả"
                da.Fill(dtDSTL);

                grdDSTLmuon.DataSource = dtDSTL;
                grdDSTLmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết phiếu mượn: " + ex.Message);
            }
        }
        public void NapCT()
        {
            if(grdDSPM.CurrentRow == null|| grdDSPM.Rows.Count == 0)
                return;
            
            int i = grdDSPM.CurrentRow.Index;
            if (i < 0 || i >= grdDSPM.Rows.Count)
                return;
            //Hiển thị thông tin PM lên các ô nhập liệu
            txtSoTheDG.Text = grdDSPM.Rows[i].Cells["So_The_Doc_Gia"].Value.ToString();
            cboTenTT.SelectedValue = grdDSPM.Rows[i].Cells["Ma_Thu_Thu"].Value.ToString();
            cboKieuMuon.SelectedValue = grdDSPM.Rows[i].Cells["Ma_Kieu_Muon"].Value.ToString();
            dateNgayMuon.Value = Convert.ToDateTime(grdDSPM.Rows[i].Cells["Ngay_Muon"].Value);
            if (grdDSPM.Rows[i].Cells["Ngay_Thuc_Tra"].Value != DBNull.Value && !string.IsNullOrWhiteSpace(grdDSPM.Rows[i].Cells["Ngay_Thuc_Tra"].Value.ToString()))
            {
                dateNgayThucTra.Value = Convert.ToDateTime(grdDSPM.Rows[i].Cells["Ngay_Thuc_Tra"].Value);
                dateNgayThucTra.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                // Không hiển thị gì (ẩn format)
                dateNgayThucTra.CustomFormat = " ";
                dateNgayThucTra.Format = DateTimePickerFormat.Custom;
            }

            //Hiển thị danh sách tài liệu mượn vào grdDSTLmuon
            string maPM = grdDSPM.Rows[i].Cells["Ma_Phieu_Muon"].Value.ToString();
            LoadThongTingrdDSTLmuon(maPM);
            btnXoa.Enabled = true;
            btnFix.Enabled = true;
            KhoaChucNangbtn();
        }
        private void grdDSPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDSPM.CurrentRow != null && grdDSPM.CurrentRow.Index >= 0)
            {
                string maPM = grdDSPM.Rows[e.RowIndex].Cells["Ma_Phieu_Muon"].Value.ToString();
                NapCT();
                KhoaONhapLieu();
            }
            else
                return;
        } 
       
        private void KhoaChucNangbtn()
        {
            txtMaTL.Clear();
            lblTenTL.Text = "";
            txtMota.Clear();

            btnThem.Enabled = false;
            btnsave.Enabled = false;
            btnXoa.Enabled = false;

            btnFix.Enabled = true;
            btnBack.Enabled = true;

            foreach (DataGridViewColumn col in grdDSTLmuon.Columns)
            {
                if (col.Name == "btngrdXoa")
                    col.ReadOnly = true;
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnsave.Enabled = true;
            btnXoa.Enabled = true;
            btnFix.Enabled = false;
            btnsave.Text = "Update";
            foreach (DataGridViewColumn col in grdDSTLmuon.Columns)
            {
                if (col.Name == "btngrdXoa")
                    col.ReadOnly = false;
            }
            MoKhoaONhapLieu();
        }

        private void KhoaONhapLieu()
        {
            txtSoTheDG.ReadOnly = true;
            cboTenTT.Enabled = false;
            cboKieuMuon.Enabled = false;

            dateNgayMuon.Enabled = false;
            dateHanTra.Enabled = false;
            dateNgayThucTra.Enabled = false;

            txtMaTL.ReadOnly = true;
            txtMota.ReadOnly = true;
            grdDSTLmuon.Columns["btngrdXoa"].Visible = false;
        }
        private void MoKhoaONhapLieu()
        {
            txtSoTheDG.ReadOnly = false;
            cboTenTT.Enabled = true;
            cboKieuMuon.Enabled = true;
            dateNgayMuon.Enabled = true;
            //dateHanTra không được mở => không được sửa
            dateNgayThucTra.Enabled = true;
            txtMaTL.ReadOnly = false;
            txtMota.ReadOnly = false;
            grdDSTLmuon.Columns["btngrdXoa"].Visible = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    SqlCommand cmdDelCT = new SqlCommand("DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM", conn, tran);
                    cmdDelCT.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                    cmdDelCT.ExecuteNonQuery();

                    SqlCommand cmdDelPM = new SqlCommand("DELETE FROM PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM", conn, tran);
                    cmdDelPM.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                    cmdDelPM.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Đã xóa!");
                    LoadgrdDSPM();
                    dtDSTL.Clear();
                    maPM_DangChon = "";
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
                ResetForm();

            }
        }
        
        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdDSPM.ClearSelection();
            grdDSPM.CurrentCell = grdDSPM[0, 0];
            NapCT();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            int i = grdDSPM.Rows.Count - 1;
            grdDSPM.CurrentCell = grdDSPM[0, i];
            NapCT();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = grdDSPM.CurrentRow.Index;
            if (i < grdDSPM.Rows.Count - 1) //nếu chx đến dòng cuối cùng thì nhảy đến dòng tiếp
            {
                grdDSPM.CurrentCell = grdDSPM[0, i + 1];
                NapCT();
            }
        }
        private void btnPrv_Click(object sender, EventArgs e)
        {
            int i = grdDSPM.CurrentRow.Index;
            if (i > 0)
            {
                grdDSPM.CurrentCell = grdDSPM[0, i - 1];
                NapCT();
            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTruong.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comTruong.Text))
                return;
            sql = "select distinct " + comTruong.Text + " from PHIEU_MUON";
            da = new SqlDataAdapter(sql, conn); //Khai báo đối tượng DataAdapter để lấy DL
            DataTable dt1 = new DataTable(); //tạo DataTable
            da.Fill(dt1);

            comGT.DataSource = dt1; //Gán nguồn DL cho combogiaTri
            comGT.DisplayMember = comTruong.Text;
            comGT.ValueMember = comTruong.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt.Clear();

            string truong = comTruong.Text;
            sql = $"SELECT * FROM PHIEU_MUON WHERE {truong} = @giatri";
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (truong == "Ngay_Muon" || truong == "Han_Tra")
            {
                DateTime ngay = Convert.ToDateTime(comGT.Text);
                cmd.Parameters.AddWithValue("@giatri", ngay.ToString("yyyy-MM-dd"));
            }
            else
            {
                cmd.Parameters.AddWithValue("@giatri", comGT.Text);
            }

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grdDSPM.DataSource = dt;
            grdDSPM.Refresh();
            NapCT();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            comTruong.SelectedIndex = -1;
            comGT.SelectedIndex = -1;
            LoadgrdDSPM();
            grdDSPM.Refresh();

            ResetForm();
        }
    }

}
