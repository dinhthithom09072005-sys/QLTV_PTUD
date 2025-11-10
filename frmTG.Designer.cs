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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.dgv_TG = new System.Windows.Forms.DataGridView();
            this.txt_MaTG = new System.Windows.Forms.TextBox();
            this.txt_TenTG = new System.Windows.Forms.TextBox();
            this.lbl_MaTG = new System.Windows.Forms.Label();
            this.lbl_TenTG = new System.Windows.Forms.Label();
            this.lbl_NS = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.com_Truong = new System.Windows.Forms.ComboBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.lbl_field = new System.Windows.Forms.Label();
            this.dt_NS = new System.Windows.Forms.DateTimePicker();
            this.Ma_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Tac_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.btn_search);
            this.groupControl1.Controls.Add(this.btn_last);
            this.groupControl1.Controls.Add(this.btn_next);
            this.groupControl1.Controls.Add(this.btn_prev);
            this.groupControl1.Controls.Add(this.btn_first);
            this.groupControl1.Controls.Add(this.dgv_TG);
            this.groupControl1.Location = new System.Drawing.Point(28, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1230, 833);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách tác giả";
            // 
            // btn_search
            // 
            this.btn_search.EditValue = "";
            this.btn_search.Location = new System.Drawing.Point(50, 85);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Appearance.Options.UseForeColor = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(264, 26);
            this.btn_search.TabIndex = 23;
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.DimGray;
            this.btn_last.Location = new System.Drawing.Point(317, 757);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(52, 39);
            this.btn_last.TabIndex = 22;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DimGray;
            this.btn_next.Location = new System.Drawing.Point(236, 757);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 39);
            this.btn_next.TabIndex = 21;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.Color.DimGray;
            this.btn_prev.Location = new System.Drawing.Point(125, 757);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(52, 39);
            this.btn_prev.TabIndex = 20;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.DimGray;
            this.btn_first.Location = new System.Drawing.Point(48, 757);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(52, 39);
            this.btn_first.TabIndex = 19;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // dgv_TG
            // 
            this.dgv_TG.AllowUserToAddRows = false;
            this.dgv_TG.AllowUserToDeleteRows = false;
            this.dgv_TG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Tac_Gia,
            this.Ten_Tac_Gia,
            this.Nam_Sinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TG.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TG.Location = new System.Drawing.Point(50, 134);
            this.dgv_TG.Name = "dgv_TG";
            this.dgv_TG.ReadOnly = true;
            this.dgv_TG.RowHeadersWidth = 51;
            this.dgv_TG.RowTemplate.Height = 24;
            this.dgv_TG.Size = new System.Drawing.Size(1135, 596);
            this.dgv_TG.TabIndex = 0;
            this.dgv_TG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TG_CellClick);
            this.dgv_TG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TG_CellContentClick);
            // 
            // txt_MaTG
            // 
            this.txt_MaTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTG.Location = new System.Drawing.Point(1466, 261);
            this.txt_MaTG.Name = "txt_MaTG";
            this.txt_MaTG.Size = new System.Drawing.Size(271, 27);
            this.txt_MaTG.TabIndex = 1;
            // 
            // txt_TenTG
            // 
            this.txt_TenTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTG.Location = new System.Drawing.Point(1463, 329);
            this.txt_TenTG.Name = "txt_TenTG";
            this.txt_TenTG.Size = new System.Drawing.Size(271, 27);
            this.txt_TenTG.TabIndex = 2;
            // 
            // lbl_MaTG
            // 
            this.lbl_MaTG.AutoSize = true;
            this.lbl_MaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTG.Location = new System.Drawing.Point(1346, 268);
            this.lbl_MaTG.Name = "lbl_MaTG";
            this.lbl_MaTG.Size = new System.Drawing.Size(97, 20);
            this.lbl_MaTG.TabIndex = 4;
            this.lbl_MaTG.Text = "Mã tác giả: ";
            // 
            // lbl_TenTG
            // 
            this.lbl_TenTG.AutoSize = true;
            this.lbl_TenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTG.Location = new System.Drawing.Point(1341, 333);
            this.lbl_TenTG.Name = "lbl_TenTG";
            this.lbl_TenTG.Size = new System.Drawing.Size(102, 20);
            this.lbl_TenTG.TabIndex = 5;
            this.lbl_TenTG.Text = "Tên tác giả: ";
            // 
            // lbl_NS
            // 
            this.lbl_NS.AutoSize = true;
            this.lbl_NS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NS.Location = new System.Drawing.Point(1346, 396);
            this.lbl_NS.Name = "lbl_NS";
            this.lbl_NS.Size = new System.Drawing.Size(85, 20);
            this.lbl_NS.TabIndex = 6;
            this.lbl_NS.Text = "Năm sinh:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Firebrick;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1775, 491);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 41);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1775, 410);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 41);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1775, 332);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 41);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1775, 254);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 41);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(1311, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 172);
            this.groupBox1.TabIndex = 18;
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
            // com_Truong
            // 
            this.com_Truong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_Truong.FormattingEnabled = true;
            this.com_Truong.Items.AddRange(new object[] {
            "Nam_Sinh"});
            this.com_Truong.Location = new System.Drawing.Point(47, 63);
            this.com_Truong.Name = "com_Truong";
            this.com_Truong.Size = new System.Drawing.Size(192, 30);
            this.com_Truong.TabIndex = 2;
            this.com_Truong.SelectedIndexChanged += new System.EventHandler(this.com_truong_SelectedIndexChanged);
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
            // dt_NS
            // 
            this.dt_NS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NS.Location = new System.Drawing.Point(1466, 394);
            this.dt_NS.Name = "dt_NS";
            this.dt_NS.Size = new System.Drawing.Size(271, 27);
            this.dt_NS.TabIndex = 3;
            // 
            // Ma_Tac_Gia
            // 
            this.Ma_Tac_Gia.DataPropertyName = "Ma_Tac_Gia";
            this.Ma_Tac_Gia.HeaderText = "Mã tác giả";
            this.Ma_Tac_Gia.MinimumWidth = 6;
            this.Ma_Tac_Gia.Name = "Ma_Tac_Gia";
            this.Ma_Tac_Gia.ReadOnly = true;
            // 
            // Ten_Tac_Gia
            // 
            this.Ten_Tac_Gia.DataPropertyName = "Ten_Tac_Gia";
            this.Ten_Tac_Gia.HeaderText = "Tên tác giả";
            this.Ten_Tac_Gia.MinimumWidth = 6;
            this.Ten_Tac_Gia.Name = "Ten_Tac_Gia";
            this.Ten_Tac_Gia.ReadOnly = true;
            // 
            // Nam_Sinh
            // 
            this.Nam_Sinh.DataPropertyName = "Nam_Sinh";
            this.Nam_Sinh.HeaderText = "Năm sinh";
            this.Nam_Sinh.MinimumWidth = 6;
            this.Nam_Sinh.Name = "Nam_Sinh";
            this.Nam_Sinh.ReadOnly = true;
            // 
            // frmTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dt_NS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_NS);
            this.Controls.Add(this.lbl_TenTG);
            this.Controls.Add(this.lbl_MaTG);
            this.Controls.Add(this.txt_TenTG);
            this.Controls.Add(this.txt_MaTG);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmTG";
            this.Text = "frmTG";
            this.Load += new System.EventHandler(this.frmTG_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTG_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgv_TG;
        private System.Windows.Forms.TextBox txt_MaTG;
        private System.Windows.Forms.TextBox txt_TenTG;
        private System.Windows.Forms.Label lbl_MaTG;
        private System.Windows.Forms.Label lbl_TenTG;
        private System.Windows.Forms.Label lbl_NS;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox com_Truong;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_field;
        private System.Windows.Forms.DateTimePicker dt_NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Tac_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Tac_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam_Sinh;
    }
}