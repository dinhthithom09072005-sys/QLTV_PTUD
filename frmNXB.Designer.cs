namespace PTUD_QLTV
{
    partial class frmNXB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNXB));
            this.btn_prv = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.dgv_NXB = new System.Windows.Forms.DataGridView();
            this.Ma_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.btn_next = new System.Windows.Forms.Button();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNXB = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaNXB = new DevExpress.XtraEditors.TextEdit();
            this.lbl_TenNXB = new System.Windows.Forms.Label();
            this.lbl_E = new System.Windows.Forms.Label();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.grbNhapNXB = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.grbDSNXB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblttPP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).BeginInit();
            this.grbNhapNXB.SuspendLayout();
            this.grbDSNXB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_prv
            // 
            this.btn_prv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_prv.Location = new System.Drawing.Point(405, 721);
            this.btn_prv.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_prv.Name = "btn_prv";
            this.btn_prv.Size = new System.Drawing.Size(64, 43);
            this.btn_prv.TabIndex = 21;
            this.btn_prv.Text = "<";
            this.btn_prv.UseVisualStyleBackColor = true;
            this.btn_prv.Click += new System.EventHandler(this.btn_prv_Click);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_first.Location = new System.Drawing.Point(329, 721);
            this.btn_first.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(64, 43);
            this.btn_first.TabIndex = 20;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_last.Location = new System.Drawing.Point(578, 721);
            this.btn_last.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(64, 43);
            this.btn_last.TabIndex = 23;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // dgv_NXB
            // 
            this.dgv_NXB.AllowUserToAddRows = false;
            this.dgv_NXB.AllowUserToDeleteRows = false;
            this.dgv_NXB.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_NXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NXB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_NXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NXB,
            this.Ten_NXB,
            this.email});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NXB.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_NXB.Location = new System.Drawing.Point(68, 132);
            this.dgv_NXB.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.dgv_NXB.Name = "dgv_NXB";
            this.dgv_NXB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NXB.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_NXB.RowHeadersWidth = 51;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NXB.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_NXB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_NXB.RowTemplate.Height = 24;
            this.dgv_NXB.Size = new System.Drawing.Size(816, 571);
            this.dgv_NXB.TabIndex = 3;
            this.dgv_NXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NXB_CellClick);
            this.dgv_NXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NXB_CellContentClick);
            // 
            // Ma_NXB
            // 
            this.Ma_NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_NXB.DataPropertyName = "Ma_NXB";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ma_NXB.DefaultCellStyle = dataGridViewCellStyle11;
            this.Ma_NXB.FillWeight = 68.18183F;
            this.Ma_NXB.HeaderText = "Mã NXB";
            this.Ma_NXB.MinimumWidth = 6;
            this.Ma_NXB.Name = "Ma_NXB";
            // 
            // Ten_NXB
            // 
            this.Ten_NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_NXB.DataPropertyName = "Ten_NXB";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Ten_NXB.DefaultCellStyle = dataGridViewCellStyle12;
            this.Ten_NXB.FillWeight = 115.9091F;
            this.Ten_NXB.HeaderText = "Tên nhà xuất bản";
            this.Ten_NXB.MinimumWidth = 6;
            this.Ten_NXB.Name = "Ten_NXB";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.email.DefaultCellStyle = dataGridViewCellStyle13;
            this.email.FillWeight = 115.9091F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(68, 63);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(288, 32);
            this.btn_search.TabIndex = 2;
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_next.Location = new System.Drawing.Point(504, 721);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(64, 43);
            this.btn_next.TabIndex = 22;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(157, 228);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Size = new System.Drawing.Size(307, 32);
            this.txt_email.TabIndex = 5;
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Location = new System.Drawing.Point(157, 148);
            this.txt_TenNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNXB.Size = new System.Drawing.Size(307, 32);
            this.txt_TenNXB.TabIndex = 4;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Location = new System.Drawing.Point(157, 64);
            this.txt_MaNXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNXB.Size = new System.Drawing.Size(307, 32);
            this.txt_MaNXB.TabIndex = 3;
            // 
            // lbl_TenNXB
            // 
            this.lbl_TenNXB.AutoSize = true;
            this.lbl_TenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNXB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenNXB.Location = new System.Drawing.Point(40, 155);
            this.lbl_TenNXB.Name = "lbl_TenNXB";
            this.lbl_TenNXB.Size = new System.Drawing.Size(99, 25);
            this.lbl_TenNXB.TabIndex = 2;
            this.lbl_TenNXB.Text = "Tên NXB:";
            // 
            // lbl_E
            // 
            this.lbl_E.AutoSize = true;
            this.lbl_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_E.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_E.Location = new System.Drawing.Point(40, 235);
            this.lbl_E.Name = "lbl_E";
            this.lbl_E.Size = new System.Drawing.Size(66, 25);
            this.lbl_E.TabIndex = 1;
            this.lbl_E.Text = "Email:";
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNXB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaNXB.Location = new System.Drawing.Point(40, 68);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(92, 25);
            this.lbl_MaNXB.TabIndex = 0;
            this.lbl_MaNXB.Text = "Mã NXB:";
            // 
            // grbNhapNXB
            // 
            this.grbNhapNXB.Controls.Add(this.btn_Them);
            this.grbNhapNXB.Controls.Add(this.btn_Sua);
            this.grbNhapNXB.Controls.Add(this.btn_Xoa);
            this.grbNhapNXB.Controls.Add(this.btn_Clear);
            this.grbNhapNXB.Controls.Add(this.txt_TenNXB);
            this.grbNhapNXB.Controls.Add(this.lbl_MaNXB);
            this.grbNhapNXB.Controls.Add(this.lbl_E);
            this.grbNhapNXB.Controls.Add(this.lbl_TenNXB);
            this.grbNhapNXB.Controls.Add(this.txt_email);
            this.grbNhapNXB.Controls.Add(this.txt_MaNXB);
            this.grbNhapNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapNXB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbNhapNXB.Location = new System.Drawing.Point(1173, 197);
            this.grbNhapNXB.Name = "grbNhapNXB";
            this.grbNhapNXB.Size = new System.Drawing.Size(562, 384);
            this.grbNhapNXB.TabIndex = 14;
            this.grbNhapNXB.TabStop = false;
            this.grbNhapNXB.Text = "Thông tin nhà xuất bản";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.ImageKey = "save.png";
            this.btn_Them.ImageList = this.imageList1;
            this.btn_Them.Location = new System.Drawing.Point(419, 317);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(127, 47);
            this.btn_Them.TabIndex = 41;
            this.btn_Them.Text = "Thêm   ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.ImageKey = "edit.png";
            this.btn_Sua.ImageList = this.imageList1;
            this.btn_Sua.Location = new System.Drawing.Point(286, 317);
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
            this.btn_Xoa.Location = new System.Drawing.Point(153, 317);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(127, 47);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "Xóa   ";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.ImageKey = "loading-arrow.png";
            this.btn_Clear.ImageList = this.imageList1;
            this.btn_Clear.Location = new System.Drawing.Point(20, 317);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 47);
            this.btn_Clear.TabIndex = 38;
            this.btn_Clear.Text = "Clear ";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // grbDSNXB
            // 
            this.grbDSNXB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDSNXB.Controls.Add(this.btn_search);
            this.grbDSNXB.Controls.Add(this.btn_next);
            this.grbDSNXB.Controls.Add(this.btn_prv);
            this.grbDSNXB.Controls.Add(this.btn_first);
            this.grbDSNXB.Controls.Add(this.btn_last);
            this.grbDSNXB.Controls.Add(this.dgv_NXB);
            this.grbDSNXB.Location = new System.Drawing.Point(145, 94);
            this.grbDSNXB.Name = "grbDSNXB";
            this.grbDSNXB.Size = new System.Drawing.Size(951, 798);
            this.grbDSNXB.TabIndex = 15;
            this.grbDSNXB.TabStop = false;
            this.grbDSNXB.Text = "grbDSNXB";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblttPP);
            this.panel1.Location = new System.Drawing.Point(145, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 48);
            this.panel1.TabIndex = 24;
            // 
            // lblttPP
            // 
            this.lblttPP.AutoSize = true;
            this.lblttPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttPP.Location = new System.Drawing.Point(355, 9);
            this.lblttPP.Name = "lblttPP";
            this.lblttPP.Size = new System.Drawing.Size(287, 29);
            this.lblttPP.TabIndex = 13;
            this.lblttPP.Text = "Danh sách nhà xuất bản";
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDSNXB);
            this.Controls.Add(this.grbNhapNXB);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNXB";
            this.Text = "frmNXB";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).EndInit();
            this.grbNhapNXB.ResumeLayout(false);
            this.grbNhapNXB.PerformLayout();
            this.grbDSNXB.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridView dgv_NXB;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.Label lbl_TenNXB;
        private System.Windows.Forms.Label lbl_E;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.TextEdit txt_TenNXB;
        private DevExpress.XtraEditors.TextEdit txt_MaNXB;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prv;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.GroupBox grbNhapNXB;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.GroupBox grbDSNXB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblttPP;
    }
}