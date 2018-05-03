namespace Quanlibansach
{
    partial class frmSanpham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanpham));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaloai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChitiet = new DevExpress.XtraEditors.GroupControl();
            this.cmbLoaisach = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tgsTinhtrang = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiatien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaloai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMasach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGioithieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTensach = new DevExpress.XtraEditors.TextEdit();
            this.ptbHinhsach = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).BeginInit();
            this.gcChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaisach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTinhtrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiatien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioithieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnRefresh,
            this.btnThoat});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSua.Glyph")));
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhi.Glyph")));
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 4;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThoat.Glyph")));
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1296, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tvCategories);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(240, 490);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thể loại sách";
            // 
            // tvCategories
            // 
            this.tvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCategories.Location = new System.Drawing.Point(2, 20);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.Size = new System.Drawing.Size(236, 468);
            this.tvCategories.TabIndex = 18;
            this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterSelect);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcProduct);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(240, 39);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1056, 241);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Kho sách";
            // 
            // gcProduct
            // 
            this.gcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProduct.Location = new System.Drawing.Point(2, 20);
            this.gcProduct.MainView = this.gvProduct;
            this.gcProduct.MenuManager = this.barManager1;
            this.gcProduct.Name = "gcProduct";
            this.gcProduct.Size = new System.Drawing.Size(1052, 219);
            this.gcProduct.TabIndex = 0;
            this.gcProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasach,
            this.colMaloai,
            this.colTensach,
            this.colPrice,
            this.colIntro,
            this.colDescription,
            this.colView,
            this.colStatus,
            this.colImage});
            this.gvProduct.GridControl = this.gcProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.Editable = false;
            this.gvProduct.OptionsBehavior.ReadOnly = true;
            this.gvProduct.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvProduct.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMasach
            // 
            this.colMasach.Caption = "Mã sách";
            this.colMasach.FieldName = "id";
            this.colMasach.Name = "colMasach";
            this.colMasach.Visible = true;
            this.colMasach.VisibleIndex = 0;
            // 
            // colMaloai
            // 
            this.colMaloai.Caption = "Mã loại";
            this.colMaloai.FieldName = "cate_id";
            this.colMaloai.Name = "colMaloai";
            this.colMaloai.Visible = true;
            this.colMaloai.VisibleIndex = 1;
            // 
            // colTensach
            // 
            this.colTensach.Caption = "Tên sách";
            this.colTensach.FieldName = "name";
            this.colTensach.Name = "colTensach";
            this.colTensach.Visible = true;
            this.colTensach.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá sách";
            this.colPrice.FieldName = "price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colIntro
            // 
            this.colIntro.Caption = "Giới thiệu";
            this.colIntro.FieldName = "intro";
            this.colIntro.Name = "colIntro";
            this.colIntro.Visible = true;
            this.colIntro.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colView
            // 
            this.colView.Caption = "View";
            this.colView.FieldName = "view";
            this.colView.Name = "colView";
            this.colView.Visible = true;
            this.colView.VisibleIndex = 6;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 7;
            // 
            // colImage
            // 
            this.colImage.Caption = "Image";
            this.colImage.FieldName = "image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 8;
            // 
            // gcChitiet
            // 
            this.gcChitiet.Controls.Add(this.cmbLoaisach);
            this.gcChitiet.Controls.Add(this.tgsTinhtrang);
            this.gcChitiet.Controls.Add(this.txtMota);
            this.gcChitiet.Controls.Add(this.labelControl7);
            this.gcChitiet.Controls.Add(this.labelControl6);
            this.gcChitiet.Controls.Add(this.txtGiatien);
            this.gcChitiet.Controls.Add(this.labelControl5);
            this.gcChitiet.Controls.Add(this.txtMaloai);
            this.gcChitiet.Controls.Add(this.labelControl4);
            this.gcChitiet.Controls.Add(this.txtMasach);
            this.gcChitiet.Controls.Add(this.labelControl3);
            this.gcChitiet.Controls.Add(this.txtGioithieu);
            this.gcChitiet.Controls.Add(this.labelControl2);
            this.gcChitiet.Controls.Add(this.labelControl1);
            this.gcChitiet.Controls.Add(this.txtTensach);
            this.gcChitiet.Controls.Add(this.ptbHinhsach);
            this.gcChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChitiet.Location = new System.Drawing.Point(240, 280);
            this.gcChitiet.Name = "gcChitiet";
            this.gcChitiet.Size = new System.Drawing.Size(1056, 249);
            this.gcChitiet.TabIndex = 10;
            this.gcChitiet.Text = "Chi tiết";
            // 
            // cmbLoaisach
            // 
            this.cmbLoaisach.Location = new System.Drawing.Point(263, 72);
            this.cmbLoaisach.MenuManager = this.barManager1;
            this.cmbLoaisach.Name = "cmbLoaisach";
            this.cmbLoaisach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaisach.Properties.Appearance.Options.UseFont = true;
            this.cmbLoaisach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaisach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbLoaisach.Size = new System.Drawing.Size(445, 30);
            this.cmbLoaisach.TabIndex = 2;
            this.cmbLoaisach.SelectedIndexChanged += new System.EventHandler(this.cmbLoaisach_SelectedIndexChanged);
            // 
            // tgsTinhtrang
            // 
            this.tgsTinhtrang.Location = new System.Drawing.Point(730, 108);
            this.tgsTinhtrang.MenuManager = this.barManager1;
            this.tgsTinhtrang.Name = "tgsTinhtrang";
            this.tgsTinhtrang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgsTinhtrang.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tgsTinhtrang.Properties.Appearance.Options.UseFont = true;
            this.tgsTinhtrang.Properties.Appearance.Options.UseForeColor = true;
            this.tgsTinhtrang.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tgsTinhtrang.Properties.OffText = "Chưa mượn";
            this.tgsTinhtrang.Properties.OnText = "Đã mượn";
            this.tgsTinhtrang.Size = new System.Drawing.Size(218, 33);
            this.tgsTinhtrang.TabIndex = 6;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(263, 183);
            this.txtMota.MenuManager = this.barManager1;
            this.txtMota.Name = "txtMota";
            this.txtMota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Properties.Appearance.Options.UseFont = true;
            this.txtMota.Size = new System.Drawing.Size(733, 54);
            this.txtMota.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl7.Location = new System.Drawing.Point(174, 196);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Mô tả:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl6.Location = new System.Drawing.Point(174, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 23);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Giá tiền:";
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(263, 108);
            this.txtGiatien.MenuManager = this.barManager1;
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Properties.Appearance.Options.UseFont = true;
            this.txtGiatien.Properties.Mask.EditMask = "c";
            this.txtGiatien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiatien.Size = new System.Drawing.Size(445, 30);
            this.txtGiatien.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl5.Location = new System.Drawing.Point(732, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 23);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mã loại:";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Enabled = false;
            this.txtMaloai.Location = new System.Drawing.Point(850, 72);
            this.txtMaloai.MenuManager = this.barManager1;
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloai.Properties.Appearance.Options.UseFont = true;
            this.txtMaloai.Size = new System.Drawing.Size(217, 30);
            this.txtMaloai.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl4.Location = new System.Drawing.Point(732, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 23);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Mã sách:";
            // 
            // txtMasach
            // 
            this.txtMasach.Enabled = false;
            this.txtMasach.Location = new System.Drawing.Point(850, 36);
            this.txtMasach.MenuManager = this.barManager1;
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Properties.Appearance.Options.UseFont = true;
            this.txtMasach.Size = new System.Drawing.Size(217, 30);
            this.txtMasach.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(174, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Giới thiệu:";
            // 
            // txtGioithieu
            // 
            this.txtGioithieu.Location = new System.Drawing.Point(263, 147);
            this.txtGioithieu.MenuManager = this.barManager1;
            this.txtGioithieu.Name = "txtGioithieu";
            this.txtGioithieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioithieu.Properties.Appearance.Options.UseFont = true;
            this.txtGioithieu.Size = new System.Drawing.Size(733, 30);
            this.txtGioithieu.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(174, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Loại sách:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(174, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên sách:";
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(263, 36);
            this.txtTensach.MenuManager = this.barManager1;
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensach.Properties.Appearance.Options.UseFont = true;
            this.txtTensach.Size = new System.Drawing.Size(445, 30);
            this.txtTensach.TabIndex = 1;
            // 
            // ptbHinhsach
            // 
            this.ptbHinhsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbHinhsach.Image = ((System.Drawing.Image)(resources.GetObject("ptbHinhsach.Image")));
            this.ptbHinhsach.Location = new System.Drawing.Point(2, 20);
            this.ptbHinhsach.Margin = new System.Windows.Forms.Padding(0);
            this.ptbHinhsach.Name = "ptbHinhsach";
            this.ptbHinhsach.Padding = new System.Windows.Forms.Padding(15);
            this.ptbHinhsach.Size = new System.Drawing.Size(169, 227);
            this.ptbHinhsach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhsach.TabIndex = 0;
            this.ptbHinhsach.TabStop = false;
            this.ptbHinhsach.Click += new System.EventHandler(this.ptbHinhsach_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 529);
            this.Controls.Add(this.gcChitiet);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSanpham";
            this.Text = "Kho sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).EndInit();
            this.gcChitiet.ResumeLayout(false);
            this.gcChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaisach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTinhtrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiatien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGioithieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTensach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gcChitiet;
        private System.Windows.Forms.PictureBox ptbHinhsach;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMasach;
        private DevExpress.XtraGrid.Columns.GridColumn colTensach;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colView;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtGiatien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaloai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMasach;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGioithieu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTensach;
        private DevExpress.XtraEditors.MemoEdit txtMota;
        private DevExpress.XtraEditors.ToggleSwitch tgsTinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIntro;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colMaloai;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLoaisach;
        private System.Windows.Forms.TreeView tvCategories;
    }
}