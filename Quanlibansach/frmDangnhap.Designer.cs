namespace Quanlibansach
{
    partial class frmDangnhap
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaikhoan = new DevExpress.XtraEditors.TextEdit();
            this.ptbMatkhau = new System.Windows.Forms.PictureBox();
            this.ptbTaikhoan = new System.Windows.Forms.PictureBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(52, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.EditValue = "123";
            this.txtMatkhau.Location = new System.Drawing.Point(169, 113);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatkhau.Properties.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(172, 26);
            this.txtMatkhau.TabIndex = 1;
            this.txtMatkhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(52, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 19);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Email";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.EditValue = "root@gmail.com";
            this.txtTaikhoan.Location = new System.Drawing.Point(167, 43);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaikhoan.Size = new System.Drawing.Size(172, 26);
            this.txtTaikhoan.TabIndex = 0;
            this.txtTaikhoan.Leave += new System.EventHandler(this.txtTaikhoan_Leave);
            // 
            // ptbMatkhau
            // 
            this.ptbMatkhau.Location = new System.Drawing.Point(345, 113);
            this.ptbMatkhau.Name = "ptbMatkhau";
            this.ptbMatkhau.Size = new System.Drawing.Size(26, 26);
            this.ptbMatkhau.TabIndex = 25;
            this.ptbMatkhau.TabStop = false;
            // 
            // ptbTaikhoan
            // 
            this.ptbTaikhoan.ErrorImage = null;
            this.ptbTaikhoan.Location = new System.Drawing.Point(345, 43);
            this.ptbTaikhoan.Name = "ptbTaikhoan";
            this.ptbTaikhoan.Size = new System.Drawing.Size(26, 26);
            this.ptbTaikhoan.TabIndex = 24;
            this.ptbTaikhoan.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(248, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 36);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Appearance.Options.UseFont = true;
            this.btnDangnhap.Location = new System.Drawing.Point(98, 205);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(107, 36);
            this.btnDangnhap.TabIndex = 2;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.ptbMatkhau);
            this.Controls.Add(this.ptbTaikhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDangnhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTaikhoan;
        private System.Windows.Forms.PictureBox ptbMatkhau;
        private System.Windows.Forms.PictureBox ptbTaikhoan;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
    }
}

