namespace PTUD_QLTV
{
    partial class FrmDangnhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltendn = new System.Windows.Forms.Label();
            this.lblmk = new System.Windows.Forms.Label();
            this.btndn = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.chkgnmk = new System.Windows.Forms.CheckBox();
            this.linklbllaymk = new System.Windows.Forms.LinkLabel();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttendn);
            this.groupBox1.Controls.Add(this.linklbllaymk);
            this.groupBox1.Controls.Add(this.chkgnmk);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btndn);
            this.groupBox1.Controls.Add(this.lblmk);
            this.groupBox1.Controls.Add(this.lbltendn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(98, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập hệ thống";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbltendn
            // 
            this.lbltendn.AutoSize = true;
            this.lbltendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltendn.Location = new System.Drawing.Point(99, 76);
            this.lbltendn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(98, 16);
            this.lbltendn.TabIndex = 0;
            this.lbltendn.Text = "Tên đăng nhập";
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmk.Location = new System.Drawing.Point(99, 146);
            this.lblmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(61, 16);
            this.lblmk.TabIndex = 1;
            this.lblmk.Text = "Mật khẩu";
            // 
            // btndn
            // 
            this.btndn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btndn.Location = new System.Drawing.Point(102, 268);
            this.btndn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(108, 28);
            this.btndn.TabIndex = 2;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = false;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(254, 268);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 28);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // chkgnmk
            // 
            this.chkgnmk.AutoSize = true;
            this.chkgnmk.Location = new System.Drawing.Point(102, 204);
            this.chkgnmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkgnmk.Name = "chkgnmk";
            this.chkgnmk.Size = new System.Drawing.Size(128, 20);
            this.chkgnmk.TabIndex = 4;
            this.chkgnmk.Text = "Ghi nhớ mật khẩu";
            this.chkgnmk.UseVisualStyleBackColor = true;
            // 
            // linklbllaymk
            // 
            this.linklbllaymk.AutoSize = true;
            this.linklbllaymk.Location = new System.Drawing.Point(256, 208);
            this.linklbllaymk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbllaymk.Name = "linklbllaymk";
            this.linklbllaymk.Size = new System.Drawing.Size(106, 16);
            this.linklbllaymk.TabIndex = 5;
            this.linklbllaymk.TabStop = true;
            this.linklbllaymk.Text = "Quên mật khẩu? ";
            this.linklbllaymk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbllaymk_LinkClicked);
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(102, 112);
            this.txttendn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(260, 22);
            this.txttendn.TabIndex = 6;
            this.txttendn.TextChanged += new System.EventHandler(this.txttendn_TextChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(102, 174);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(260, 22);
            this.txtmk.TabIndex = 7;
            // 
            // FrmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 749);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDangnhap";
            this.Text = "FrmDangnhap";
            this.Load += new System.EventHandler(this.FrmDangnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.LinkLabel linklbllaymk;
        private System.Windows.Forms.CheckBox chkgnmk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Label lbltendn;
    }
}