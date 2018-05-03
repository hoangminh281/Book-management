using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibansach
{
    public partial class frmDangnhap : Form
    {
        public delegate void onSetTxtUserInfo(String info);
        public onSetTxtUserInfo setTxtUserInfo;
        public delegate void onSetSigninPass();
        public onSetSigninPass setSigninPass;

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void txtTaikhoan_Leave(object sender, EventArgs e)
        {
            String taikhoan = txtTaikhoan.Text.Trim();
            if (taikhoan.Equals(""))
            {
                ptbTaikhoan.Image = Quanlibansach.Properties.Resources.icons8_cancel_64;
            }
            else
            {
                ptbTaikhoan.Image = Quanlibansach.Properties.Resources.icons8_checkmark_64;
            }
        }

        private void txtMatkhau_Leave(object sender, EventArgs e)
        {
            String matkhau = txtMatkhau.Text.Trim();
            if (matkhau.Equals(""))
            {
                ptbMatkhau.Image = Quanlibansach.Properties.Resources.icons8_cancel_64;
            }
            else
            {
                ptbMatkhau.Image = Quanlibansach.Properties.Resources.icons8_checkmark_64;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String taikhoan = txtTaikhoan.Text.Trim();
            String matkhau = txtMatkhau.Text.Trim();
            if (taikhoan.Equals("") || matkhau.Equals(""))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống");
                return;
            }

            try
            {
                Program.signin(txtTaikhoan.Text, txtMatkhau.Text);
                MessageBox.Show("Đăng nhập thành công vì sự hôi lông");
                setSigninPass();
            } catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại vì sự ăn hại\n" + ex.Message);
                return;
            }
            try
            {
                if (setTxtUserInfo != null)
                {
                    //Permission per = Program.getPermission(Program.user.id);
                    Permission per = Program.getPermission(int.Parse(Program.user.role));
                    setTxtUserInfo("Id = " + Program.user.id + " | Name: " + Program.user.name + " | Role: " + per.name);
                }
                this.Close();
            } catch
            {
                MessageBox.Show("Không thể lấy được Permission");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
