using DevExpress.CodeParser;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTUD_QLTV
{
    public partial class frmBaocao : Form
    {
        private string connectionString = "Data Source=LAPTOP-UVIPITP3\\SQLEXPRESS;Initial Catalog=QLTV_2;Integrated Security=True";

        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        public frmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
        }

        private void btnPrint1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy giá trị ngày bắt đầu và kết thúc
                DateTime tuNgay = dtpbatdau1.Value.Date;
                DateTime denNgay = dtpketthuc1.Value.Date;

                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2️⃣ Câu truy vấn của bạn
                string query = @"
                    SELECT 
                        Ngay_Muon AS Ngaymuon,
                        COUNT(Ma_Phieu_Muon) AS Soluong
                    FROM PHIEU_MUON
                    WHERE Ngay_Muon BETWEEN @TuNgay AND @DenNgay
                    GROUP BY Ngay_Muon
                    ORDER BY Ngay_Muon";

                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                    da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);
                    da.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!", "Thông báo");
                    return;
                }

                // 3️⃣ Tạo report và truyền dữ liệu
                rptphieumuon rpt = new rptphieumuon();
                rpt.DataSource = dt;

                // 4️⃣ Truyền giá trị ngày in vào label trong report
                var lbl = rpt.FindControl("rptNgayin1", true) as XRLabel;
                if (lbl != null)
                {
                    lbl.Text = $"NEU, Ngày {DateTime.Now.Day} Tháng {DateTime.Now.Month} Năm {DateTime.Now.Year}";
                }

                // 5️⃣ (Tùy chọn) Gửi khoảng ngày vào parameter nếu report có pNgayBatDau, pNgayKetThuc
                if (rpt.Parameters["pNgayBatDau"] != null)
                    rpt.Parameters["pNgayBatDau"].Value = tuNgay;
                if (rpt.Parameters["pNgayKetThuc"] != null)
                    rpt.Parameters["pNgayKetThuc"].Value = denNgay;
                // Hiển thị ngày bắt đầu và kế thúc 
                rpt.xrloc1.Text = "Từ ngày: " + dtpbatdau1.Value.ToString("dd/MM/yyyy") + "          Đến ngày: " + dtpketthuc1.Value.ToString("dd/MM/yyyy");
                // 6️⃣ Hiển thị preview
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tuNgay = dtpbatdau2.Value.Date;
                DateTime denNgay = dtpketthuc2.Value.Date;

                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
            SELECT Ngay_Phat AS Ngayphat, 
                   COUNT(P.Ma_Phieu_Phat) AS Soluongphieuphat, 
                   SUM(Nop_Phat) AS Tongtienphat
            FROM CT_PHIEU_PHAT CT 
            INNER JOIN PHIEU_PHAT P ON P.Ma_Phieu_Phat = CT.Ma_Phieu_Phat
            WHERE Ngay_Phat >= @TuNgay AND Ngay_Phat < DATEADD(DAY,1,@DenNgay)
            GROUP BY Ngay_Phat
            ORDER BY Ngay_Phat";

                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@TuNgay", tuNgay);
                    da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);
                    da.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!", "Thông báo");
                    return;
                }

                rptphieuphat rpt = new rptphieuphat();
                rpt.DataSource = dt;

                // Hiển thị label ngày in
                var lblNgay = rpt.FindControl("rptNgayin2", true) as XRLabel;
                if (lblNgay != null)
                    lblNgay.Text = $"NEU, Ngày {DateTime.Now:dd} Tháng {DateTime.Now:MM} Năm {DateTime.Now:yyyy}";

                // Hiển thị khoảng thời gian
                var lblLoc = rpt.FindControl("xrloc2", true) as XRLabel;
                if (lblLoc != null)
                    lblLoc.Text = "Từ ngày: " + tuNgay.ToString("dd/MM/yyyy") +  "                  Đến ngày: " + denNgay.ToString("dd/MM/yyyy");

                // Hiển thị report
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrint3_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime denNgay = dtp3.Value.Date;

                string query = @"
            select PM.Ma_Phieu_Muon,
            PM.So_The_Doc_Gia,
            DG.Ho_Ten,
            PM.Ngay_Muon,
            PM.Han_Tra,
            PM.Ngay_Thuc_Tra
            FROM PHIEU_MUON PM
            JOIN DOC_GIA DG ON DG.So_The_Doc_Gia = PM.So_the_Doc_Gia 
            WHERE PM.Ngay_Thuc_Tra > PM.Han_Tra AND PM.Han_Tra <= @denNgay 
            Order by PM.Ngay_Thuc_Tra
            ";

                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@DenNgay", denNgay);
                    da.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian này!", "Thông báo");
                    return;
                }

                rptquahan rpt = new rptquahan();
                rpt.DataSource = dt;

                // Hiển thị label ngày in
                var lblNgay = rpt.FindControl("rptNgayin3", true) as XRLabel;
                if (lblNgay != null)
                    lblNgay.Text = $"NEU, Ngày {DateTime.Now:dd} Tháng {DateTime.Now:MM} Năm {DateTime.Now:yyyy}";

                // Hiển thị khoảng thời gian
                var lblLoc = rpt.FindControl("xrloc3", true) as XRLabel;
                if (lblLoc != null)
                    lblLoc.Text = "Tính đến ngày: " + denNgay.ToString("dd/MM/yyyy") ;

                // Hiển thị report
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in báo cáo: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtp3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpketthuc1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpbatdau1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dtpketthuc2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpbatdau2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void xtraOpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
    
