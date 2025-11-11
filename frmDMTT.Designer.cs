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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_DMTT = new DevExpress.XtraEditors.GroupControl();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.dgv_DMTT = new System.Windows.Forms.DataGridView();
            this.btn_search = new DevExpress.XtraEditors.SearchControl();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenTT = new System.Windows.Forms.TextBox();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_TenTT = new System.Windows.Forms.Label();
            this.txt_MaTT = new System.Windows.Forms.TextBox();
            this.lbl_MaTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grb_DMTT)).BeginInit();
            this.grb_DMTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_DMTT
            // 
            this.grb_DMTT.Appearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grb_DMTT.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DMTT.Appearance.Options.UseBorderColor = true;
            this.grb_DMTT.Appearance.Options.UseFont = true;
            this.grb_DMTT.Controls.Add(this.btn_prev);
            this.grb_DMTT.Controls.Add(this.btn_next);
            this.grb_DMTT.Controls.Add(this.btn_last);
            this.grb_DMTT.Controls.Add(this.btn_first);
            this.grb_DMTT.Controls.Add(this.dgv_DMTT);
            this.grb_DMTT.Controls.Add(this.btn_search);
            this.grb_DMTT.Location = new System.Drawing.Point(28, 50);
            this.grb_DMTT.Name = "grb_DMTT";
            this.grb_DMTT.Size = new System.Drawing.Size(1198, 813);
            this.grb_DMTT.TabIndex = 0;
            this.grb_DMTT.Text = "Danh mục thủ thư";
            // 
            // btn_prev
            // 
            this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.ForeColor = System.Drawing.Color.DimGray;
            this.btn_prev.Location = new System.Drawing.Point(119, 748);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(52, 39);
            this.btn_prev.TabIndex = 8;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DimGray;
            this.btn_next.Location = new System.Drawing.Point(222, 748);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(52, 39);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // btn_last
            // 
            this.btn_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.ForeColor = System.Drawing.Color.DimGray;
            this.btn_last.Location = new System.Drawing.Point(293, 748);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(52, 39);
            this.btn_last.TabIndex = 6;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click_1);
            // 
            // btn_first
            // 
            this.btn_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.ForeColor = System.Drawing.Color.DimGray;
            this.btn_first.Location = new System.Drawing.Point(51, 748);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(52, 39);
            this.btn_first.TabIndex = 5;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // dgv_DMTT
            // 
            this.dgv_DMTT.AllowUserToAddRows = false;
            this.dgv_DMTT.AllowUserToDeleteRows = false;
            this.dgv_DMTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMTT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DMTT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DMTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DMTT.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DMTT.Location = new System.Drawing.Point(50, 134);
            this.dgv_DMTT.Name = "dgv_DMTT";
            this.dgv_DMTT.ReadOnly = true;
            this.dgv_DMTT.RowHeadersWidth = 51;
            this.dgv_DMTT.RowTemplate.Height = 24;
            this.dgv_DMTT.Size = new System.Drawing.Size(1103, 578);
            this.dgv_DMTT.TabIndex = 4;
            this.dgv_DMTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMTT_CellClick);
            this.dgv_DMTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMTT_CellContentClick);
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
            this.btn_search.TabIndex = 3;
            this.btn_search.SelectedIndexChanged += new System.EventHandler(this.btn_search_SelectedIndexChanged);
            this.btn_search.TextChanged += new System.EventHandler(this.btn_search_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Firebrick;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1769, 416);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 41);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1769, 338);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 41);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1769, 260);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(120, 41);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1769, 182);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 41);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(1467, 342);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(262, 27);
            this.txt_SDT.TabIndex = 5;
            // 
            // txt_TenTT
            // 
            this.txt_TenTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTT.Location = new System.Drawing.Point(1467, 267);
            this.txt_TenTT.Name = "txt_TenTT";
            this.txt_TenTT.Size = new System.Drawing.Size(262, 27);
            this.txt_TenTT.TabIndex = 4;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(1334, 341);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(111, 20);
            this.lbl_SDT.TabIndex = 3;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // lbl_TenTT
            // 
            this.lbl_TenTT.AutoSize = true;
            this.lbl_TenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTT.Location = new System.Drawing.Point(1334, 268);
            this.lbl_TenTT.Name = "lbl_TenTT";
            this.lbl_TenTT.Size = new System.Drawing.Size(98, 20);
            this.lbl_TenTT.TabIndex = 2;
            this.lbl_TenTT.Text = "Tên thủ thư:";
            // 
            // txt_MaTT
            // 
            this.txt_MaTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTT.Location = new System.Drawing.Point(1467, 192);
            this.txt_MaTT.Name = "txt_MaTT";
            this.txt_MaTT.Size = new System.Drawing.Size(262, 27);
            this.txt_MaTT.TabIndex = 1;
            // 
            // lbl_MaTT
            // 
            this.lbl_MaTT.AutoSize = true;
            this.lbl_MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTT.Location = new System.Drawing.Point(1334, 195);
            this.lbl_MaTT.Name = "lbl_MaTT";
            this.lbl_MaTT.Size = new System.Drawing.Size(93, 20);
            this.lbl_MaTT.TabIndex = 0;
            this.lbl_MaTT.Text = "Mã thủ thư:";
            this.lbl_MaTT.Click += new System.EventHandler(this.lbl_MaTT_Click);
            // 
            // frmDMTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_DMTT);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_MaTT);
            this.Controls.Add(this.txt_MaTT);
            this.Controls.Add(this.txt_TenTT);
            this.Controls.Add(this.lbl_TenTT);
            this.Controls.Add(this.lbl_SDT);
            this.Name = "frmDMTT";
            this.Text = "frmDMTT";
            this.Load += new System.EventHandler(this.frmDMTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grb_DMTT)).EndInit();
            this.grb_DMTT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grb_DMTT;
        private DevExpress.XtraEditors.SearchControl btn_search;
        private System.Windows.Forms.DataGridView dgv_DMTT;
        private System.Windows.Forms.Label lbl_MaTT;
        private System.Windows.Forms.TextBox txt_MaTT;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenTT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_TenTT;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
    }
}