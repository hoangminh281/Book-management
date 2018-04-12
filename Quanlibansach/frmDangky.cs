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
    public partial class frmDangky : Form
    {

        public frmDangky()
        {
            InitializeComponent();
        }

        private void frmDangky_Load(object sender, EventArgs e)
        {
            Permission[] arrPer = Program.getPermissionbelow(Program.user.role);
            if (arrPer == null) return;
            foreach (Permission per in arrPer)
            {
                cmbRole.Properties.Items.Add(per);
            }
            cmbRole.SelectedIndex = 0;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            if (name.Equals(""))
            {
                ptbName.Image = Quanlibansach.Properties.Resources.icons8_cancel_64;
            }
            else
            {
                ptbName.Image = Quanlibansach.Properties.Resources.icons8_checkmark_64;
            }
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

        private void txtNhaplaimk_Leave(object sender, EventArgs e)
        {
            String matkhau = txtMatkhau.Text.Trim();
            String nhaplaimk = txtNhaplaimk.Text.Trim();
            if (!nhaplaimk.Equals(matkhau) || nhaplaimk == "")
            {
                ptbNhaplaimk.Image = Quanlibansach.Properties.Resources.icons8_cancel_64;
            }
            else
            {
                ptbNhaplaimk.Image = Quanlibansach.Properties.Resources.icons8_checkmark_64;
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String taikhoan = txtTaikhoan.Text.Trim();
            String matkhau = txtMatkhau.Text.Trim();
            if (name.Equals("") || taikhoan.Equals("") || matkhau.Equals(""))
            {
                MessageBox.Show("Tên, Tài khoản hoặc mật khẩu không được để trống");
                return;
            }
            User user = new User(txtName.Text, txtTaikhoan.Text, txtMatkhau.Text, ((Permission)cmbRole.Properties.Items[cmbRole.SelectedIndex]).id);
            String url = Program.path_storeUser + user.toStringStore();
            HttpWebRequest request = WebRequest.CreateHttp(url);
            try
            {
                Program.sendRequest(request, "POST", user.toStringStore());
                MessageBox.Show("Tạo tài khoản thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo tài khoản thất bại\n" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
