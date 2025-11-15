namespace PTUD_QLTV
{
    partial class frmTG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTG));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.dgv_TG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_NS = new System.Windows.Forms.DateTimePicker();
            this.lbl_field = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.com_Truong = new System.Windows.Forms.ComboBox();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_filter = new System.Windows.Forms.Button();
            this.lbl_NS = new System.Windows.Forms.Label();
            this.lbl_TenTG = new System.Windows.Forms.Label();
            this.lbl_MaTG = new System.Windows.Forms.Label();
            this.txt_TenTG = new System.Windows.Forms.TextBox();
            this.txt_MaTG = new System.Windows.Forms.TextBox();
            this.Nam_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNhapTG = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.grbDSTG = new System.Windows.Forms.GroupBox();
            this.lblttTG = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbNhapTG.SuspendLayout();
            this.grbDSTG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_next.Location = new System.Drawing.Point(509, 787);
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
            this.btn_prev.Location = new System.Drawing.Point(387, 787);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.btn_first.Location = new System.Drawing.Point(315, 787);
            this.btn_first.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.btn_last.Location = new System.Drawing.Point(581, 787);
            this.btn_last.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(64, 43);
            this.btn_last.TabIndex = 27;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_search
            // 
            this.btn_search.EditValue = "";
            this.btn_search.Location = new System.Drawing.Point(68, 95);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Appearance.Options.UseForeColor = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(276, 32);
            this.btn_search.TabIndex = 23;
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // dgv_TG
            // 
            this.dgv_TG.AllowUserToAddRows = false;
            this.dgv_TG.AllowUserToDeleteRows = false;
            this.dgv_TG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TG.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_TG.Location = new System.Drawing.Point(68, 158);
            this.dgv_TG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_TG.Name = "dgv_TG";
            this.dgv_TG.ReadOnly = true;
            this.dgv_TG.RowHeadersWidth = 51;
            this.dgv_TG.RowTemplate.Height = 24;
            this.dgv_TG.Size = new System.Drawing.Size(834, 617);
            this.dgv_TG.TabIndex = 0;
            this.dgv_TG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TG_CellClick);
            this.dgv_TG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TG_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma_Tac_Gia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã tác giả";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten_Tac_Gia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên tác giả";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nam_Sinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Năm sinh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dt_NS
            // 
            this.dt_NS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NS.Location = new System.Drawing.Point(231, 229);
            this.dt_NS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt_NS.Name = "dt_NS";
            this.dt_NS.Size = new System.Drawing.Size(282, 31);
            this.dt_NS.TabIndex = 3;
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
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_value.Location = new System.Drawing.Point(362, 50);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(69, 25);
            this.lbl_value.TabIndex = 1;
            this.lbl_value.Text = "Giá trị";
            // 
            // com_Truong
            // 
            this.com_Truong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_Truong.FormattingEnabled = true;
            this.com_Truong.Items.AddRange(new object[] {
            "Nam_Sinh"});
            this.com_Truong.Location = new System.Drawing.Point(53, 79);
            this.com_Truong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.com_Truong.Name = "com_Truong";
            this.com_Truong.Size = new System.Drawing.Size(216, 34);
            this.com_Truong.TabIndex = 2;
            this.com_Truong.SelectedIndexChanged += new System.EventHandler(this.com_truong_SelectedIndexChanged);
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(366, 79);
            this.comGT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(216, 34);
            this.comGT.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_filter);
            this.groupBox1.Controls.Add(this.comGT);
            this.groupBox1.Controls.Add(this.com_Truong);
            this.groupBox1.Controls.Add(this.lbl_value);
            this.groupBox1.Controls.Add(this.lbl_field);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(1141, 704);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 215);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            this.groupBox1.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Lavender;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.ImageKey = "loading-arrow.png";
            this.btn_reset.ImageList = this.imageList1;
            this.btn_reset.Location = new System.Drawing.Point(307, 143);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 47);
            this.btn_reset.TabIndex = 38;
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
            this.btn_filter.Location = new System.Drawing.Point(452, 143);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_filter.Size = new System.Drawing.Size(130, 47);
            this.btn_filter.TabIndex = 6;
            this.btn_filter.Text = "Lọc    ";
            this.btn_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // lbl_NS
            // 
            this.lbl_NS.AutoSize = true;
            this.lbl_NS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_NS.Location = new System.Drawing.Point(91, 229);
            this.lbl_NS.Name = "lbl_NS";
            this.lbl_NS.Size = new System.Drawing.Size(108, 25);
            this.lbl_NS.TabIndex = 6;
            this.lbl_NS.Text = "Năm sinh:";
            // 
            // lbl_TenTG
            // 
            this.lbl_TenTG.AutoSize = true;
            this.lbl_TenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenTG.Location = new System.Drawing.Point(91, 153);
            this.lbl_TenTG.Name = "lbl_TenTG";
            this.lbl_TenTG.Size = new System.Drawing.Size(131, 25);
            this.lbl_TenTG.TabIndex = 5;
            this.lbl_TenTG.Text = "Tên tác giả: ";
            // 
            // lbl_MaTG
            // 
            this.lbl_MaTG.AutoSize = true;
            this.lbl_MaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaTG.Location = new System.Drawing.Point(91, 69);
            this.lbl_MaTG.Name = "lbl_MaTG";
            this.lbl_MaTG.Size = new System.Drawing.Size(124, 25);
            this.lbl_MaTG.TabIndex = 4;
            this.lbl_MaTG.Text = "Mã tác giả: ";
            // 
            // txt_TenTG
            // 
            this.txt_TenTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTG.Location = new System.Drawing.Point(228, 148);
            this.txt_TenTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenTG.Name = "txt_TenTG";
            this.txt_TenTG.Size = new System.Drawing.Size(285, 31);
            this.txt_TenTG.TabIndex = 2;
            // 
            // txt_MaTG
            // 
            this.txt_MaTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTG.Location = new System.Drawing.Point(231, 63);
            this.txt_MaTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaTG.Name = "txt_MaTG";
            this.txt_MaTG.Size = new System.Drawing.Size(282, 31);
            this.txt_MaTG.TabIndex = 1;
            // 
            // Nam_Sinh
            // 
            this.Nam_Sinh.DataPropertyName = "Nam_Sinh";
            this.Nam_Sinh.HeaderText = "Năm sinh";
            this.Nam_Sinh.MinimumWidth = 6;
            this.Nam_Sinh.Name = "Nam_Sinh";
            this.Nam_Sinh.ReadOnly = true;
            this.Nam_Sinh.Width = 150;
            // 
            // Ten_Tac_Gia
            // 
            this.Ten_Tac_Gia.DataPropertyName = "Ten_Tac_Gia";
            this.Ten_Tac_Gia.HeaderText = "Tên tác giả";
            this.Ten_Tac_Gia.MinimumWidth = 6;
            this.Ten_Tac_Gia.Name = "Ten_Tac_Gia";
            this.Ten_Tac_Gia.ReadOnly = true;
            this.Ten_Tac_Gia.Width = 150;
            // 
            // Ma_Tac_Gia
            // 
            this.Ma_Tac_Gia.DataPropertyName = "Ma_Tac_Gia";
            this.Ma_Tac_Gia.HeaderText = "Mã tác giả";
            this.Ma_Tac_Gia.MinimumWidth = 6;
            this.Ma_Tac_Gia.Name = "Ma_Tac_Gia";
            this.Ma_Tac_Gia.ReadOnly = true;
            this.Ma_Tac_Gia.Width = 150;
            // 
            // grbNhapTG
            // 
            this.grbNhapTG.Controls.Add(this.btn_Them);
            this.grbNhapTG.Controls.Add(this.dt_NS);
            this.grbNhapTG.Controls.Add(this.btn_Sua);
            this.grbNhapTG.Controls.Add(this.btn_Xoa);
            this.grbNhapTG.Controls.Add(this.lbl_NS);
            this.grbNhapTG.Controls.Add(this.btn_clear);
            this.grbNhapTG.Controls.Add(this.lbl_TenTG);
            this.grbNhapTG.Controls.Add(this.txt_TenTG);
            this.grbNhapTG.Controls.Add(this.lbl_MaTG);
            this.grbNhapTG.Controls.Add(this.txt_MaTG);
            this.grbNhapTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapTG.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbNhapTG.Location = new System.Drawing.Point(1141, 202);
            this.grbNhapTG.Name = "grbNhapTG";
            this.grbNhapTG.Size = new System.Drawing.Size(635, 392);
            this.grbNhapTG.TabIndex = 19;
            this.grbNhapTG.TabStop = false;
            this.grbNhapTG.Text = "Thông tin tác giả";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImageKey = "save.png";
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(455, 316);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(127, 47);
            this.btn_Them.TabIndex = 41;
            this.btn_Them.Text = "Thêm   ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImageKey = "edit.png";
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(322, 316);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(127, 47);
            this.btn_Sua.TabIndex = 40;
            this.btn_Sua.Text = "Sửa    ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImageKey = "trash.png";
            this.btn_Xoa.ImageList = this.imageList1;
            this.btn_Xoa.Location = new System.Drawing.Point(189, 316);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(127, 47);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "Xóa   ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.ImageKey = "loading-arrow.png";
            this.btn_clear.ImageList = this.imageList1;
            this.btn_clear.Location = new System.Drawing.Point(56, 316);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 47);
            this.btn_clear.TabIndex = 38;
            this.btn_clear.Text = "Clear ";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // grbDSTG
            // 
            this.grbDSTG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDSTG.Controls.Add(this.dgv_TG);
            this.grbDSTG.Controls.Add(this.btn_next);
            this.grbDSTG.Controls.Add(this.btn_prev);
            this.grbDSTG.Controls.Add(this.btn_first);
            this.grbDSTG.Controls.Add(this.btn_last);
            this.grbDSTG.Controls.Add(this.btn_search);
            this.grbDSTG.Location = new System.Drawing.Point(132, 60);
            this.grbDSTG.Name = "grbDSTG";
            this.grbDSTG.Size = new System.Drawing.Size(951, 872);
            this.grbDSTG.TabIndex = 20;
            this.grbDSTG.TabStop = false;
            this.grbDSTG.Text = "grbDSTG";
            // 
            // lblttTG
            // 
            this.lblttTG.AutoSize = true;
            this.lblttTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttTG.Location = new System.Drawing.Point(370, 9);
            this.lblttTG.Name = "lblttTG";
            this.lblttTG.Size = new System.Drawing.Size(218, 29);
            this.lblttTG.TabIndex = 13;
            this.lblttTG.Text = "Danh sách tác giả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblttTG);
            this.panel1.Location = new System.Drawing.Point(132, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 48);
            this.panel1.TabIndex = 28;
            // 
            // frmTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDSTG);
            this.Controls.Add(this.grbNhapTG);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTG";
            this.Text = "frmTG";
            this.Load += new System.EventHandler(this.frmTG_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTG_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbNhapTG.ResumeLayout(false);
            this.grbNhapTG.PerformLayout();
            this.grbDSTG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_TG;
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DateTimePicker dt_NS;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.ComboBox com_Truong;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_NS;
        private System.Windows.Forms.Label lbl_TenTG;
        private System.Windows.Forms.Label lbl_MaTG;
        private System.Windows.Forms.TextBox txt_TenTG;
        private System.Windows.Forms.TextBox txt_MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Tac_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tac_Gia;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.GroupBox grbNhapTG;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.GroupBox grbDSTG;
        private System.Windows.Forms.Label lblttTG;
        private System.Windows.Forms.Panel panel1;
    }
}