using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YourNamespace
{
    
    public partial class FormBaoCao : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string strConn;

        public FormBaoCao()
        {
            InitializeComponent();
        }

       
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            grdbaocao.AutoGenerateColumns = false;

            strConn = "Data Source=LAPTOP-UVIPITP3\\SQLEXPRESS; Initial Catalog=QLTV_2; Integrated Security=True; Encrypt=False";
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadData();
        }

        public void LoadData()
        {
            string sql = "SELECT " +
                " P.Ngay_Phat AS [Ngày phạt]," +
                "  COUNT(P.Ma_Phieu_Phat) AS [Số lượng phiếu phạt], " +
                "  SUM(ISNULL(CT.Nop_Phat,0)) AS [Tổng tiền phạt]" +
                "FROM CT_PHIEU_PHAT CT" +
                "INNER JOIN PHIEU_PHAT P ON P.Ma_Phieu_Phat = CT.Ma_Phieu_Phat" +
                "  WHERE P.Ngay_Phat >= @NgayBatDau AND P.Ngay_Phat <= @NgayKetThuc" +
                "GROUP BY P.Ngay_Phat" +
                "ORDER BY P.Ngay_Phat";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            grdbaocao.DataSource = dt;
        }
        
        private void btnLoc_Click(object sender, EventArgs e)
        {
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void FormBaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void InitializeComponent()
        {
           
        }

        
    }
}