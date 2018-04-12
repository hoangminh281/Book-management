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
    public partial class frmUser : Form
    {
        enum mode { Them, Sua};
        mode status;

        public delegate void onRefreshProductUser();
        public onRefreshProductUser refreshProductUserDlg;

        public frmUser()
        {
            InitializeComponent();
            gvUser.FocusedRowChanged += GvUser_FocusedRowChanged;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            gcChitiet.Enabled = false;
            txtMauser.Enabled = txtRole.Enabled = false;
            btnGhi.Enabled = false;

            //lay permission do vao cmbLoaiuser
            Permission[] perList = Program.getPermissionbelow(Program.user.role);
            if (perList == null) return;
            cmbLoaiuser.Properties.Items.AddRange(perList);

            //lay data do vao gridcontrol
            User[] userList = Program.getUserbelow(Program.user.role);
            gcUser.DataSource = userList;

        }

        private void GvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int vitri = e.FocusedRowHandle;
            if (vitri < 0) return;
            txtMauser.Text = gvUser.GetRowCellValue(vitri, "id").ToString();
            txtTenuser.Text = gvUser.GetRowCellValue(vitri, "name").ToString();
            txtRole.Text = gvUser.GetRowCellValue(vitri, "role").ToString();
            txtEmail.Text = gvUser.GetRowCellValue(vitri, "email").ToString();
            txtPassword.Text = gvUser.GetRowCellValue(vitri, "password").ToString();

            //lay ten loai user tu role code
            foreach (Permission key in cmbLoaiuser.Properties.Items)
            {
                if (key.id == txtRole.Text)
                {
                    cmbLoaiuser.SelectedItem = key;
                }
            }
        }

        private void cmbLoaiuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRole.Text = ((Permission)cmbLoaiuser.SelectedItem).id.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = mode.Them;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            gcChitiet.Enabled = true;
            gcUser.Enabled = false;

            txtMauser.Text = txtTenuser.Text = txtEmail.Text = txtPassword.Text = "";
            txtTenuser.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            status = mode.Sua;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            gcChitiet.Enabled = true;
            gcUser.Enabled = false;
            txtTenuser.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HttpWebRequest request;
            User user;
            if (status.Equals(mode.Them))
            {
                if (txtTenuser.Text.Equals(""))
                {
                    MessageBox.Show("Tên user không được để trống");
                    return;
                }
                if (txtEmail.Text.Equals(""))
                {
                    MessageBox.Show("Email không được để trống");
                    return;
                }
                if (txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Password không được để trống");
                    return;
                }
                user = new User(txtTenuser.Text, txtEmail.Text, txtPassword.Text, txtRole.Text);
                String url = Program.path_storeUser + user.toStringStore();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", user.toStringStore());
                    MessageBox.Show("Tạo tài khoản thành công");
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo tài khoản thất bại\n" + ex.Message);
                }
            }
            else if (status.Equals(mode.Sua))
            {
                user = new User(txtMauser.Text, txtTenuser.Text, txtEmail.Text, txtPassword.Text, txtRole.Text);
                String url = Program.path_updateUser + user.toStringUpdate();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", user.toStringUpdate());
                    MessageBox.Show("Sửa user thành công");
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa user thất bại\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không thể hiểu bạn đang làm gì");
                return;
            }

            btnRefresh_ItemClick(sender, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenUser = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "name").ToString();
            String maUser = gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "id").ToString();
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa\nUser '" + tenUser + "', id=" + maUser + " không?", "Trả lời đi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string url = Program.path_destroyUser + maUser;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request);
                    MessageBox.Show("Xóa User thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa User thất bại\n" + ex.Message);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lay data do vao gridcontrol
            User[] userList = Program.getUserbelow(Program.user.role);
            gcUser.DataSource = userList;
            //tuy chinh menu
            gcChitiet.Enabled = false;
            gcUser.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
