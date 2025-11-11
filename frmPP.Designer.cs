namespace PTUD_QLTV
{
    partial class frmPP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDSPP = new System.Windows.Forms.DataGridView();
            this.lblMPM = new System.Windows.Forms.Label();
            this.lblnp = new System.Windows.Forms.Label();
            this.lblMTT = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTVP = new System.Windows.Forms.Label();
            this.lblmTL = new System.Windows.Forms.Label();
            this.lblmt = new System.Windows.Forms.Label();
            this.lblnopphat = new System.Windows.Forms.Label();
            this.grbDSPP = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblttPP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbTTPP = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbCTPP = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblHTP = new System.Windows.Forms.Label();
            this.lbl_htp = new System.Windows.Forms.Label();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.lbltTL = new System.Windows.Forms.Label();
            this.grdCTPP = new System.Windows.Forms.DataGridView();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.cboMaTL = new System.Windows.Forms.ComboBox();
            this.cboTenVP = new System.Windows.Forms.ComboBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.cboMaTT = new System.Windows.Forms.ComboBox();
            this.dtpNgayPhat = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.btngrdXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDSPP)).BeginInit();
            this.grbDSPP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbTTPP.SuspendLayout();
            this.grbCTPP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTPP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDSPP
            // 
            this.grdDSPP.AllowUserToAddRows = false;
            this.grdDSPP.AllowUserToDeleteRows = false;
            this.grdDSPP.AllowUserToResizeRows = false;
            this.grdDSPP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDSPP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.grdDSPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDSPP.Location = new System.Drawing.Point(22, 38);
            this.grdDSPP.Name = "grdDSPP";
            this.grdDSPP.RowHeadersWidth = 62;
            this.grdDSPP.RowTemplate.Height = 28;
            this.grdDSPP.Size = new System.Drawing.Size(820, 550);
            this.grdDSPP.TabIndex = 0;
            this.grdDSPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDSPP_CellContentClick);
            // 
            // lblMPM
            // 
            this.lblMPM.AutoSize = true;
            this.lblMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMPM.Location = new System.Drawing.Point(40, 37);
            this.lblMPM.Name = "lblMPM";
            this.lblMPM.Size = new System.Drawing.Size(147, 25);
            this.lblMPM.TabIndex = 1;
            this.lblMPM.Text = "Mã phiếu mượn";
            // 
            // lblnp
            // 
            this.lblnp.AutoSize = true;
            this.lblnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnp.Location = new System.Drawing.Point(393, 37);
            this.lblnp.Name = "lblnp";
            this.lblnp.Size = new System.Drawing.Size(101, 25);
            this.lblnp.TabIndex = 2;
            this.lblnp.Text = "Ngày phạt";
            // 
            // lblMTT
            // 
            this.lblMTT.AutoSize = true;
            this.lblMTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMTT.Location = new System.Drawing.Point(40, 88);
            this.lblMTT.Name = "lblMTT";
            this.lblMTT.Size = new System.Drawing.Size(104, 25);
            this.lblMTT.TabIndex = 3;
            this.lblMTT.Text = "Mã thủ thư";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(40, 321);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(143, 25);
            this.lblTong.TabIndex = 4;
            this.lblTong.Text = "Tổng tiền phạt:";
            // 
            // lblTVP
            // 
            this.lblTVP.AutoSize = true;
            this.lblTVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTVP.Location = new System.Drawing.Point(40, 121);
            this.lblTVP.Name = "lblTVP";
            this.lblTVP.Size = new System.Drawing.Size(133, 25);
            this.lblTVP.TabIndex = 8;
            this.lblTVP.Text = "Tên vi phạm *";
            // 
            // lblmTL
            // 
            this.lblmTL.AutoSize = true;
            this.lblmTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmTL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmTL.Location = new System.Drawing.Point(40, 31);
            this.lblmTL.Name = "lblmTL";
            this.lblmTL.Size = new System.Drawing.Size(113, 25);
            this.lblmTL.TabIndex = 9;
            this.lblmTL.Text = "Mã tài liệu *";
            // 
            // lblmt
            // 
            this.lblmt.AutoSize = true;
            this.lblmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmt.Location = new System.Drawing.Point(40, 252);
            this.lblmt.Name = "lblmt";
            this.lblmt.Size = new System.Drawing.Size(61, 25);
            this.lblmt.TabIndex = 10;
            this.lblmt.Text = "Mô tả";
            // 
            // lblnopphat
            // 
            this.lblnopphat.AutoSize = true;
            this.lblnopphat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnopphat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblnopphat.Location = new System.Drawing.Point(40, 206);
            this.lblnopphat.Name = "lblnopphat";
            this.lblnopphat.Size = new System.Drawing.Size(129, 25);
            this.lblnopphat.TabIndex = 11;
            this.lblnopphat.Text = "Số tiền phạt *";
            // 
            // grbDSPP
            // 
            this.grbDSPP.Controls.Add(this.btnLast);
            this.grbDSPP.Controls.Add(this.btnNext);
            this.grbDSPP.Controls.Add(this.btnPrv);
            this.grbDSPP.Controls.Add(this.btnFirst);
            this.grbDSPP.Controls.Add(this.grdDSPP);
            this.grbDSPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDSPP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grbDSPP.Location = new System.Drawing.Point(997, 244);
            this.grbDSPP.Name = "grbDSPP";
            this.grbDSPP.Size = new System.Drawing.Size(867, 665);
            this.grbDSPP.TabIndex = 12;
            this.grbDSPP.TabStop = false;
            this.grbDSPP.Text = "Danh sách phiếu phạt";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(575, 598);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(78, 43);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(472, 598);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 43);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(373, 598);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(78, 43);
            this.btnPrv.TabIndex = 6;
            this.btnPrv.Text = "<";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(274, 598);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(78, 43);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblttPP
            // 
            this.lblttPP.AutoSize = true;
            this.lblttPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttPP.Location = new System.Drawing.Point(354, 18);
            this.lblttPP.Name = "lblttPP";
            this.lblttPP.Size = new System.Drawing.Size(165, 29);
            this.lblttPP.TabIndex = 13;
            this.lblttPP.Text = "PHIẾU PHẠT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblttPP);
            this.panel1.Location = new System.Drawing.Point(68, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 62);
            this.panel1.TabIndex = 14;
            // 
            // grbTTPP
            // 
            this.grbTTPP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbTTPP.Controls.Add(this.btnRefresh);
            this.grbTTPP.Controls.Add(this.btnXoa);
            this.grbTTPP.Controls.Add(this.btnSua);
            this.grbTTPP.Controls.Add(this.btnCapnhat);
            this.grbTTPP.Controls.Add(this.btnLuu);
            this.grbTTPP.Controls.Add(this.grbCTPP);
            this.grbTTPP.Controls.Add(this.groupBox1);
            this.grbTTPP.Location = new System.Drawing.Point(68, 45);
            this.grbTTPP.Name = "grbTTPP";
            this.grbTTPP.Size = new System.Drawing.Size(862, 864);
            this.grbTTPP.TabIndex = 15;
            this.grbTTPP.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.ImageKey = "refresh-arrow.png";
            this.btnRefresh.ImageList = this.imageList1;
            this.btnRefresh.Location = new System.Drawing.Point(277, 793);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 47);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "captcha.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "exit.png");
            this.imageList1.Images.SetKeyName(4, "filter.png");
            this.imageList1.Images.SetKeyName(5, "fine (1).png");
            this.imageList1.Images.SetKeyName(6, "fine.png");
            this.imageList1.Images.SetKeyName(7, "group.png");
            this.imageList1.Images.SetKeyName(8, "image-gallery.png");
            this.imageList1.Images.SetKeyName(9, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(10, "magnifier.png");
            this.imageList1.Images.SetKeyName(11, "next.png");
            this.imageList1.Images.SetKeyName(12, "penalties.png");
            this.imageList1.Images.SetKeyName(13, "refresh-arrow.png");
            this.imageList1.Images.SetKeyName(14, "save.png");
            this.imageList1.Images.SetKeyName(15, "shutdown.png");
            this.imageList1.Images.SetKeyName(16, "trash.png");
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageKey = "trash.png";
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(422, 793);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(127, 47);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa   ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.ImageKey = "edit.png";
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(555, 793);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(127, 47);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa    ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhat.ImageKey = "captcha.png";
            this.btnCapnhat.ImageList = this.imageList1;
            this.btnCapnhat.Location = new System.Drawing.Point(689, 793);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnCapnhat.Size = new System.Drawing.Size(127, 47);
            this.btnCapnhat.TabIndex = 11;
            this.btnCapnhat.Text = "Update";
            this.btnCapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "save.png";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(689, 793);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(127, 47);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu   ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // grbCTPP
            // 
            this.grbCTPP.Controls.Add(this.btnThem);
            this.grbCTPP.Controls.Add(this.lblSum);
            this.grbCTPP.Controls.Add(this.lblHTP);
            this.grbCTPP.Controls.Add(this.lbl_htp);
            this.grbCTPP.Controls.Add(this.lblTenTL);
            this.grbCTPP.Controls.Add(this.lbltTL);
            this.grbCTPP.Controls.Add(this.lblTong);
            this.grbCTPP.Controls.Add(this.grdCTPP);
            this.grbCTPP.Controls.Add(this.txtMota);
            this.grbCTPP.Controls.Add(this.cboMaTL);
            this.grbCTPP.Controls.Add(this.cboTenVP);
            this.grbCTPP.Controls.Add(this.txtSoTien);
            this.grbCTPP.Controls.Add(this.lblmTL);
            this.grbCTPP.Controls.Add(this.lblTVP);
            this.grbCTPP.Controls.Add(this.lblmt);
            this.grbCTPP.Controls.Add(this.lblnopphat);
            this.grbCTPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCTPP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbCTPP.Location = new System.Drawing.Point(23, 188);
            this.grbCTPP.Name = "grbCTPP";
            this.grbCTPP.Size = new System.Drawing.Size(819, 588);
            this.grbCTPP.TabIndex = 5;
            this.grbCTPP.TabStop = false;
            this.grbCTPP.Text = "Chi tiết phiếu phạt";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "add.png";
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(666, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(127, 41);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm   ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Red;
            this.lblSum.Location = new System.Drawing.Point(189, 321);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(57, 25);
            this.lblSum.TabIndex = 21;
            this.lblSum.Text = "         ";
            // 
            // lblHTP
            // 
            this.lblHTP.AutoSize = true;
            this.lblHTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHTP.Location = new System.Drawing.Point(198, 166);
            this.lblHTP.Name = "lblHTP";
            this.lblHTP.Size = new System.Drawing.Size(57, 25);
            this.lblHTP.TabIndex = 20;
            this.lblHTP.Text = "         ";
            // 
            // lbl_htp
            // 
            this.lbl_htp.AutoSize = true;
            this.lbl_htp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_htp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_htp.Location = new System.Drawing.Point(40, 166);
            this.lbl_htp.Name = "lbl_htp";
            this.lbl_htp.Size = new System.Drawing.Size(137, 25);
            this.lbl_htp.TabIndex = 19;
            this.lbl_htp.Text = "Hình thức phạt";
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTenTL.Location = new System.Drawing.Point(189, 79);
            this.lblTenTL.Name = "lblTenTL";
            this.lblTenTL.Size = new System.Drawing.Size(67, 25);
            this.lblTenTL.TabIndex = 18;
            this.lblTenTL.Text = "           ";
            // 
            // lbltTL
            // 
            this.lbltTL.AutoSize = true;
            this.lbltTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltTL.Location = new System.Drawing.Point(40, 79);
            this.lbltTL.Name = "lbltTL";
            this.lbltTL.Size = new System.Drawing.Size(107, 25);
            this.lbltTL.TabIndex = 17;
            this.lbltTL.Text = "Tên tài liệu";
            // 
            // grdCTPP
            // 
            this.grdCTPP.AllowUserToAddRows = false;
            this.grdCTPP.AllowUserToDeleteRows = false;
            this.grdCTPP.AllowUserToResizeRows = false;
            this.grdCTPP.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCTPP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdCTPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCTPP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btngrdXoa});
            this.grdCTPP.Location = new System.Drawing.Point(24, 360);
            this.grdCTPP.Name = "grdCTPP";
            this.grdCTPP.RowHeadersWidth = 62;
            this.grdCTPP.RowTemplate.Height = 28;
            this.grdCTPP.Size = new System.Drawing.Size(769, 214);
            this.grdCTPP.TabIndex = 16;
            this.grdCTPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCTPP_CellContentClick);
            this.grdCTPP.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCTPP_CellValueChanged);
            // 
            // txtMota
            // 
            this.txtMota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMota.Location = new System.Drawing.Point(193, 249);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(492, 32);
            this.txtMota.TabIndex = 6;
            // 
            // cboMaTL
            // 
            this.cboMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTL.FormattingEnabled = true;
            this.cboMaTL.Location = new System.Drawing.Point(193, 31);
            this.cboMaTL.Name = "cboMaTL";
            this.cboMaTL.Size = new System.Drawing.Size(154, 33);
            this.cboMaTL.TabIndex = 3;
            this.cboMaTL.SelectedIndexChanged += new System.EventHandler(this.cboMaTL_SelectedIndexChanged);
            // 
            // cboTenVP
            // 
            this.cboTenVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenVP.FormattingEnabled = true;
            this.cboTenVP.ItemHeight = 25;
            this.cboTenVP.Location = new System.Drawing.Point(193, 121);
            this.cboTenVP.Name = "cboTenVP";
            this.cboTenVP.Size = new System.Drawing.Size(492, 33);
            this.cboTenVP.TabIndex = 4;
            this.cboTenVP.SelectedIndexChanged += new System.EventHandler(this.cboTenVP_SelectedIndexChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(193, 204);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(154, 30);
            this.txtSoTien.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPM);
            this.groupBox1.Controls.Add(this.cboMaTT);
            this.groupBox1.Controls.Add(this.dtpNgayPhat);
            this.groupBox1.Controls.Add(this.lblnp);
            this.groupBox1.Controls.Add(this.lblMTT);
            this.groupBox1.Controls.Add(this.lblMPM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(23, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu phạt";
            // 
            // txtMaPM
            // 
            this.txtMaPM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaPM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaPM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaPM.Location = new System.Drawing.Point(193, 34);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(154, 32);
            this.txtMaPM.TabIndex = 1;
            this.txtMaPM.Leave += new System.EventHandler(this.txtMaPM_Leave);
            // 
            // cboMaTT
            // 
            this.cboMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTT.FormattingEnabled = true;
            this.cboMaTT.Location = new System.Drawing.Point(193, 85);
            this.cboMaTT.Name = "cboMaTT";
            this.cboMaTT.Size = new System.Drawing.Size(154, 33);
            this.cboMaTT.TabIndex = 2;
            // 
            // dtpNgayPhat
            // 
            this.dtpNgayPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayPhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhat.Location = new System.Drawing.Point(510, 37);
            this.dtpNgayPhat.Name = "dtpNgayPhat";
            this.dtpNgayPhat.Size = new System.Drawing.Size(175, 30);
            this.dtpNgayPhat.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comGT);
            this.groupBox2.Controls.Add(this.comTruong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(997, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(867, 200);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFilter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.ImageKey = "filter.png";
            this.btnFilter.ImageList = this.imageList1;
            this.btnFilter.Location = new System.Drawing.Point(663, 139);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(130, 47);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Lọc    ";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(497, 68);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(296, 33);
            this.comGT.TabIndex = 3;
            // 
            // comTruong
            // 
            this.comTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "Ma_Phieu_Muon",
            "Ma_Thu_Thu",
            "Ngay_Phat"});
            this.comTruong.Location = new System.Drawing.Point(115, 68);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(237, 33);
            this.comTruong.TabIndex = 2;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // btngrdXoa
            // 
            this.btngrdXoa.HeaderText = "";
            this.btngrdXoa.MinimumWidth = 8;
            this.btngrdXoa.Name = "btngrdXoa";
            this.btngrdXoa.Text = "Xóa";
            this.btngrdXoa.UseColumnTextForButtonValue = true;
            this.btngrdXoa.Width = 60;
            // 
            // frmPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbTTPP);
            this.Controls.Add(this.grbDSPP);
            this.Name = "frmPP";
            this.Text = "frmPP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDSPP)).EndInit();
            this.grbDSPP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbTTPP.ResumeLayout(false);
            this.grbCTPP.ResumeLayout(false);
            this.grbCTPP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCTPP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDSPP;
        private System.Windows.Forms.Label lblMPM;
        private System.Windows.Forms.Label lblnp;
        private System.Windows.Forms.Label lblMTT;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTVP;
        private System.Windows.Forms.Label lblmTL;
        private System.Windows.Forms.Label lblmt;
        private System.Windows.Forms.Label lblnopphat;
        private System.Windows.Forms.GroupBox grbDSPP;
        private System.Windows.Forms.Label lblttPP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTTPP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayPhat;
        private System.Windows.Forms.GroupBox grbCTPP;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.DataGridView grdCTPP;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.ComboBox cboMaTL;
        private System.Windows.Forms.ComboBox cboTenVP;
        private System.Windows.Forms.Label lblTenTL;
        private System.Windows.Forms.Label lbltTL;
        private System.Windows.Forms.ComboBox cboMaTT;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblHTP;
        private System.Windows.Forms.Label lbl_htp;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewButtonColumn btngrdXoa;
    }
}