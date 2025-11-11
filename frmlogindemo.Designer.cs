namespace PTUD_QLTV
{
    partial class frmlogindemo
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
            this.txttendn = new System.Windows.Forms.TextBox();
            this.btnlaymk = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.btnlaymk);
            this.groupBox1.Controls.Add(this.txttendn);
            this.groupBox1.Controls.Add(this.lbltendn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(162, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lấy lại mật khẩu";
            // 
            // lbltendn
            // 
            this.lbltendn.AutoSize = true;
            this.lbltendn.Location = new System.Drawing.Point(93, 48);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(98, 16);
            this.lbltendn.TabIndex = 0;
            this.lbltendn.Text = "Tên đăng nhập";
            // 
            // txttendn
            // 
            this.txttendn.Location = new System.Drawing.Point(96, 78);
            this.txttendn.Name = "txttendn";
            this.txttendn.Size = new System.Drawing.Size(180, 22);
            this.txttendn.TabIndex = 1;
            // 
            // btnlaymk
            // 
            this.btnlaymk.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnlaymk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaymk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlaymk.Location = new System.Drawing.Point(123, 117);
            this.btnlaymk.Name = "btnlaymk";
            this.btnlaymk.Size = new System.Drawing.Size(127, 32);
            this.btnlaymk.TabIndex = 2;
            this.btnlaymk.Text = "Lấy lại mật khẩu";
            this.btnlaymk.UseVisualStyleBackColor = false;
            this.btnlaymk.Click += new System.EventHandler(this.btnlaymk_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(254, 164);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 28);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Trở về ";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmlogindemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmlogindemo";
            this.Text = "frmlogindemo";
            this.Load += new System.EventHandler(this.frmlogindemo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnlaymk;
        private System.Windows.Forms.TextBox txttendn;
        private System.Windows.Forms.Label lbltendn;
    }
}