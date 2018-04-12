namespace Quanlibansach
{
    partial class frmRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRent));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcRent = new DevExpress.XtraGrid.GridControl();
            this.gvRent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMathue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMauser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ptbHinhsach = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMasach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMauser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcChitiet = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMathue = new DevExpress.XtraEditors.TextEdit();
            this.tgsTinhtrang = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmbTenuser = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIduser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenuser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTensach = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTensach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaloai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiatien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioithieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMauser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).BeginInit();
            this.gcChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMathue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTinhtrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTensach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
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
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1079, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 451);
            this.barDockControlBottom.Size = new System.Drawing.Size(1079, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 412);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1079, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 412);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcRent);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 39);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1079, 211);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Sách thuê";
            // 
            // gcRent
            // 
            this.gcRent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRent.Location = new System.Drawing.Point(2, 20);
            this.gcRent.MainView = this.gvRent;
            this.gcRent.MenuManager = this.barManager1;
            this.gcRent.Name = "gcRent";
            this.gcRent.Size = new System.Drawing.Size(1075, 189);
            this.gcRent.TabIndex = 1;
            this.gcRent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRent});
            // 
            // gvRent
            // 
            this.gvRent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMathue,
            this.colMasach,
            this.colMauser,
            this.colStatus});
            this.gvRent.GridControl = this.gcRent;
            this.gvRent.Name = "gvRent";
            this.gvRent.OptionsBehavior.Editable = false;
            this.gvRent.OptionsBehavior.ReadOnly = true;
            this.gvRent.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvRent.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMathue
            // 
            this.colMathue.Caption = "Mã thuê";
            this.colMathue.FieldName = "id";
            this.colMathue.Name = "colMathue";
            this.colMathue.Visible = true;
            this.colMathue.VisibleIndex = 0;
            // 
            // colMasach
            // 
            this.colMasach.Caption = "Mã sách";
            this.colMasach.FieldName = "pro_id";
            this.colMasach.Name = "colMasach";
            this.colMasach.Visible = true;
            this.colMasach.VisibleIndex = 1;
            // 
            // colMauser
            // 
            this.colMauser.Caption = "Mã user";
            this.colMauser.FieldName = "user_id";
            this.colMauser.Name = "colMauser";
            this.colMauser.Visible = true;
            this.colMauser.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // ptbHinhsach
            // 
            this.ptbHinhsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbHinhsach.Image = ((System.Drawing.Image)(resources.GetObject("ptbHinhsach.Image")));
            this.ptbHinhsach.Location = new System.Drawing.Point(2, 20);
            this.ptbHinhsach.Margin = new System.Windows.Forms.Padding(0);
            this.ptbHinhsach.Name = "ptbHinhsach";
            this.ptbHinhsach.Padding = new System.Windows.Forms.Padding(15);
            this.ptbHinhsach.Size = new System.Drawing.Size(130, 179);
            this.ptbHinhsach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHinhsach.TabIndex = 0;
            this.ptbHinhsach.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(143, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên sách:";
            // 
            // txtMasach
            // 
            this.txtMasach.Enabled = false;
            this.txtMasach.Location = new System.Drawing.Point(859, 62);
            this.txtMasach.MenuManager = this.barManager1;
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Properties.Appearance.Options.UseFont = true;
            this.txtMasach.Size = new System.Drawing.Size(217, 30);
            this.txtMasach.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl5.Location = new System.Drawing.Point(741, 65);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 23);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mã sách:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl6.Location = new System.Drawing.Point(145, 101);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 23);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Tên user:";
            // 
            // txtMauser
            // 
            this.txtMauser.Enabled = false;
            this.txtMauser.Location = new System.Drawing.Point(859, 98);
            this.txtMauser.MenuManager = this.barManager1;
            this.txtMauser.Name = "txtMauser";
            this.txtMauser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauser.Properties.Appearance.Options.UseFont = true;
            this.txtMauser.Size = new System.Drawing.Size(217, 30);
            this.txtMauser.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(741, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 23);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Mã user:";
            // 
            // gcChitiet
            // 
            this.gcChitiet.Controls.Add(this.labelControl3);
            this.gcChitiet.Controls.Add(this.txtMathue);
            this.gcChitiet.Controls.Add(this.tgsTinhtrang);
            this.gcChitiet.Controls.Add(this.cmbTenuser);
            this.gcChitiet.Controls.Add(this.cmbTensach);
            this.gcChitiet.Controls.Add(this.labelControl1);
            this.gcChitiet.Controls.Add(this.txtMauser);
            this.gcChitiet.Controls.Add(this.labelControl6);
            this.gcChitiet.Controls.Add(this.labelControl5);
            this.gcChitiet.Controls.Add(this.txtMasach);
            this.gcChitiet.Controls.Add(this.labelControl2);
            this.gcChitiet.Controls.Add(this.ptbHinhsach);
            this.gcChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChitiet.Location = new System.Drawing.Point(0, 250);
            this.gcChitiet.Name = "gcChitiet";
            this.gcChitiet.Size = new System.Drawing.Size(1079, 201);
            this.gcChitiet.TabIndex = 14;
            this.gcChitiet.Text = "Chi tiết";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(145, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 23);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Mã thuê:";
            // 
            // txtMathue
            // 
            this.txtMathue.Enabled = false;
            this.txtMathue.Location = new System.Drawing.Point(232, 26);
            this.txtMathue.MenuManager = this.barManager1;
            this.txtMathue.Name = "txtMathue";
            this.txtMathue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMathue.Properties.Appearance.Options.UseFont = true;
            this.txtMathue.Size = new System.Drawing.Size(503, 30);
            this.txtMathue.TabIndex = 20;
            // 
            // tgsTinhtrang
            // 
            this.tgsTinhtrang.Location = new System.Drawing.Point(739, 23);
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
            this.tgsTinhtrang.TabIndex = 19;
            // 
            // cmbTenuser
            // 
            this.cmbTenuser.Location = new System.Drawing.Point(232, 98);
            this.cmbTenuser.MenuManager = this.barManager1;
            this.cmbTenuser.Name = "cmbTenuser";
            this.cmbTenuser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenuser.Properties.Appearance.Options.UseFont = true;
            this.cmbTenuser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTenuser.Properties.View = this.searchLookUpEdit2View;
            this.cmbTenuser.Size = new System.Drawing.Size(503, 30);
            this.cmbTenuser.TabIndex = 18;
            this.cmbTenuser.EditValueChanged += new System.EventHandler(this.cmbTenuser_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIduser,
            this.colTenuser,
            this.colEmail,
            this.colRole});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colIduser
            // 
            this.colIduser.Caption = "Mã user";
            this.colIduser.FieldName = "id";
            this.colIduser.Name = "colIduser";
            this.colIduser.Visible = true;
            this.colIduser.VisibleIndex = 0;
            // 
            // colTenuser
            // 
            this.colTenuser.Caption = "Tên";
            this.colTenuser.FieldName = "name";
            this.colTenuser.Name = "colTenuser";
            this.colTenuser.Visible = true;
            this.colTenuser.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colRole
            // 
            this.colRole.Caption = "Role";
            this.colRole.FieldName = "role";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 3;
            // 
            // cmbTensach
            // 
            this.cmbTensach.Location = new System.Drawing.Point(232, 62);
            this.cmbTensach.MenuManager = this.barManager1;
            this.cmbTensach.Name = "cmbTensach";
            this.cmbTensach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTensach.Properties.Appearance.Options.UseFont = true;
            this.cmbTensach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTensach.Properties.View = this.searchLookUpEdit1View;
            this.cmbTensach.Size = new System.Drawing.Size(503, 30);
            this.cmbTensach.TabIndex = 17;
            this.cmbTensach.EditValueChanged += new System.EventHandler(this.cmbTensach_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colTensach,
            this.colMaloai,
            this.colGiatien,
            this.colGioithieu,
            this.colMota});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Mã sách";
            this.colId.FieldName = "id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colTensach
            // 
            this.colTensach.Caption = "Tên sách";
            this.colTensach.FieldName = "name";
            this.colTensach.Name = "colTensach";
            this.colTensach.Visible = true;
            this.colTensach.VisibleIndex = 1;
            // 
            // colMaloai
            // 
            this.colMaloai.Caption = "Mã loại";
            this.colMaloai.FieldName = "cate_id";
            this.colMaloai.Name = "colMaloai";
            this.colMaloai.Visible = true;
            this.colMaloai.VisibleIndex = 2;
            // 
            // colGiatien
            // 
            this.colGiatien.Caption = "Giá tiền";
            this.colGiatien.FieldName = "price";
            this.colGiatien.Name = "colGiatien";
            this.colGiatien.Visible = true;
            this.colGiatien.VisibleIndex = 3;
            // 
            // colGioithieu
            // 
            this.colGioithieu.Caption = "Giới thiệu";
            this.colGioithieu.FieldName = "intro";
            this.colGioithieu.Name = "colGioithieu";
            this.colGioithieu.Visible = true;
            this.colGioithieu.VisibleIndex = 4;
            // 
            // colMota
            // 
            this.colMota.Caption = "Mô tả";
            this.colMota.FieldName = "description";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 5;
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 451);
            this.Controls.Add(this.gcChitiet);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRent";
            this.Text = "Sách thuê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMauser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).EndInit();
            this.gcChitiet.ResumeLayout(false);
            this.gcChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMathue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsTinhtrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTensach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcRent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRent;
        private DevExpress.XtraGrid.Columns.GridColumn colMathue;
        private DevExpress.XtraGrid.Columns.GridColumn colMasach;
        private DevExpress.XtraGrid.Columns.GridColumn colMauser;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.GroupControl gcChitiet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMauser;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMasach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox ptbHinhsach;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTenuser;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbTensach;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTensach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaloai;
        private DevExpress.XtraGrid.Columns.GridColumn colGiatien;
        private DevExpress.XtraGrid.Columns.GridColumn colGioithieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraGrid.Columns.GridColumn colIduser;
        private DevExpress.XtraGrid.Columns.GridColumn colTenuser;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMathue;
        private DevExpress.XtraEditors.ToggleSwitch tgsTinhtrang;
    }
}