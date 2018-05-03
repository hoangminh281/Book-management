using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Quanlibansach
{
    public partial class frmSanpham : Form
    {
        mode status;
        enum mode { them, sua };

        Category[] arrCate;
        TreeNode rootNode;

        bool ptbHinhsachChanged;

        public delegate void onRefreshProductUser();
        public onRefreshProductUser refreshProductUserDlg;

        public frmSanpham()
        {
            InitializeComponent();
            gvProduct.FocusedRowChanged += GvProduct_FocusedRowChanged;
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            refreshTreeview();
            Bar bar1 = new Bar();
            BarItemLink link = bar1.AddItem(btnRefresh);
            btnRefresh_ItemClick(sender, new DevExpress.XtraBars.ItemClickEventArgs(btnRefresh, link));
        }

        void quickSort(int l, int r)
        {
            if (l <= r)
            {
                int key = arrCate[(l + r) / 2].parent_id;
                int i = l;
                int j = r;
                while (i <= j)
                {
                    while (arrCate[i].parent_id < key) i++;
                    while (arrCate[j].parent_id > key) j--;
                    if (i <= j)
                    {
                        Category tmp = arrCate[i];
                        arrCate[i] = arrCate[j];
                        arrCate[j] = tmp;
                        i++;
                        j--;
                    }
                }
                if (l < j) quickSort(l, j);
                if (r > i) quickSort(i, r);
            }
        }

        Boolean done = false;//cờ báo chèn xong sẽ ngừng đệ quy

        void insertNode(TreeNode treeNode, Category cate)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                if (node == null || done) return;//khi chèn xong hoặc hết node sẽ dừng
                else if (((Category)node.Tag).id == cate.parent_id)
                {
                    TreeNode childNode = new TreeNode(cate.name);
                    childNode.Tag = cate;
                    node.Nodes.Add(childNode);
                    done = true;
                }
                else
                {
                    insertNode(node, cate);
                }
            }
        }

        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String url;
            if (e.Node.Text.Equals(Program.rootName))
            {
                url = Program.path_AllProducts;
            }
            else
            {
                url = Program.path_productsFromCategory + ((Category)e.Node.Tag).id;
            }

            gcProduct.DataSource = Program.getProductfromURL(url);
            if (((Product[])gcProduct.DataSource).Length == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                foreach (Category cate in cmbLoaisach.Properties.Items)
                {
                    if (cate.id == ((Category)e.Node.Tag).id)
                    {
                        cmbLoaisach.SelectedItem = cate;
                        break;
                    }
                }
                txtMasach.Text =
                txtTensach.Text =
                txtGiatien.Text =
                txtGioithieu.Text =
                txtMota.Text = "";
                tgsTinhtrang.IsOn = false;
                ptbHinhsach.Image = null;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                GvProduct_FocusedRowChanged(sender, new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs(0, 0));
            }
        }

        private void GvProduct_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int vitri = e.FocusedRowHandle;
            if (vitri < 0) return;
            txtMasach.Text = gvProduct.GetRowCellValue(vitri, "id").ToString();
            txtTensach.Text = gvProduct.GetRowCellValue(vitri, "name").ToString();
            txtGiatien.Text = gvProduct.GetRowCellValue(vitri, "price").ToString();
            txtGioithieu.Text = gvProduct.GetRowCellValue(vitri, "intro").ToString();
            txtMota.Text = gvProduct.GetRowCellValue(vitri, "description").ToString();
            tgsTinhtrang.IsOn = gvProduct.GetRowCellValue(vitri, "status").ToString().Equals("0") ? false : true;
            txtMaloai.Text = gvProduct.GetRowCellValue(vitri, "cate_id").ToString();
            foreach (Category cate in cmbLoaisach.Properties.Items)
            {
                if (cate.id.ToString().Equals(txtMaloai.Text))
                {
                    cmbLoaisach.SelectedItem = cate;
                    break;
                }
            }
            try
            {
                ptbHinhsach.LoadAsync(gvProduct.GetRowCellValue(vitri, "image").ToString());
            }
            catch
            {
                ptbHinhsach.Image = null;
            }
        }

        private void cmbLoaisach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaloai.Text = ((Category)cmbLoaisach.SelectedItem).id.ToString();
        }

        List<String> getAllNode(TreeNodeCollection treeNode)
        {
            List<String> arr = new List<String>();
            //duyet cay
            foreach (TreeNode node in treeNode)
            {
                if (node == null)
                {
                    return arr;
                }
                arr.Add(node.Text);
                arr.AddRange(getAllNode(node.Nodes));
            }
            return arr;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            gcProduct.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            tvCategories.Enabled = false;
            ptbHinhsach.ImageLocation = "NotFound";

            txtTensach.Text =
                txtMasach.Text =
                txtGiatien.Text =
                txtGioithieu.Text =
                txtMota.Text = "";
            tgsTinhtrang.IsOn = false;
            txtTensach.Focus();

            status = mode.them;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcChitiet.Enabled = true;
            gcProduct.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            tvCategories.Enabled = false;
            tgsTinhtrang.Enabled = false;

            txtTensach.Focus();
            status = mode.sua;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HttpWebRequest request;
            Product pd;
            if (status.Equals(mode.them))
            {
                if (txtTensach.Text.Equals(""))
                {
                    MessageBox.Show("Tên sách không được để trống");
                    return;
                }
                if (txtGiatien.Text.Equals(""))
                {
                    MessageBox.Show("Giá tiền không được để trống");
                    return;
                }
                if (txtGioithieu.Text.Equals(""))
                {
                    MessageBox.Show("Giới thiệu không được để trống");
                    return;
                }
                if (txtMota.Text.Equals(""))
                {
                    MessageBox.Show("Mô tả không được để trống");
                    return;
                }
                pd = new Product(txtTensach.Text, txtMaloai.Text, txtGiatien.Text, txtGioithieu.Text, txtMota.Text, ptbHinhsach.ImageLocation, tgsTinhtrang.IsOn ? "1" : "0");
                String url = Program.path_storeProduct + pd.toStringStore();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", pd.toStringStore());
                    //if (ptbHinhsachChanged)
                    //{
                    //    ptbHinhsachChanged = false;
                    //    Upload(ptbHinhsach.Tag.ToString());
                    //}
                    MessageBox.Show("Thêm sản phẩm thành công");
                    tvCategories.SelectedNode = tvCategories.Nodes[0];
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm sản phẩm thất bại\n" + ex.Message);
                }
            }
            else if (status.Equals(mode.sua))
            {
                pd = new Product(txtMasach.Text, txtTensach.Text, txtMaloai.Text, txtGiatien.Text.Trim('$'), txtGioithieu.Text, txtMota.Text, ptbHinhsach.ImageLocation, tgsTinhtrang.IsOn ? "1" : "0");
                String url = Program.path_updateProduct + pd.toStringUpdate();
                request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request, "POST", pd.toStringUpdate());
                    MessageBox.Show("Sửa sản phẩm thành công");
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa sản phẩm thất bại\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không thể hiểu bạn đang làm gì");
                return;
            }
            btnRefresh_ItemClick(sender, e);
        }

        private void Upload(string fileName)
        {
            var client = new WebClient();
            var uri = new Uri(Program.image_address);
            try
            {
                client.Headers.Add("fileName", System.IO.Path.GetFileName(fileName));
                client.UploadFileAsync(uri, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload hình thất bại\n" + ex.Message);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenSach = gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, "name").ToString();
            String maSach = gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, "id").ToString();
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa\nSách '" + tenSach + "', id=" + maSach + " không?", "Trả lời đi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string url = Program.path_destroyProduct + maSach;
                HttpWebRequest request = WebRequest.CreateHttp(url);
                try
                {
                    Program.sendRequest(request);
                    MessageBox.Show("Xóa sản phẩm thành công");
                    btnRefresh_ItemClick(sender, e);
                    if (refreshProductUserDlg != null) refreshProductUserDlg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa sản phẩm thất bại\n" + ex.Message);
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tvCategories.SelectedNode == null) tvCategories.SelectedNode = tvCategories.Nodes[0];
            tvCategories_AfterSelect(sender, new TreeViewEventArgs(tvCategories.SelectedNode));

            gcChitiet.Enabled = false;
            gcProduct.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            tvCategories.Enabled = true;
        }

        public void refreshTreeview()
        {
            tvCategories.Nodes.Clear();
            arrCate = Program.getAllCategory();
            if (arrCate == null) return;
            //inc sort arr for parent_id
            quickSort(0, arrCate.Length - 1);
            //add node to tree
            rootNode = new TreeNode(Program.rootName);
            rootNode.Tag = new Category(-1, "Tất cả", 0, "");
            tvCategories.Nodes.Add(rootNode);
            foreach (Category cate in arrCate)
            {
                if (cate.parent_id == 0)
                {
                    TreeNode node = new TreeNode(cate.name);
                    node.Tag = cate;
                    rootNode.Nodes.Add(node);
                }
                else
                {
                    insertNode(rootNode, cate);
                    if (!done)
                    {
                        TreeNode node = new TreeNode(cate.name);
                        node.Tag = cate;
                        rootNode.Nodes.Add(node);
                    }
                    else done = false;
                }
            }
            //them loai sach vao cmbloaisach tu treelist
            cmbLoaisach.Properties.Items.AddRange(arrCate);
            cmbLoaisach.Properties.Items.Remove(Program.rootName);
        }

        public void refreshProducts()
        {
            Bar bar1 = new Bar();
            BarItemLink link = bar1.AddItem(btnRefresh);
            btnRefresh_ItemClick(new object(), new ItemClickEventArgs(btnRefresh, link));
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ptbHinhsach_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.FileName))
            {
                ptbHinhsach.Image = Image.FromFile(fbd.FileName);
                ptbHinhsach.Tag = fbd.FileName;
                ptbHinhsachChanged = true;
            }
        }
    }
}
