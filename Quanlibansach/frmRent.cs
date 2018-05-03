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
    public partial class frmRent : Form
    {
        enum mode { Them, Sua };
        mode status;
        StatusRent[] statusRent;

        public delegate void onRefreshProductFrmSanpham();
        public onRefreshProductFrmSanpham refreshProductDlg;

        public frmRent()
        {
            InitializeComponent();
            gvRent.FocusedRowChanged += GvRent_FocusedRowChanged;
        }

        private void frmRent_Load(object sender, EventArgs e)
        {
            statusRent = new StatusRent[3];
            statusRent[0] = new StatusRent(0, "Đang mượn");
            statusRent[1] = new StatusRent(1, "Đã trả");
            statusRent[2] = new StatusRent(2, "Quá hạn");
            cmbTrangthai.Properties.Items.AddRange(statusRent);

            Bar bar1 = new Bar();
            BarItemLink link = bar1.AddItem(btnRefresh);
            btnRefresh_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(btnRefresh, link));
        }

        private void GvRent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int vitri = e.FocusedRowHandle;
            if (vitri < 0) return;
            String pro_id = gvRent.GetRowCellValue(vitri, "pro_id").ToString();
            String user_id = gvRent.GetRowCellValue(vitri, "user_id").ToString();
            int status_id = (int)gvRent.GetRowCellValue(vitri, "status");
            cmbTensach.EditValue = cmbTenuser.EditValue = null;
            foreach (Product pd in cmbTensach.Properties.DataSource as Product[])
            {
                if (pd.id.ToString().Equals(pro_id))
                {
                    cmbTensach.EditValue = cmbTensach.Properties.GetRowByKeyValue(pd);

                    try
                    {
                        ptbHinhsach.LoadAsync(pd.image);
                    }
                    catch
                    {
                        ptbHinhsach.Image = null;
                    }
                    break;
                }
            }
            foreach (User user in cmbTenuser.Properties.DataSource as User[])
            {
                if (user.id.ToString().Equals(user_id))
                {
                    cmbTenuser.EditValue = cmbTenuser.Properties.GetRowByKeyValue(user);
                    break;
                }
            }
            txtMathue.Text = gvRent.GetRowCellValue(vitri, "id").ToString();
            foreach (StatusRent sr in statusRent)
            {
                if (sr.id == status_id)
                {
                    cmbTrangthai.SelectedItem = sr;
                    break;
                }
            }
            if (status_id == 1) btnXoa.Enabled = true;
            else btnXoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            gcRent.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;

            txtMathue.Text =
                txtMasach.Text =
                txtMauser.Text = "";
            cmbTensach.EditValue =
            cmbTenuser.EditValue = null;
            cmbTensach.Enabled =
                cmbTenuser.Enabled = true;
            cmbTrangthai.Enabled = false;

            List<Product> list = new List<Product>(cmbTensach.Properties.DataSource as Product[]);
            foreach (Product pd in list.ToArray())
            {
                if (pd.status == 1)
                {
                    list.Remove(pd);
                }
            }
            cmbTensach.Properties.DataSource = list.ToArray();
            ptbHinhsach.ImageLocation = "";
            status = mode.Them;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnGhi.Enabled = true;
            btnXoa.Enabled = false;
            gcRent.Enabled = false;
            cmbTrangthai.Enabled = true;
            cmbTrangthai.Properties.Items.Remove(statusRent[2]);
            cmbTensach.Enabled =
                cmbTenuser.Enabled = false;
            gcChitiet.Enabled = true;
            status = mode.Sua;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            HttpWebRequest request;
            Rent rent;
            if (status == mode.Them)
            {
                if (cmbTensach.GetSelectedDataRow() == null)
                {
                    MessageBox.Show("Tên sách chưa được chọn");
                    return;
                }
                if (cmbTenuser.GetSelectedDataRow() == null)
                {
                    MessageBox.Show("Tên user chưa được chọn");
                    return;
                }

                rent = new Rent(txtMasach.Text, txtMauser.Text);
                String url = Program.path_storeRent + rent.toStringStore();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", rent.toStringStore());
                    MessageBox.Show("Thêm cho thuê thành công");
                    if (refreshProductDlg!=null) refreshProductDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm cho thuê thất bại\n" + ex.Message);
                }
            } else if (status == mode.Sua)
            {
                rent = new Rent(txtMathue.Text.ToString(), (cmbTrangthai.SelectedItem as StatusRent).id, txtMasach.Text.ToString());
                string path = Program.path_updateRent + rent.toStringUpdate();
                request = WebRequest.CreateHttp(path);
                try
                {
                    Program.sendRequest(request, "POST", "?id=" + txtMathue.Text);
                    MessageBox.Show("Update sản phẩm thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshProductDlg != null) refreshProductDlg();
                    cmbTrangthai.Properties.Items.Add(statusRent[2]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update sản phẩm thất bại\n" + ex.Message);
                }
            }
            btnRefresh_ItemClick(sender, e);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            String tenSach = cmbTensach.Text;
            String tenUser = cmbTenuser.Text;
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa\nSách '" + tenSach + "', user '" + tenUser + "' không?", "Trả lời đi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string url = Program.path_destroyRent + txtMathue.Text;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request);
                    MessageBox.Show("Xóa cho thuê thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshProductDlg != null) refreshProductDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa cho thuê thất bại\n" + ex.Message);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshProductUser();
            Rent[] rents = Program.getAllRent();
            gcRent.DataSource = rents;
            gvRent.FocusedRowHandle = 1;
            gvRent.FocusedRowHandle = 0;

            gcChitiet.Enabled = false;
            gcRent.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
        }

        public void refreshProductUser()
        {
            Product[] products = Program.getProductfromURL(Program.path_AllProducts);
            cmbTensach.Properties.DataSource = products;
            User[] users = Program.getUserbelow(Program.user.role);
            cmbTenuser.Properties.DataSource = users;

            txtMasach.Text =
                txtMauser.Text = "";
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbTensach_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTensach.EditValue == null) return;
            txtMasach.Text = ((Product)cmbTensach.GetSelectedDataRow()).id.ToString();
            try
            {
                ptbHinhsach.LoadAsync(((Product)cmbTensach.GetSelectedDataRow()).image);
            }
            catch
            {
                ptbHinhsach.Image = null;
            }
        }

        private void cmbTenuser_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTenuser.EditValue == null) return;
            txtMauser.Text = ((User)cmbTenuser.GetSelectedDataRow()).id.ToString();
        }
    }
}
