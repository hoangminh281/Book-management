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
using DevExpress.XtraBars;

namespace Quanlibansach
{
    public partial class frmPermission : Form
    {
        mode status;
        enum mode { them, sua };
        public delegate void onRefreshPermission();
        public onRefreshPermission refreshPermission;

        public frmPermission()
        {
            InitializeComponent();
            gvPermission.FocusedRowChanged += GvPermission_FocusedRowChanged;
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            Bar bar1 = new Bar();
            BarItemLink link = bar1.AddItem(btnRefresh);
            btnRefresh_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(btnRefresh, link));
        }

        private void GvPermission_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int vitri = e.FocusedRowHandle;
            if (vitri < 0) return;
            txtMaquyen.Text = gvPermission.GetRowCellValue(vitri, "id").ToString();
            txtTenquyen.Text = gvPermission.GetRowCellValue(vitri, "name").ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            gcPermission.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;

            txtMaquyen.Text =
                txtTenquyen.Text = "";
            txtTenquyen.Focus();

            status = mode.them;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            gcPermission.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;

            txtTenquyen.Focus();
            status = mode.sua;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HttpWebRequest request;
            Permission per;
            if (status.Equals(mode.them))
            {
                if (txtTenquyen.Text.Equals(""))
                {
                    MessageBox.Show("Tên quyền hạn không được để trống");
                    return;
                }

                per = new Permission(txtTenquyen.Text);
                String url = Program.path_storePermission + per.toStringStore();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", per.toStringStore());
                    MessageBox.Show("Thêm quyền thành công");
                    if (refreshPermission != null) refreshPermission();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm quyền thất bại\n" + ex.Message);
                }
            }
            else if (status.Equals(mode.sua))
            {
                per = new Permission(txtMaquyen.Text, txtTenquyen.Text);
                String url = Program.path_updatePermission + per.toStringUpdate();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", per.toStringUpdate());
                    MessageBox.Show("Sửa quyền thành công");
                    if (refreshPermission!=null) refreshPermission();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa quyền thất bại\n" + ex.Message);
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
            String maquyen = txtMaquyen.Text;
            String tenquyen = txtTenquyen.Text;
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa\nquyền id=" + maquyen + ", tên quyền '" + tenquyen + " không?", "Trả lời đi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string url = Program.path_destroyPermission + maquyen;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request);
                    MessageBox.Show("Xóa quyền thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshPermission != null) refreshPermission();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa quyền thất bại\n" + ex.Message);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Permission[] per = Program.getPermissionbelow(Program.user.role);
            if (per == null) return;
            gcPermission.DataSource = per;
            GvPermission_FocusedRowChanged(sender, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(gvPermission.FocusedRowHandle,gvPermission.FocusedRowHandle));

            gcChitiet.Enabled = false;
            gcPermission.Enabled = true;
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
