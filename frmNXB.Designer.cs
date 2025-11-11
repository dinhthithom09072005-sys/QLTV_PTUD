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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_NXB = new DevExpress.XtraEditors.GroupControl();
            this.btn_last = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_NXB = new System.Windows.Forms.DataGridView();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prv = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.btn_first = new DevExpress.XtraEditors.SimpleButton();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNXB = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaNXB = new DevExpress.XtraEditors.TextEdit();
            this.lbl_TenNXB = new System.Windows.Forms.Label();
            this.lbl_E = new System.Windows.Forms.Label();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.Ma_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grb_NXB)).BeginInit();
            this.grb_NXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NXB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_NXB
            // 
            this.grb_NXB.Appearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_NXB.Appearance.Options.UseBorderColor = true;
            this.grb_NXB.Controls.Add(this.btn_last);
            this.grb_NXB.Controls.Add(this.dgv_NXB);
            this.grb_NXB.Controls.Add(this.btn_next);
            this.grb_NXB.Controls.Add(this.btn_prv);
            this.grb_NXB.Controls.Add(this.btn_search);
            this.grb_NXB.Controls.Add(this.btn_first);
            this.grb_NXB.Location = new System.Drawing.Point(28, 50);
            this.grb_NXB.Name = "grb_NXB";
            this.grb_NXB.Size = new System.Drawing.Size(1183, 827);
            this.grb_NXB.TabIndex = 0;
            this.grb_NXB.Text = "Danh sách NXB";
            // 
            // btn_last
            // 
            this.btn_last.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_last.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btn_last.Appearance.Options.UseBackColor = true;
            this.btn_last.Appearance.Options.UseFont = true;
            this.btn_last.Appearance.Options.UseForeColor = true;
            this.btn_last.Location = new System.Drawing.Point(302, 752);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(52, 39);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // dgv_NXB
            // 
            this.dgv_NXB.AllowUserToAddRows = false;
            this.dgv_NXB.AllowUserToDeleteRows = false;
            this.dgv_NXB.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_NXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NXB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_NXB,
            this.Ten_NXB,
            this.email});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NXB.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_NXB.Location = new System.Drawing.Point(50, 134);
            this.dgv_NXB.Name = "dgv_NXB";
            this.dgv_NXB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NXB.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_NXB.RowHeadersWidth = 51;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_NXB.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_NXB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_NXB.RowTemplate.Height = 24;
            this.dgv_NXB.Size = new System.Drawing.Size(1085, 593);
            this.dgv_NXB.TabIndex = 3;
            this.dgv_NXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NXB_CellClick);
            this.dgv_NXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NXB_CellContentClick);
            // 
            // btn_next
            // 
            this.btn_next.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_next.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btn_next.Appearance.Options.UseBackColor = true;
            this.btn_next.Appearance.Options.UseFont = true;
            this.btn_next.Appearance.Options.UseForeColor = true;
            this.btn_next.Location = new System.Drawing.Point(231, 752);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 39);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prv
            // 
            this.btn_prv.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_prv.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prv.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btn_prv.Appearance.Options.UseBackColor = true;
            this.btn_prv.Appearance.Options.UseFont = true;
            this.btn_prv.Appearance.Options.UseForeColor = true;
            this.btn_prv.Location = new System.Drawing.Point(124, 752);
            this.btn_prv.Name = "btn_prv";
            this.btn_prv.Size = new System.Drawing.Size(52, 39);
            this.btn_prv.TabIndex = 1;
            this.btn_prv.Text = "<";
            this.btn_prv.Click += new System.EventHandler(this.btn_prv_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(50, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(251, 26);
            this.btn_search.TabIndex = 2;
            this.btn_search.SelectedIndexChanged += new System.EventHandler(this.btn_search_SelectedIndexChanged);
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // btn_first
            // 
            this.btn_first.Appearance.BackColor = System.Drawing.Color.White;
            this.btn_first.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.btn_first.Appearance.Options.UseBackColor = true;
            this.btn_first.Appearance.Options.UseFont = true;
            this.btn_first.Appearance.Options.UseForeColor = true;
            this.btn_first.Location = new System.Drawing.Point(52, 752);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(52, 39);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(1481, 391);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Size = new System.Drawing.Size(273, 26);
            this.txt_email.TabIndex = 5;
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Location = new System.Drawing.Point(1481, 327);
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNXB.Size = new System.Drawing.Size(273, 26);
            this.txt_TenNXB.TabIndex = 4;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Location = new System.Drawing.Point(1481, 260);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNXB.Properties.Appearance.Options.UseFont = true;
            this.txt_MaNXB.Size = new System.Drawing.Size(273, 26);
            this.txt_MaNXB.TabIndex = 3;
            // 
            // lbl_TenNXB
            // 
            this.lbl_TenNXB.AutoSize = true;
            this.lbl_TenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNXB.Location = new System.Drawing.Point(1377, 333);
            this.lbl_TenNXB.Name = "lbl_TenNXB";
            this.lbl_TenNXB.Size = new System.Drawing.Size(82, 20);
            this.lbl_TenNXB.TabIndex = 2;
            this.lbl_TenNXB.Text = "Tên NXB:";
            // 
            // lbl_E
            // 
            this.lbl_E.AutoSize = true;
            this.lbl_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_E.Location = new System.Drawing.Point(1377, 397);
            this.lbl_E.Name = "lbl_E";
            this.lbl_E.Size = new System.Drawing.Size(56, 20);
            this.lbl_E.TabIndex = 1;
            this.lbl_E.Text = "Email:";
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNXB.Location = new System.Drawing.Point(1377, 263);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(77, 20);
            this.lbl_MaNXB.TabIndex = 0;
            this.lbl_MaNXB.Text = "Mã NXB:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Firebrick;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1802, 487);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 41);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1802, 409);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 41);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1802, 331);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 41);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1802, 253);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 41);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Ma_NXB
            // 
            this.Ma_NXB.DataPropertyName = "Ma_NXB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ma_NXB.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ma_NXB.FillWeight = 280.7487F;
            this.Ma_NXB.HeaderText = "Mã Nhà Xuất Bản";
            this.Ma_NXB.MinimumWidth = 6;
            this.Ma_NXB.Name = "Ma_NXB";
            this.Ma_NXB.Width = 160;
            // 
            // Ten_NXB
            // 
            this.Ten_NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten_NXB.DataPropertyName = "Ten_NXB";
            this.Ten_NXB.FillWeight = 9.625671F;
            this.Ten_NXB.HeaderText = "Tên Nhà Xuất Bản";
            this.Ten_NXB.MinimumWidth = 6;
            this.Ten_NXB.Name = "Ten_NXB";
            this.Ten_NXB.Width = 300;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.email.DefaultCellStyle = dataGridViewCellStyle4;
            this.email.FillWeight = 9.625671F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 300;
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_TenNXB);
            this.Controls.Add(this.txt_MaNXB);
            this.Controls.Add(this.lbl_TenNXB);
            this.Controls.Add(this.grb_NXB);
            this.Controls.Add(this.lbl_E);
            this.Controls.Add(this.lbl_MaNXB);
            this.Name = "frmNXB";
            this.Text = "frmNXB";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grb_NXB)).EndInit();
            this.grb_NXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NXB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaNXB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grb_NXB;
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridView dgv_NXB;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.Label lbl_TenNXB;
        private System.Windows.Forms.Label lbl_E;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.TextEdit txt_TenNXB;
        private DevExpress.XtraEditors.TextEdit txt_MaNXB;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_prv;
        private DevExpress.XtraEditors.SimpleButton btn_first;
        private DevExpress.XtraEditors.SimpleButton btn_last;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}