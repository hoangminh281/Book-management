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
    public partial class frmLoaisach : Form
    {
        mode status;
        enum mode { them, sua };
        Category[] arrCate;
        public delegate void onRefreshTreeview();
        public onRefreshTreeview refreshTreeview;

        public frmLoaisach()
        {
            InitializeComponent();
        }

        private void frmLoaisach_Load(object sender, EventArgs e)
        {
            Bar bar1 = new Bar();
            BarItemLink link = bar1.AddItem(btnRefresh);
            btnRefresh_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(btnRefresh, link));

            tlLoaisach.PopulateColumns();//hien col bi an khi tro thanh parent
            tlLoaisach.Columns["id"].OptionsColumn.ReadOnly = true;
            tlLoaisach.Columns["id"].OptionsColumn.AllowEdit = false;
            tlLoaisach.Columns["name"].OptionsColumn.ReadOnly = true;
            tlLoaisach.Columns["name"].OptionsColumn.AllowEdit = false;
            tlLoaisach.Columns["parent_id"].OptionsColumn.ReadOnly = true;
            tlLoaisach.Columns["parent_id"].OptionsColumn.AllowEdit = false;
            tlLoaisach.Columns["description"].OptionsColumn.ReadOnly = true;
            tlLoaisach.Columns["description"].OptionsColumn.AllowEdit = false;

            gcChitiet.Enabled = false;
            btnGhi.Enabled = false;
        }

        private void tlLoaisach_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            //if (e.Node.ToString().Equals("DevExpress.XtraTreeList.Nodes.TreeListAutoFilterNode")) return;
            txtLoaisach.Text = e.Node["name"].ToString();
            txtMaloai.Text = e.Node["id"].ToString();
            txtMapid.Text = e.Node["parent_id"].ToString();
            txtMota.Text = e.Node["description"].ToString();

            foreach (Category cate in cmbTenparent.Properties.Items)
            {
                if (cate.id.ToString().Equals(txtMapid.Text))
                {
                    cmbTenparent.SelectedItem = cate;
                    return;
                }
            }
            cmbTenparent.Text = "";
        }

        private void cmbTenparent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenparent.Text == "") return;
            txtMapid.Text = ((Category)cmbTenparent.SelectedItem).id.ToString();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            tlLoaisach.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;

            txtLoaisach.Text =
                txtMaloai.Text =
                txtMota.Text = "";
            foreach(Category cate in cmbTenparent.Properties.Items)
            {
                if (cate.id.ToString().Equals(tlLoaisach.FocusedNode["id"].ToString()))
                {
                    cmbTenparent.SelectedItem = cate;
                    break;
                }
            }
            txtLoaisach.Focus();

            status = mode.them;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            tlLoaisach.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;

            txtLoaisach.Focus();
            status = mode.sua;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HttpWebRequest request;
            Category cate;
            if (status.Equals(mode.them))
            {
                if (txtLoaisach.Text.Equals(""))
                {
                    MessageBox.Show("Tên loại sách không được để trống");
                    return;
                }
                if (txtMota.Text.Equals(""))
                {
                    MessageBox.Show("Mô tả không được để trống");
                    return;
                }
                cate = new Category(txtLoaisach.Text, int.Parse(txtMapid.Text), txtMota.Text);
                String url = Program.path_storeCategory + cate.toStringStore();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", cate.toStringStore());
                    MessageBox.Show("Thêm loại sản phẩm thành công");
                    if (refreshTreeview != null) refreshTreeview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại\n" + ex.Message);
                }
            }
            else if (status.Equals(mode.sua))
            {
                cate = new Category(int.Parse(txtMaloai.Text), txtLoaisach.Text, int.Parse(txtMapid.Text), txtMota.Text);
                String url = Program.path_updateCategory + cate.toStringUpdate();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", cate.toStringUpdate());
                    MessageBox.Show("Sửa loại sản phẩm thành công");
                    if (refreshTreeview != null) refreshTreeview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa loại sản phẩm thất bại\n" + ex.Message);
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
            String loaiSach = tlLoaisach.FocusedNode["name"].ToString();
            String maLoai = tlLoaisach.FocusedNode["id"].ToString();
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa\nLoại sách '" + loaiSach + "', id=" + maLoai + " không?", "Trả lời đi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string url = Program.path_destroyCategory + maLoai;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request);
                    MessageBox.Show("Xóa loại sách thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshTreeview != null) refreshTreeview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa loại sách thất bại\n" + ex.Message);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            arrCate = Program.getAllCategory();
            if (arrCate == null) return;
            cmbTenparent.Properties.Items.Add(new Category(0, Program.rootName, 0, ""));
            cmbTenparent.Properties.Items.AddRange(arrCate);
            tlLoaisach.DataSource = arrCate;

            gcChitiet.Enabled = false;
            tlLoaisach.Enabled = true;
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
