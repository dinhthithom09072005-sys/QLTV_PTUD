using System;
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
            cboTenTT.DisplayMember = "Ten_Thu_Thu"; //Hiển thị tên thủ thư vào combobox
            cboTenTT.ValueMember = "Ma_Thu_Thu";
            cboTenTT.SelectedIndex = -1; // không chọn mặc định
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

        DataTable dtDSTL = new DataTable();
        private void SetupgrdDSTLmuon()
        {
            dtDSTL.Columns.Add("Mã tài liệu");
            dtDSTL.Columns.Add("Tên tài liệu");
            dtDSTL.Columns.Add("Mô tả");
            grdDSTLmuon.DataSource = dtDSTL;
            grdDSTLmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btngrdXoa.Text = "Xóa"; //đặt tên cột
            grdDSTLmuon.Columns["btngrdXoa"].DisplayIndex = grdDSTLmuon.Columns.Count - 1; //đặt cột xóa ở cuối cùng

        }

        private void grdDSTLmuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua header row
            if (e.RowIndex < 0) return;
            // Kiểm tra nếu cột "Xóa" được nhấp
            if (grdDSTLmuon.Columns[e.ColumnIndex].Name == "btngrdXoa")
            {
                grdDSTLmuon.EndEdit(); // kết thúc chỉnh sửa, tránh lỗi RowIndex sai
                //Lấy dt được gán cho grdDSTLmuon
                DataTable dt = (DataTable)grdDSTLmuon.DataSource;
                if(dt != null && e.RowIndex < dt.Rows.Count)
                {
                    dt.Rows[e.RowIndex].Delete();
                    grdDSTLmuon.ClearSelection();
                }
            }
        }

        private void txtMaTT_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maPM_DangChon))
            {
                // Đang ở chế độ sửa (vì đang có mã phiếu mượn được chọn)
                UpdatePM();
            }
            else
            {
                // Đang ở chế độ tạo mới
                LuuPMmoi();
            }
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

            //Tạo Ma_Phieu_Muon tự động bắt đầu từ phần đuôi PM lớn nhất
            string maPM = "";
            using (SqlCommand cmd1 = new SqlCommand("SELECT TOP 1 Ma_Phieu_Muon FROM PHIEU_MUON ORDER BY Ma_Phieu_Muon DESC", conn))
            {
                object result = cmd1.ExecuteScalar();
                if (result != null)
                {
                    string lastMaPM = result.ToString();
                    int number = int.Parse(lastMaPM.Substring(2)) + 1; //cắt từ vtri thứ 2 chỉ lấy sau PM; int.Parse chuyển chuỗi thành số
                    maPM = "PM" + number.ToString("D2"); //D2: định dạng số có 2 chữ số
                }
                else
                {
                    maPM = "PM01"; // Nếu chưa có phiếu mượn nào
                }
            }
            SqlTransaction tran = conn.BeginTransaction();
            try
            {
                //Lưu DL vào phiếu mượn
                SqlCommand cmd = new SqlCommand(@"INSERT INTO PHIEU_MUON (Ma_Phieu_Muon, So_The_Doc_Gia, Ma_Thu_Thu, Ma_Kieu_Muon, Ngay_Muon, Ngay_Thuc_Tra) VALUES (@MaPM, @SoTheDG, @MaTT, @MaKieuMuon, @NgayMuon, @NgayThucTra)", conn, tran);
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

                //Lưu vào CT_PHIEU_MUON
                foreach (DataRow row in dtDSTL.Rows)
                {
                    SqlCommand cmdCT = new SqlCommand(@"INSERT INTO CT_PHIEU_MUON(Ma_Phieu_Muon, Ma_Tai_Lieu, Mo_Ta)
                  VALUES(@MaPM, @MaTL, @MoTa)", conn, tran);
                    cmdCT.Parameters.AddWithValue("MaPM", maPM);
                    cmdCT.Parameters.AddWithValue("@MaTL", row["Mã tài liệu"].ToString());
                    cmdCT.Parameters.AddWithValue("@MoTa", row["Mô tả"].ToString());
                    cmdCT.ExecuteNonQuery();
                }
                //Commit transaction nếu ko lỗi
                tran.Commit();
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
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
            LoadgrdDSPM();
        }
        private void UpdatePM()
        {
            SqlTransaction tran = conn.BeginTransaction();
            try
            {
                // Cập nhật PHIEU_MUON
                SqlCommand cmd = new SqlCommand(@"UPDATE PHIEU_MUON
                SET So_The_Doc_Gia = @SoTheDG,
                    Ma_Thu_Thu = @MaTT,
                    Ma_Kieu_Muon = @MaKieuMuon,
                    Ngay_Muon = @NgayMuon,
                    Ngay_Thuc_Tra = @NgayThucTra
                WHERE Ma_Phieu_Muon = @MaPM", conn, tran);
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
                SqlCommand cmdDel = new SqlCommand("DELETE FROM CT_PHIEU_MUON WHERE Ma_Phieu_Muon = @MaPM", conn, tran);
                cmdDel.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                cmdDel.ExecuteNonQuery();

                //Lấy DataTable đang hiển thị trong grdDSTLmuon
                DataTable dtgrd = (DataTable)grdDSTLmuon.DataSource;
                if (dtgrd != null)
                {
                    //Duyệt tất cả các row trong grdDSTLmuon để thêm lại những row ko bị Deleted
                    for (int i = 0; i < dtgrd.Rows.Count; i++)
                    {
                        DataRow row = dtgrd.Rows[i];
                        if (row.RowState == DataRowState.Deleted) //nếu là row đã bị xóa thì bỏ qua
                            continue;
                        //Lấy giá trị của cột Mã tài liệu
                        string maTL = "";
                        if (dtgrd.Columns.Contains("Ma_Tai_Lieu"))
                        {
                            if (row["Ma_Tai_Lieu"] != DBNull.Value)
                                maTL = row["Ma_Tai_Lieu"].ToString();
                        }

                        //Lấy mô tả
                        string moTa = "";
                        if (dtgrd.Columns.Contains("Mo_Ta"))
                        {
                            if (row["Mo_Ta"] != DBNull.Value)
                                moTa = row["Mo_Ta"].ToString();
                        }
                        // Nếu không có MaTL thì bỏ qua (an toàn)
                        if (string.IsNullOrEmpty(maTL))
                            continue;

                        //insert CTPM mới vào
                        SqlCommand cmdCT = new SqlCommand(@"INSERT INTO CT_PHIEU_MUON(Ma_Phieu_Muon, Ma_Tai_Lieu, Mo_Ta)
                    VALUES(@MaPM, @MaTL, @MoTa)", conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaPM", maPM_DangChon);
                        cmdCT.Parameters.AddWithValue("@MaTL", maTL);
                        cmdCT.Parameters.AddWithValue("@MoTa", moTa);
                        cmdCT.ExecuteNonQuery();
                    }
                    }


                tran.Commit();
                MessageBox.Show("Cập nhật phiếu mượn thành công!");
                LoadgrdDSPM();

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
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
            row["Mã tài liệu"] = txtMaTL.Text;
            row["Tên tài liệu"] = lblTenTL.Text;
            row["Mô tả"] = txtMota.Text;
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



    //CODE HIỂN THỊ CHI TIẾT PHIẾU MƯỢN KHI NHẤP VÀO GRĐ DSPM

        private void grdDSPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && grdDSPM.Columns[e.ColumnIndex].Name == "btngrdDetail")
            {                 
                string maPM = grdDSPM.Rows[e.RowIndex].Cells["Ma_Phieu_Muon"].Value.ToString();
                HienThiCTPM(maPM);
                KhoaONhapLieu();
            }    
        } 
        private void HienThiCTPM(string maPM)
        {
            maPM_DangChon = maPM; // Lưu mã phiếu mượn đang chọn vào biến toàn cục
            // Truy vấn chi tiết phiếu mượn từ cơ sở dữ liệu
            string query = @"SELECT ct.Ma_Tai_Lieu, tttl.Ten_TTTL, ct.Mo_Ta
                             FROM CT_PHIEU_MUON ct
                             JOIN TAI_LIEU t ON ct.Ma_Tai_Lieu = t.Ma_Tai_Lieu
                             JOIN TTTL tttl on tttl.MaTTTL = t.MaTTTL
                             WHERE ct.Ma_Phieu_Muon = @MaPM";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaPM", maPM);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtCTPM = new DataTable();
            da.Fill(dtCTPM);

            // Hiển thị chi tiết phiếu mượn trong grdDSTLmuon
            //grdDSTLmuon.DataSource = dtCTPM;
            // --- Chuyển dữ liệu từ dtCTPM (kết quả truy vấn) vào dtDSTL (DataTable dùng chung)
            dtDSTL.Clear(); // xóa data cũ
                            // Đảm bảo dtDSTL có cột: "Mã tài liệu", "Tên tài liệu", "Mô tả"
            for (int i = 0; i < dtCTPM.Rows.Count; i++)
            {
                DataRow src = dtCTPM.Rows[i];
                DataRow newRow = dtDSTL.NewRow();

                // src có cột: Ma_Tai_Lieu, Ten_TTTL, Mo_Ta
                if (dtCTPM.Columns.Contains("Ma_Tai_Lieu") && src["Ma_Tai_Lieu"] != DBNull.Value)
                    newRow["Mã tài liệu"] = src["Ma_Tai_Lieu"].ToString();
                if (dtCTPM.Columns.Contains("Ten_TTTL") && src["Ten_TTTL"] != DBNull.Value)
                    newRow["Tên tài liệu"] = src["Ten_TTTL"].ToString();
                if (dtCTPM.Columns.Contains("Mo_Ta") && src["Mo_Ta"] != DBNull.Value)
                    newRow["Mô tả"] = src["Mo_Ta"].ToString();

                dtDSTL.Rows.Add(newRow);
            }
            grdDSTLmuon.DataSource = dtDSTL;
            //.....
            //Hiển thị thông tin PM lên các ô nhập liệu
            string sql = "select * from PHIEU_MUON where Ma_Phieu_Muon = @MaPM";
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@MaPM", maPM);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dtPM = new DataTable();
                da1.Fill(dtPM);
                if (dtPM.Rows.Count > 0)
                {
                    txtSoTheDG.Text = dtPM.Rows[0]["So_The_Doc_Gia"].ToString();
                    cboTenTT.SelectedValue = dtPM.Rows[0]["Ma_Thu_Thu"].ToString();
                    cboKieuMuon.SelectedValue = dtPM.Rows[0]["Ma_Kieu_Muon"].ToString();
                    dateNgayMuon.Value = Convert.ToDateTime(dtPM.Rows[0]["Ngay_Muon"]);
                    if (dtPM.Rows[0]["Ngay_Thuc_Tra"] != DBNull.Value)
                    {
                        dateNgayThucTra.Value = Convert.ToDateTime(dtPM.Rows[0]["Ngay_Thuc_Tra"]);
                        dateNgayThucTra.CustomFormat = "dd/MM/yyyy";
                    }
                    else
                    {
                        dateNgayThucTra.CustomFormat = " ";
                    }
                }
            //Khóa giao diện thêm sửa xóa
            KhoaChucNangbtn();
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetForm();
        }


    }

}
