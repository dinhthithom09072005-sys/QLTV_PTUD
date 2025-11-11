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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_DMDG = new DevExpress.XtraEditors.GroupControl();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.dgv_DMDG = new System.Windows.Forms.DataGridView();
            this.grb_ThemDG = new DevExpress.XtraEditors.GroupControl();
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dt_Ngaycap = new System.Windows.Forms.DateTimePicker();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.com_truong = new System.Windows.Forms.ComboBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_field = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grb_DMDG)).BeginInit();
            this.grb_DMDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_ThemDG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DMDG
            // 
            this.grb_DMDG.Appearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_DMDG.Appearance.Options.UseBorderColor = true;
            this.grb_DMDG.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DMDG.AppearanceCaption.Options.UseFont = true;
            this.grb_DMDG.Controls.Add(this.btn_print);
            this.grb_DMDG.Controls.Add(this.btn_last);
            this.grb_DMDG.Controls.Add(this.btn_next);
            this.grb_DMDG.Controls.Add(this.btn_prev);
            this.grb_DMDG.Controls.Add(this.btn_first);
            this.grb_DMDG.Controls.Add(this.btn_search);
            this.grb_DMDG.Controls.Add(this.dgv_DMDG);
            this.grb_DMDG.Controls.Add(this.grb_ThemDG);
            this.grb_DMDG.Location = new System.Drawing.Point(28, 50);
            this.grb_DMDG.Margin = new System.Windows.Forms.Padding(4);
            this.grb_DMDG.Name = "grb_DMDG";
            this.grb_DMDG.Size = new System.Drawing.Size(1283, 833);
            this.grb_DMDG.TabIndex = 15;
            this.grb_DMDG.Text = "Danh sách độc giả";
            this.grb_DMDG.Paint += new System.Windows.Forms.PaintEventHandler(this.grb_DMDG_Paint);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.DimGray;
            this.btn_last.Location = new System.Drawing.Point(319, 765);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(52, 39);
            this.btn_last.TabIndex = 18;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DimGray;
            this.btn_next.Location = new System.Drawing.Point(238, 765);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 39);
            this.btn_next.TabIndex = 17;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.Color.DimGray;
            this.btn_prev.Location = new System.Drawing.Point(127, 765);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(52, 39);
            this.btn_prev.TabIndex = 16;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.DimGray;
            this.btn_first.Location = new System.Drawing.Point(50, 765);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(52, 39);
            this.btn_first.TabIndex = 15;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_search
            // 
            this.btn_search.EditValue = "";
            this.btn_search.Location = new System.Drawing.Point(50, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Appearance.Options.UseForeColor = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(264, 26);
            this.btn_search.TabIndex = 2;
            this.btn_search.SelectedIndexChanged += new System.EventHandler(this.btn_search_SelectedIndexChanged);
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // dgv_DMDG
            // 
            this.dgv_DMDG.AllowUserToAddRows = false;
            this.dgv_DMDG.AllowUserToDeleteRows = false;
            this.dgv_DMDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DMDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DMDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DMDG.Location = new System.Drawing.Point(50, 134);
            this.dgv_DMDG.Name = "dgv_DMDG";
            this.dgv_DMDG.ReadOnly = true;
            this.dgv_DMDG.RowHeadersWidth = 51;
            this.dgv_DMDG.RowTemplate.Height = 24;
            this.dgv_DMDG.Size = new System.Drawing.Size(1196, 596);
            this.dgv_DMDG.TabIndex = 0;
            this.dgv_DMDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMDG_CellClick);
            this.dgv_DMDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMDG_CellContentClick);
            // 
            // grb_ThemDG
            // 
            this.grb_ThemDG.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grb_ThemDG.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.grb_ThemDG.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThemDG.Appearance.Options.UseBackColor = true;
            this.grb_ThemDG.Appearance.Options.UseBorderColor = true;
            this.grb_ThemDG.Appearance.Options.UseFont = true;
            this.grb_ThemDG.Location = new System.Drawing.Point(1282, 0);
            this.grb_ThemDG.Margin = new System.Windows.Forms.Padding(6);
            this.grb_ThemDG.Name = "grb_ThemDG";
            this.grb_ThemDG.Size = new System.Drawing.Size(616, 97);
            this.grb_ThemDG.TabIndex = 14;
            this.grb_ThemDG.Text = "Lọc dữ liệu";
            this.grb_ThemDG.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lbl_Makhoa
            // 
            this.lbl_Makhoa.AutoSize = true;
            this.lbl_Makhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Makhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Makhoa.Location = new System.Drawing.Point(1379, 470);
            this.lbl_Makhoa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Makhoa.Name = "lbl_Makhoa";
            this.lbl_Makhoa.Size = new System.Drawing.Size(112, 20);
            this.lbl_Makhoa.TabIndex = 4;
            this.lbl_Makhoa.Text = "Mã khoa viện:";
            // 
            // lbl_Ngaycap
            // 
            this.lbl_Ngaycap.AutoSize = true;
            this.lbl_Ngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaycap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Ngaycap.Location = new System.Drawing.Point(1374, 323);
            this.lbl_Ngaycap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Ngaycap.Name = "lbl_Ngaycap";
            this.lbl_Ngaycap.Size = new System.Drawing.Size(117, 20);
            this.lbl_Ngaycap.TabIndex = 3;
            this.lbl_Ngaycap.Text = "Ngày câp thẻ: ";
            // 
            // lbl_Malop
            // 
            this.lbl_Malop.AutoSize = true;
            this.lbl_Malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Malop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Malop.Location = new System.Drawing.Point(1427, 421);
            this.lbl_Malop.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Malop.Name = "lbl_Malop";
            this.lbl_Malop.Size = new System.Drawing.Size(64, 20);
            this.lbl_Malop.TabIndex = 5;
            this.lbl_Malop.Text = "Mã lớp:";
            // 
            // lbl_Hoten
            // 
            this.lbl_Hoten.AutoSize = true;
            this.lbl_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Hoten.Location = new System.Drawing.Point(1422, 372);
            this.lbl_Hoten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Hoten.Name = "lbl_Hoten";
            this.lbl_Hoten.Size = new System.Drawing.Size(69, 20);
            this.lbl_Hoten.TabIndex = 2;
            this.lbl_Hoten.Text = "Họ tên: ";
            // 
            // txt_Malop
            // 
            this.txt_Malop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Malop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Malop.Location = new System.Drawing.Point(1515, 420);
            this.txt_Malop.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Malop.Name = "txt_Malop";
            this.txt_Malop.Size = new System.Drawing.Size(297, 27);
            this.txt_Malop.TabIndex = 4;
            this.txt_Malop.TextChanged += new System.EventHandler(this.txt_Malop_TextChanged);
            // 
            // txt_ST
            // 
            this.txt_ST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ST.Location = new System.Drawing.Point(1515, 267);
            this.txt_ST.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ST.Name = "txt_ST";
            this.txt_ST.Size = new System.Drawing.Size(297, 27);
            this.txt_ST.TabIndex = 1;
            this.txt_ST.TextChanged += new System.EventHandler(this.txt_ST_TextChanged);
            // 
            // lbl_ST
            // 
            this.lbl_ST.AutoSize = true;
            this.lbl_ST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ST.Location = new System.Drawing.Point(1370, 274);
            this.lbl_ST.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ST.Name = "lbl_ST";
            this.lbl_ST.Size = new System.Drawing.Size(121, 20);
            this.lbl_ST.TabIndex = 0;
            this.lbl_ST.Text = "Số thẻ độc giả:";
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hoten.Location = new System.Drawing.Point(1515, 369);
            this.txt_Hoten.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(297, 27);
            this.txt_Hoten.TabIndex = 3;
            this.txt_Hoten.TextChanged += new System.EventHandler(this.txt_Hoten_TextChanged);
            // 
            // txt_Makhoa
            // 
            this.txt_Makhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Makhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Makhoa.Location = new System.Drawing.Point(1515, 471);
            this.txt_Makhoa.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Makhoa.Name = "txt_Makhoa";
            this.txt_Makhoa.Size = new System.Drawing.Size(297, 27);
            this.txt_Makhoa.TabIndex = 5;
            // 
            // txt_Nghenghiep
            // 
            this.txt_Nghenghiep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nghenghiep.Location = new System.Drawing.Point(1515, 522);
            this.txt_Nghenghiep.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Nghenghiep.Name = "txt_Nghenghiep";
            this.txt_Nghenghiep.Size = new System.Drawing.Size(297, 27);
            this.txt_Nghenghiep.TabIndex = 6;
            // 
            // lbl_Nghenghiep
            // 
            this.lbl_Nghenghiep.AutoSize = true;
            this.lbl_Nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nghenghiep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Nghenghiep.Location = new System.Drawing.Point(1384, 529);
            this.lbl_Nghenghiep.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Nghenghiep.Name = "lbl_Nghenghiep";
            this.lbl_Nghenghiep.Size = new System.Drawing.Size(107, 20);
            this.lbl_Nghenghiep.TabIndex = 11;
            this.lbl_Nghenghiep.Text = "Nghề nghiệp:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Location = new System.Drawing.Point(1840, 512);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(120, 41);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dt_Ngaycap
            // 
            this.dt_Ngaycap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ngaycap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Ngaycap.Location = new System.Drawing.Point(1515, 318);
            this.dt_Ngaycap.Margin = new System.Windows.Forms.Padding(5);
            this.dt_Ngaycap.Name = "dt_Ngaycap";
            this.dt_Ngaycap.Size = new System.Drawing.Size(297, 27);
            this.dt_Ngaycap.TabIndex = 2;
            this.dt_Ngaycap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Them.Location = new System.Drawing.Point(1840, 257);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 41);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Sua.Location = new System.Drawing.Point(1840, 342);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 41);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Location = new System.Drawing.Point(1840, 427);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 41);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_filter);
            this.groupBox1.Controls.Add(this.comGT);
            this.groupBox1.Controls.Add(this.com_truong);
            this.groupBox1.Controls.Add(this.lbl_value);
            this.groupBox1.Controls.Add(this.lbl_field);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(1344, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_reset.Location = new System.Drawing.Point(420, 112);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 35);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Đặt lại";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_filter.Location = new System.Drawing.Point(89, 112);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(103, 35);
            this.btn_filter.TabIndex = 0;
            this.btn_filter.Text = "Lọc";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(372, 63);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(192, 30);
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
            this.com_truong.Location = new System.Drawing.Point(47, 63);
            this.com_truong.Name = "com_truong";
            this.com_truong.Size = new System.Drawing.Size(192, 30);
            this.com_truong.TabIndex = 2;
            this.com_truong.SelectedIndexChanged += new System.EventHandler(this.com_truong_SelectedIndexChanged);
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_value.Location = new System.Drawing.Point(368, 40);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(55, 20);
            this.lbl_value.TabIndex = 1;
            this.lbl_value.Text = "Giá trị";
            // 
            // lbl_field
            // 
            this.lbl_field.AutoSize = true;
            this.lbl_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_field.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_field.Location = new System.Drawing.Point(43, 40);
            this.lbl_field.Name = "lbl_field";
            this.lbl_field.Size = new System.Drawing.Size(61, 20);
            this.lbl_field.TabIndex = 0;
            this.lbl_field.Text = "Trường";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(1129, 764);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(117, 40);
            this.btn_print.TabIndex = 17;
            this.btn_print.Text = "In báo cáo";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // frmDMDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_DMDG);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Makhoa);
            this.Controls.Add(this.dt_Ngaycap);
            this.Controls.Add(this.lbl_Makhoa);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Ngaycap);
            this.Controls.Add(this.lbl_Nghenghiep);
            this.Controls.Add(this.lbl_Malop);
            this.Controls.Add(this.txt_Nghenghiep);
            this.Controls.Add(this.lbl_Hoten);
            this.Controls.Add(this.txt_Malop);
            this.Controls.Add(this.txt_Hoten);
            this.Controls.Add(this.txt_ST);
            this.Controls.Add(this.lbl_ST);
            this.Name = "frmDMDG";
            this.Text = "frmDMDG";
            this.Load += new System.EventHandler(this.frmDMDGcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grb_DMDG)).EndInit();
            this.grb_DMDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grb_ThemDG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grb_DMDG;
        private System.Windows.Forms.DataGridView dgv_DMDG;
        private DevExpress.XtraEditors.SearchControl btn_search;
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
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DateTimePicker dt_Ngaycap;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private DevExpress.XtraEditors.GroupControl grb_ThemDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox com_truong;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_print;
    }
}