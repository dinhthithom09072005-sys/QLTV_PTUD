namespace PTUD_QLTV
{
    partial class frmDMDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMDG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Makhoa = new System.Windows.Forms.Label();
            this.lbl_Ngaycap = new System.Windows.Forms.Label();
            this.lbl_Malop = new System.Windows.Forms.Label();
            this.lbl_Hoten = new System.Windows.Forms.Label();
            this.txt_Malop = new System.Windows.Forms.TextBox();
            this.txt_ST = new System.Windows.Forms.TextBox();
            this.lbl_ST = new System.Windows.Forms.Label();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.txt_Makhoa = new System.Windows.Forms.TextBox();
            this.txt_Nghenghiep = new System.Windows.Forms.TextBox();
            this.lbl_Nghenghiep = new System.Windows.Forms.Label();
            this.dt_Ngaycap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_filter = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.com_truong = new System.Windows.Forms.ComboBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_field = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grbDSDG = new System.Windows.Forms.GroupBox();
            this.dgv_DMDG = new System.Windows.Forms.DataGridView();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblttDG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDSDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Makhoa
            // 
            this.lbl_Makhoa.AutoSize = true;
            this.lbl_Makhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Makhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Makhoa.Location = new System.Drawing.Point(109, 312);
            this.lbl_Makhoa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Makhoa.Name = "lbl_Makhoa";
            this.lbl_Makhoa.Size = new System.Drawing.Size(147, 25);
            this.lbl_Makhoa.TabIndex = 4;
            this.lbl_Makhoa.Text = "Mã khoa viện:";
            // 
            // lbl_Ngaycap
            // 
            this.lbl_Ngaycap.AutoSize = true;
            this.lbl_Ngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaycap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Ngaycap.Location = new System.Drawing.Point(109, 130);
            this.lbl_Ngaycap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Ngaycap.Name = "lbl_Ngaycap";
            this.lbl_Ngaycap.Size = new System.Drawing.Size(151, 25);
            this.lbl_Ngaycap.TabIndex = 3;
            this.lbl_Ngaycap.Text = "Ngày câp thẻ: ";
            // 
            // lbl_Malop
            // 
            this.lbl_Malop.AutoSize = true;
            this.lbl_Malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Malop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Malop.Location = new System.Drawing.Point(109, 249);
            this.lbl_Malop.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Malop.Name = "lbl_Malop";
            this.lbl_Malop.Size = new System.Drawing.Size(83, 25);
            this.lbl_Malop.TabIndex = 5;
            this.lbl_Malop.Text = "Mã lớp:";
            // 
            // lbl_Hoten
            // 
            this.lbl_Hoten.AutoSize = true;
            this.lbl_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Hoten.Location = new System.Drawing.Point(109, 189);
            this.lbl_Hoten.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Hoten.Name = "lbl_Hoten";
            this.lbl_Hoten.Size = new System.Drawing.Size(116, 25);
            this.lbl_Hoten.TabIndex = 2;
            this.lbl_Hoten.Text = "Họ và tên: ";
            // 
            // txt_Malop
            // 
            this.txt_Malop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Malop.Location = new System.Drawing.Point(272, 249);
            this.txt_Malop.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Malop.Name = "txt_Malop";
            this.txt_Malop.Size = new System.Drawing.Size(289, 31);
            this.txt_Malop.TabIndex = 4;
            this.txt_Malop.TextChanged += new System.EventHandler(this.txt_Malop_TextChanged);
            // 
            // txt_ST
            // 
            this.txt_ST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ST.Location = new System.Drawing.Point(272, 68);
            this.txt_ST.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ST.Name = "txt_ST";
            this.txt_ST.Size = new System.Drawing.Size(289, 31);
            this.txt_ST.TabIndex = 1;
            this.txt_ST.TextChanged += new System.EventHandler(this.txt_ST_TextChanged);
            // 
            // lbl_ST
            // 
            this.lbl_ST.AutoSize = true;
            this.lbl_ST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ST.Location = new System.Drawing.Point(109, 68);
            this.lbl_ST.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ST.Name = "lbl_ST";
            this.lbl_ST.Size = new System.Drawing.Size(156, 25);
            this.lbl_ST.TabIndex = 0;
            this.lbl_ST.Text = "Số thẻ độc giả:";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hoten.Location = new System.Drawing.Point(272, 189);
            this.txt_Hoten.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(289, 31);
            this.txt_Hoten.TabIndex = 3;
            this.txt_Hoten.TextChanged += new System.EventHandler(this.txt_Hoten_TextChanged);
            // 
            // txt_Makhoa
            // 
            this.txt_Makhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Makhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Makhoa.Location = new System.Drawing.Point(272, 312);
            this.txt_Makhoa.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Makhoa.Name = "txt_Makhoa";
            this.txt_Makhoa.Size = new System.Drawing.Size(289, 31);
            this.txt_Makhoa.TabIndex = 5;
            // 
            // txt_Nghenghiep
            // 
            this.txt_Nghenghiep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nghenghiep.Location = new System.Drawing.Point(272, 375);
            this.txt_Nghenghiep.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Nghenghiep.Name = "txt_Nghenghiep";
            this.txt_Nghenghiep.Size = new System.Drawing.Size(289, 31);
            this.txt_Nghenghiep.TabIndex = 6;
            // 
            // lbl_Nghenghiep
            // 
            this.lbl_Nghenghiep.AutoSize = true;
            this.lbl_Nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nghenghiep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Nghenghiep.Location = new System.Drawing.Point(109, 375);
            this.lbl_Nghenghiep.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Nghenghiep.Name = "lbl_Nghenghiep";
            this.lbl_Nghenghiep.Size = new System.Drawing.Size(140, 25);
            this.lbl_Nghenghiep.TabIndex = 11;
            this.lbl_Nghenghiep.Text = "Nghề nghiệp:";
            // 
            // dt_Ngaycap
            // 
            this.dt_Ngaycap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaycap.Location = new System.Drawing.Point(272, 130);
            this.dt_Ngaycap.Margin = new System.Windows.Forms.Padding(6);
            this.dt_Ngaycap.Name = "dt_Ngaycap";
            this.dt_Ngaycap.Size = new System.Drawing.Size(289, 31);
            this.dt_Ngaycap.TabIndex = 2;
            this.dt_Ngaycap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_filter);
            this.groupBox1.Controls.Add(this.comGT);
            this.groupBox1.Controls.Add(this.com_truong);
            this.groupBox1.Controls.Add(this.lbl_value);
            this.groupBox1.Controls.Add(this.lbl_field);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(1157, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 215);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Lavender;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.ImageKey = "loading-arrow.png";
            this.btn_reset.ImageList = this.imageList1;
            this.btn_reset.Location = new System.Drawing.Point(359, 146);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 47);
            this.btn_reset.TabIndex = 37;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "book (1).png");
            this.imageList1.Images.SetKeyName(2, "book (2).png");
            this.imageList1.Images.SetKeyName(3, "book.png");
            this.imageList1.Images.SetKeyName(4, "borrow.png");
            this.imageList1.Images.SetKeyName(5, "captcha.png");
            this.imageList1.Images.SetKeyName(6, "copywriter.png");
            this.imageList1.Images.SetKeyName(7, "edit.png");
            this.imageList1.Images.SetKeyName(8, "exit.png");
            this.imageList1.Images.SetKeyName(9, "filter.png");
            this.imageList1.Images.SetKeyName(10, "fine (1).png");
            this.imageList1.Images.SetKeyName(11, "fine.png");
            this.imageList1.Images.SetKeyName(12, "group.png");
            this.imageList1.Images.SetKeyName(13, "image-gallery.png");
            this.imageList1.Images.SetKeyName(14, "literacy.png");
            this.imageList1.Images.SetKeyName(15, "loading-arrow.png");
            this.imageList1.Images.SetKeyName(16, "log-data.png");
            this.imageList1.Images.SetKeyName(17, "login.png");
            this.imageList1.Images.SetKeyName(18, "login-.png");
            this.imageList1.Images.SetKeyName(19, "logout.png");
            this.imageList1.Images.SetKeyName(20, "log-out.png");
            this.imageList1.Images.SetKeyName(21, "magnifier.png");
            this.imageList1.Images.SetKeyName(22, "next.png");
            this.imageList1.Images.SetKeyName(23, "penalties.png");
            this.imageList1.Images.SetKeyName(24, "profile.png");
            this.imageList1.Images.SetKeyName(25, "rating.png");
            this.imageList1.Images.SetKeyName(26, "reading.png");
            this.imageList1.Images.SetKeyName(27, "refresh-arrow.png");
            this.imageList1.Images.SetKeyName(28, "save.png");
            this.imageList1.Images.SetKeyName(29, "shutdown.png");
            this.imageList1.Images.SetKeyName(30, "trash.png");
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_filter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filter.ImageKey = "filter.png";
            this.btn_filter.ImageList = this.imageList1;
            this.btn_filter.Location = new System.Drawing.Point(504, 146);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_filter.Size = new System.Drawing.Size(130, 47);
            this.btn_filter.TabIndex = 6;
            this.btn_filter.Text = "Lọc    ";
            this.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(418, 79);
            this.comGT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(216, 34);
            this.comGT.TabIndex = 3;
            // 
            // com_truong
            // 
            this.com_truong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_truong.FormattingEnabled = true;
            this.com_truong.Items.AddRange(new object[] {
            "Ngay_Cap_The",
            "So_The_Doc_Gia",
            "Ho_Ten",
            "Ma_Lop",
            "Ma_Khoa_Vien",
            "Chuc_Vu"});
            this.com_truong.Location = new System.Drawing.Point(53, 79);
            this.com_truong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_truong.Name = "com_truong";
            this.com_truong.Size = new System.Drawing.Size(216, 34);
            this.com_truong.TabIndex = 2;
            this.com_truong.SelectedIndexChanged += new System.EventHandler(this.com_truong_SelectedIndexChanged);
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_value.Location = new System.Drawing.Point(414, 50);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(69, 25);
            this.lbl_value.TabIndex = 1;
            this.lbl_value.Text = "Giá trị";
            // 
            // lbl_field
            // 
            this.lbl_field.AutoSize = true;
            this.lbl_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_field.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_field.Location = new System.Drawing.Point(48, 50);
            this.lbl_field.Name = "lbl_field";
            this.lbl_field.Size = new System.Drawing.Size(80, 25);
            this.lbl_field.TabIndex = 0;
            this.lbl_field.Text = "Trường";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.lbl_Makhoa);
            this.groupBox2.Controls.Add(this.lbl_Ngaycap);
            this.groupBox2.Controls.Add(this.lbl_Nghenghiep);
            this.groupBox2.Controls.Add(this.lbl_Malop);
            this.groupBox2.Controls.Add(this.lbl_Hoten);
            this.groupBox2.Controls.Add(this.txt_Makhoa);
            this.groupBox2.Controls.Add(this.txt_Malop);
            this.groupBox2.Controls.Add(this.lbl_ST);
            this.groupBox2.Controls.Add(this.dt_Ngaycap);
            this.groupBox2.Controls.Add(this.txt_Nghenghiep);
            this.groupBox2.Controls.Add(this.txt_ST);
            this.groupBox2.Controls.Add(this.txt_Hoten);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(1157, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 527);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin độc giả";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.ImageKey = "loading-arrow.png";
            this.btn_Clear.ImageList = this.imageList1;
            this.btn_Clear.Location = new System.Drawing.Point(65, 432);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 47);
            this.btn_Clear.TabIndex = 37;
            this.btn_Clear.Text = "Clear ";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImageKey = "trash.png";
            this.btn_Xoa.ImageList = this.imageList1;
            this.btn_Xoa.Location = new System.Drawing.Point(211, 432);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(127, 47);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xóa   ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImageKey = "edit.png";
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(359, 432);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(127, 47);
            this.btn_Sua.TabIndex = 35;
            this.btn_Sua.Text = "Sửa    ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImageKey = "save.png";
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(509, 432);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(127, 47);
            this.btn_Them.TabIndex = 34;
            this.btn_Them.Text = "Thêm  ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grbDSDG
            // 
            this.grbDSDG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDSDG.Controls.Add(this.btn_next);
            this.grbDSDG.Controls.Add(this.btn_prev);
            this.grbDSDG.Controls.Add(this.btn_first);
            this.grbDSDG.Controls.Add(this.btn_last);
            this.grbDSDG.Controls.Add(this.btn_search);
            this.grbDSDG.Controls.Add(this.dgv_DMDG);
            this.grbDSDG.Location = new System.Drawing.Point(84, 53);
            this.grbDSDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDSDG.Name = "grbDSDG";
            this.grbDSDG.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDSDG.Size = new System.Drawing.Size(1024, 878);
            this.grbDSDG.TabIndex = 20;
            this.grbDSDG.TabStop = false;
            this.grbDSDG.Text = "grbDSDG";
            // 
            // dgv_DMDG
            // 
            this.dgv_DMDG.AllowUserToAddRows = false;
            this.dgv_DMDG.AllowUserToDeleteRows = false;
            this.dgv_DMDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DMDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DMDG.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DMDG.Location = new System.Drawing.Point(33, 123);
            this.dgv_DMDG.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.dgv_DMDG.Name = "dgv_DMDG";
            this.dgv_DMDG.ReadOnly = true;
            this.dgv_DMDG.RowHeadersWidth = 51;
            this.dgv_DMDG.RowTemplate.Height = 24;
            this.dgv_DMDG.Size = new System.Drawing.Size(959, 655);
            this.dgv_DMDG.TabIndex = 0;
            this.dgv_DMDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMDG_CellClick);
            this.dgv_DMDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMDG_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.EditValue = "";
            this.btn_search.Location = new System.Drawing.Point(33, 62);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Appearance.Options.UseForeColor = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(319, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.SelectedIndexChanged += new System.EventHandler(this.btn_search_SelectedIndexChanged);
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_next.Location = new System.Drawing.Point(554, 796);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(64, 43);
            this.btn_next.TabIndex = 26;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_prev.Location = new System.Drawing.Point(455, 796);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(64, 43);
            this.btn_prev.TabIndex = 25;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_first.Location = new System.Drawing.Point(379, 796);
            this.btn_first.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(64, 43);
            this.btn_first.TabIndex = 24;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_last.Location = new System.Drawing.Point(628, 796);
            this.btn_last.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(64, 43);
            this.btn_last.TabIndex = 27;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblttDG);
            this.panel1.Location = new System.Drawing.Point(84, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 48);
            this.panel1.TabIndex = 28;
            // 
            // lblttDG
            // 
            this.lblttDG.AutoSize = true;
            this.lblttDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttDG.Location = new System.Drawing.Point(355, 9);
            this.lblttDG.Name = "lblttDG";
            this.lblttDG.Size = new System.Drawing.Size(227, 29);
            this.lblttDG.TabIndex = 13;
            this.lblttDG.Text = "Danh sách độc giả";
            // 
            // frmDMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDSDG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDMDG";
            this.Text = "frmDMDG";
            this.Load += new System.EventHandler(this.frmDMDGcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbDSDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Makhoa;
        private System.Windows.Forms.Label lbl_Ngaycap;
        private System.Windows.Forms.Label lbl_Malop;
        private System.Windows.Forms.Label lbl_Hoten;
        private System.Windows.Forms.TextBox txt_Malop;
        private System.Windows.Forms.TextBox txt_ST;
        private System.Windows.Forms.Label lbl_ST;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.TextBox txt_Makhoa;
        private System.Windows.Forms.TextBox txt_Nghenghiep;
        private System.Windows.Forms.Label lbl_Nghenghiep;
        private System.Windows.Forms.DateTimePicker dt_Ngaycap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox com_truong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox grbDSDG;
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridView dgv_DMDG;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblttDG;
    }
}