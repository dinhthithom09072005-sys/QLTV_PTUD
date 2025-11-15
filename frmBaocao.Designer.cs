namespace PTUD_QLTV
{
    partial class frmBaocao
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint3 = new System.Windows.Forms.Button();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.dtpketthuc1 = new System.Windows.Forms.DateTimePicker();
            this.dtpbatdau1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPrint2 = new System.Windows.Forms.Button();
            this.dtpketthuc2 = new System.Windows.Forms.DateTimePicker();
            this.dtpbatdau2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint3);
            this.groupBox3.Controls.Add(this.dtp3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(719, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 460);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quá hạn ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnPrint3
            // 
            this.btnPrint3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrint3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint3.Location = new System.Drawing.Point(32, 193);
            this.btnPrint3.Name = "btnPrint3";
            this.btnPrint3.Size = new System.Drawing.Size(75, 23);
            this.btnPrint3.TabIndex = 12;
            this.btnPrint3.Text = "In báo cáo ";
            this.btnPrint3.UseVisualStyleBackColor = false;
            this.btnPrint3.Click += new System.EventHandler(this.btnPrint3_Click);
            // 
            // dtp3
            // 
            this.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp3.Location = new System.Drawing.Point(32, 134);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(134, 20);
            this.dtp3.TabIndex = 11;
            this.dtp3.ValueChanged += new System.EventHandler(this.dtp3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tính đến ngày ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DANH SÁCH PHIẾU MƯỢN QUÁ HẠN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrint1);
            this.groupBox1.Controls.Add(this.dtpketthuc1);
            this.groupBox1.Controls.Add(this.dtpbatdau1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 462);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Đến ngày ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DANH SÁCH SỐ LƯỢNG PHIẾU MƯỢN  THEO NGÀY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ ngày";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPrint1
            // 
            this.btnPrint1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrint1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint1.Location = new System.Drawing.Point(38, 327);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(75, 23);
            this.btnPrint1.TabIndex = 5;
            this.btnPrint1.Text = "In báo cáo";
            this.btnPrint1.UseVisualStyleBackColor = false;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // dtpketthuc1
            // 
            this.dtpketthuc1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpketthuc1.Location = new System.Drawing.Point(38, 234);
            this.dtpketthuc1.Name = "dtpketthuc1";
            this.dtpketthuc1.Size = new System.Drawing.Size(140, 20);
            this.dtpketthuc1.TabIndex = 2;
            this.dtpketthuc1.ValueChanged += new System.EventHandler(this.dtpketthuc1_ValueChanged);
            // 
            // dtpbatdau1
            // 
            this.dtpbatdau1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbatdau1.Location = new System.Drawing.Point(38, 136);
            this.dtpbatdau1.Name = "dtpbatdau1";
            this.dtpbatdau1.Size = new System.Drawing.Size(140, 20);
            this.dtpbatdau1.TabIndex = 1;
            this.dtpbatdau1.ValueChanged += new System.EventHandler(this.dtpbatdau1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnPrint2);
            this.groupBox2.Controls.Add(this.dtpketthuc2);
            this.groupBox2.Controls.Add(this.dtpbatdau2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 460);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu phạt";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Đến ngày ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Từ ngày";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnPrint2
            // 
            this.btnPrint2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrint2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint2.Location = new System.Drawing.Point(20, 325);
            this.btnPrint2.Name = "btnPrint2";
            this.btnPrint2.Size = new System.Drawing.Size(75, 23);
            this.btnPrint2.TabIndex = 11;
            this.btnPrint2.Text = "In báo cáo ";
            this.btnPrint2.UseVisualStyleBackColor = false;
            this.btnPrint2.Click += new System.EventHandler(this.btnPrint2_Click);
            // 
            // dtpketthuc2
            // 
            this.dtpketthuc2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpketthuc2.Location = new System.Drawing.Point(30, 232);
            this.dtpketthuc2.Name = "dtpketthuc2";
            this.dtpketthuc2.Size = new System.Drawing.Size(134, 20);
            this.dtpketthuc2.TabIndex = 10;
            this.dtpketthuc2.ValueChanged += new System.EventHandler(this.dtpketthuc2_ValueChanged);
            // 
            // dtpbatdau2
            // 
            this.dtpbatdau2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbatdau2.Location = new System.Drawing.Point(30, 134);
            this.dtpbatdau2.Name = "dtpbatdau2";
            this.dtpbatdau2.Size = new System.Drawing.Size(134, 20);
            this.dtpbatdau2.TabIndex = 9;
            this.dtpbatdau2.ValueChanged += new System.EventHandler(this.dtpbatdau2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH SÁCH SỐ LƯỢNG PHIẾU PHẠT VÀ TỔNG TIỀN PHẠT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            this.xtraOpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.xtraOpenFileDialog1_FileOk);
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmBaocao";
            this.Text = "frmBaocao";
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint1;
        private System.Windows.Forms.DateTimePicker dtpketthuc1;
        private System.Windows.Forms.DateTimePicker dtpbatdau1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint2;
        private System.Windows.Forms.DateTimePicker dtpketthuc2;
        private System.Windows.Forms.DateTimePicker dtpbatdau2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint3;
        private System.Windows.Forms.DateTimePicker dtp3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}