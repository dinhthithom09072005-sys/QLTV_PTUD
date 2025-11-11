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
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttendn = new System.Windows.Forms.TextBox();
            this.chkgnmk = new System.Windows.Forms.CheckBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.lblmk = new System.Windows.Forms.Label();
            this.lbltendn = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lbldnht = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(54, 159);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(260, 30);
            this.txtmk.TabIndex = 7;
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(54, 97);
            this.txttendn.Margin = new System.Windows.Forms.Padding(4);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(260, 30);
            this.txttendn.TabIndex = 6;
            this.txttendn.TextChanged += new System.EventHandler(this.txttendn_TextChanged);
            // 
            // chkgnmk
            // 
            this.chkgnmk.AutoSize = true;
            this.chkgnmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgnmk.Location = new System.Drawing.Point(54, 193);
            this.chkgnmk.Margin = new System.Windows.Forms.Padding(4);
            this.chkgnmk.Name = "chkgnmk";
            this.chkgnmk.Size = new System.Drawing.Size(191, 29);
            this.chkgnmk.TabIndex = 4;
            this.chkgnmk.Text = "Ghi nhớ mật khẩu";
            this.chkgnmk.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(206, 253);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 28);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndn
            // 
            this.btndn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btndn.Location = new System.Drawing.Point(54, 253);
            this.btndn.Margin = new System.Windows.Forms.Padding(4);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(108, 28);
            this.btndn.TabIndex = 2;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = false;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmk.Location = new System.Drawing.Point(51, 131);
            this.lblmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(93, 25);
            this.lblmk.TabIndex = 1;
            this.lblmk.Text = "Mật khẩu";
            // 
            // lbltendn
            // 
            this.lbltendn.AutoSize = true;
            this.lbltendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltendn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltendn.Location = new System.Drawing.Point(51, 61);
            this.lbltendn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(145, 25);
            this.lbltendn.TabIndex = 0;
            this.lbltendn.Text = "Tên đăng nhập";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lbldnht);
            this.pnlLogin.Controls.Add(this.txtmk);
            this.pnlLogin.Controls.Add(this.txttendn);
            this.pnlLogin.Controls.Add(this.lbltendn);
            this.pnlLogin.Controls.Add(this.lblmk);
            this.pnlLogin.Controls.Add(this.chkgnmk);
            this.pnlLogin.Controls.Add(this.btndn);
            this.pnlLogin.Controls.Add(this.btnthoat);
            this.pnlLogin.Location = new System.Drawing.Point(420, 147);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(378, 319);
            this.pnlLogin.TabIndex = 1;
            // 
            // lbldnht
            // 
            this.lbldnht.AutoSize = true;
            this.lbldnht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldnht.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbldnht.Location = new System.Drawing.Point(84, 11);
            this.lbldnht.Name = "lbldnht";
            this.lbldnht.Size = new System.Drawing.Size(289, 32);
            this.lbldnht.TabIndex = 8;
            this.lbldnht.Text = "Đăng nhập hệ thống";
            // 
            // FrmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 749);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangnhap";
            this.Text = "FrmDangnhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDangnhap_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.CheckBox chkgnmk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Label lbltendn;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lbldnht;
    }
}