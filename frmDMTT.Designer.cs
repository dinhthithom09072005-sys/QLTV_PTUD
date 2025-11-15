namespace PTUD_QLTV
{
    partial class frmDMTT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMTT));
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.dgv_DMTT = new System.Windows.Forms.DataGridView();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenTT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_TenTT = new System.Windows.Forms.Label();
            this.txt_MaTT = new System.Windows.Forms.TextBox();
            this.lbl_MaTT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.grbDSTT = new System.Windows.Forms.GroupBox();
            this.lbltttt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbDSTT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_next.Location = new System.Drawing.Point(524, 731);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(64, 43);
            this.btn_next.TabIndex = 10;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_prev.Location = new System.Drawing.Point(420, 731);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(64, 43);
            this.btn_prev.TabIndex = 9;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_first.Location = new System.Drawing.Point(348, 731);
            this.btn_first.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(64, 43);
            this.btn_first.TabIndex = 8;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_last.Location = new System.Drawing.Point(596, 731);
            this.btn_last.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(64, 43);
            this.btn_last.TabIndex = 11;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click_1);
            // 
            // dgv_DMTT
            // 
            this.dgv_DMTT.AllowUserToAddRows = false;
            this.dgv_DMTT.AllowUserToDeleteRows = false;
            this.dgv_DMTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMTT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMTT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DMTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DMTT.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DMTT.Location = new System.Drawing.Point(59, 144);
            this.dgv_DMTT.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_DMTT.Name = "dgv_DMTT";
            this.dgv_DMTT.ReadOnly = true;
            this.dgv_DMTT.RowHeadersWidth = 51;
            this.dgv_DMTT.RowTemplate.Height = 24;
            this.dgv_DMTT.Size = new System.Drawing.Size(830, 566);
            this.dgv_DMTT.TabIndex = 4;
            this.dgv_DMTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMTT_CellClick);
            this.dgv_DMTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMTT_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.EditValue = "";
            this.btn_search.Location = new System.Drawing.Point(59, 70);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Properties.Appearance.Options.UseFont = true;
            this.btn_search.Properties.Appearance.Options.UseForeColor = true;
            this.btn_search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.btn_search.Size = new System.Drawing.Size(278, 32);
            this.btn_search.TabIndex = 3;
            this.btn_search.SelectedIndexChanged += new System.EventHandler(this.btn_search_SelectedIndexChanged);
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(278, 251);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(294, 31);
            this.txt_SDT.TabIndex = 3;
            // 
            // txt_TenTT
            // 
            this.txt_TenTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTT.Location = new System.Drawing.Point(278, 157);
            this.txt_TenTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenTT.Name = "txt_TenTT";
            this.txt_TenTT.Size = new System.Drawing.Size(294, 31);
            this.txt_TenTT.TabIndex = 2;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_SDT.Location = new System.Drawing.Point(129, 249);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(144, 25);
            this.lbl_SDT.TabIndex = 0;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // lbl_TenTT
            // 
            this.lbl_TenTT.AutoSize = true;
            this.lbl_TenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_TenTT.Location = new System.Drawing.Point(129, 158);
            this.lbl_TenTT.Name = "lbl_TenTT";
            this.lbl_TenTT.Size = new System.Drawing.Size(127, 25);
            this.lbl_TenTT.TabIndex = 0;
            this.lbl_TenTT.Text = "Tên thủ thư:";
            // 
            // txt_MaTT
            // 
            this.txt_MaTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTT.Location = new System.Drawing.Point(278, 63);
            this.txt_MaTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaTT.Name = "txt_MaTT";
            this.txt_MaTT.Size = new System.Drawing.Size(294, 31);
            this.txt_MaTT.TabIndex = 1;
            // 
            // lbl_MaTT
            // 
            this.lbl_MaTT.AutoSize = true;
            this.lbl_MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaTT.Location = new System.Drawing.Point(129, 67);
            this.lbl_MaTT.Name = "lbl_MaTT";
            this.lbl_MaTT.Size = new System.Drawing.Size(120, 25);
            this.lbl_MaTT.TabIndex = 0;
            this.lbl_MaTT.Text = "Mã thủ thư:";
            this.lbl_MaTT.Click += new System.EventHandler(this.lbl_MaTT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.txt_TenTT);
            this.groupBox2.Controls.Add(this.lbl_SDT);
            this.groupBox2.Controls.Add(this.lbl_TenTT);
            this.groupBox2.Controls.Add(this.txt_MaTT);
            this.groupBox2.Controls.Add(this.lbl_MaTT);
            this.groupBox2.Controls.Add(this.txt_SDT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(1140, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 431);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thủ thư";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.ImageKey = "loading-arrow.png";
            this.btn_clear.ImageList = this.imageList1;
            this.btn_clear.Location = new System.Drawing.Point(62, 347);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(127, 47);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear ";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImageKey = "trash.png";
            this.btn_Xoa.ImageList = this.imageList1;
            this.btn_Xoa.Location = new System.Drawing.Point(208, 347);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(127, 47);
            this.btn_Xoa.TabIndex = 5;
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
            this.btn_Sua.Location = new System.Drawing.Point(356, 347);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Sua.Size = new System.Drawing.Size(127, 47);
            this.btn_Sua.TabIndex = 6;
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
            this.btn_Them.Location = new System.Drawing.Point(506, 347);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Them.Size = new System.Drawing.Size(127, 47);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm   ";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // grbDSTT
            // 
            this.grbDSTT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbDSTT.Controls.Add(this.btn_next);
            this.grbDSTT.Controls.Add(this.btn_prev);
            this.grbDSTT.Controls.Add(this.btn_last);
            this.grbDSTT.Controls.Add(this.btn_first);
            this.grbDSTT.Controls.Add(this.dgv_DMTT);
            this.grbDSTT.Controls.Add(this.btn_search);
            this.grbDSTT.Location = new System.Drawing.Point(127, 106);
            this.grbDSTT.Name = "grbDSTT";
            this.grbDSTT.Size = new System.Drawing.Size(951, 831);
            this.grbDSTT.TabIndex = 19;
            this.grbDSTT.TabStop = false;
            this.grbDSTT.Text = "grbDSTT";
            // 
            // lbltttt
            // 
            this.lbltttt.AutoSize = true;
            this.lbltttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltttt.Location = new System.Drawing.Point(370, 9);
            this.lbltttt.Name = "lbltttt";
            this.lbltttt.Size = new System.Drawing.Size(218, 29);
            this.lbltttt.TabIndex = 13;
            this.lbltttt.Text = "Danh sách thủ thư";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbltttt);
            this.panel1.Location = new System.Drawing.Point(127, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 48);
            this.panel1.TabIndex = 25;
            // 
            // frmDMTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDSTT);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDMTT";
            this.Text = "frmDMTT";
            this.Load += new System.EventHandler(this.frmDMTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbDSTT.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridView dgv_DMTT;
        private System.Windows.Forms.Label lbl_MaTT;
        private System.Windows.Forms.TextBox txt_MaTT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenTT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_TenTT;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox grbDSTT;
        private System.Windows.Forms.Label lbltttt;
        private System.Windows.Forms.Panel panel1;
    }
}