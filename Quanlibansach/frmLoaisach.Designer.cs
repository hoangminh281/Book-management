namespace Quanlibansach
{
    partial class frmLoaisach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaisach));
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
            this.gcChitiet = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMapid = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenparent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaisach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaloai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ptbHinhsach = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tlLoaisach = new DevExpress.XtraTreeList.TreeList();
            this.colTenloai = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).BeginInit();
            this.gcChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenparent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaisach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlLoaisach)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Size = new System.Drawing.Size(1079, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 482);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1079, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 482);
            // 
            // gcChitiet
            // 
            this.gcChitiet.Controls.Add(this.labelControl1);
            this.gcChitiet.Controls.Add(this.txtMapid);
            this.gcChitiet.Controls.Add(this.cmbTenparent);
            this.gcChitiet.Controls.Add(this.txtMota);
            this.gcChitiet.Controls.Add(this.labelControl7);
            this.gcChitiet.Controls.Add(this.labelControl6);
            this.gcChitiet.Controls.Add(this.txtLoaisach);
            this.gcChitiet.Controls.Add(this.labelControl5);
            this.gcChitiet.Controls.Add(this.txtMaloai);
            this.gcChitiet.Controls.Add(this.labelControl2);
            this.gcChitiet.Controls.Add(this.ptbHinhsach);
            this.gcChitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChitiet.Location = new System.Drawing.Point(0, 250);
            this.gcChitiet.Name = "gcChitiet";
            this.gcChitiet.Size = new System.Drawing.Size(1079, 271);
            this.gcChitiet.TabIndex = 12;
            this.gcChitiet.Text = "Chi tiết";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl1.Location = new System.Drawing.Point(738, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 23);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Mã PID:";
            // 
            // txtMapid
            // 
            this.txtMapid.Enabled = false;
            this.txtMapid.Location = new System.Drawing.Point(856, 59);
            this.txtMapid.MenuManager = this.barManager1;
            this.txtMapid.Name = "txtMapid";
            this.txtMapid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapid.Properties.Appearance.Options.UseFont = true;
            this.txtMapid.Size = new System.Drawing.Size(217, 30);
            this.txtMapid.TabIndex = 15;
            // 
            // cmbTenparent
            // 
            this.cmbTenparent.Location = new System.Drawing.Point(254, 59);
            this.cmbTenparent.MenuManager = this.barManager1;
            this.cmbTenparent.Name = "cmbTenparent";
            this.cmbTenparent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenparent.Properties.Appearance.Options.UseFont = true;
            this.cmbTenparent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTenparent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTenparent.Size = new System.Drawing.Size(460, 30);
            this.cmbTenparent.TabIndex = 2;
            this.cmbTenparent.SelectedIndexChanged += new System.EventHandler(this.cmbTenparent_SelectedIndexChanged);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(254, 95);
            this.txtMota.MenuManager = this.barManager1;
            this.txtMota.Name = "txtMota";
            this.txtMota.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Properties.Appearance.Options.UseFont = true;
            this.txtMota.Size = new System.Drawing.Size(748, 164);
            this.txtMota.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl7.Location = new System.Drawing.Point(140, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Mô tả:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl6.Location = new System.Drawing.Point(140, 62);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 23);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Tên parent:";
            // 
            // txtLoaisach
            // 
            this.txtLoaisach.Location = new System.Drawing.Point(254, 23);
            this.txtLoaisach.MenuManager = this.barManager1;
            this.txtLoaisach.Name = "txtLoaisach";
            this.txtLoaisach.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaisach.Properties.Appearance.Options.UseFont = true;
            this.txtLoaisach.Properties.Mask.EditMask = "c";
            this.txtLoaisach.Size = new System.Drawing.Size(460, 30);
            this.txtLoaisach.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl5.Location = new System.Drawing.Point(738, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 23);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Mã loại:";
            // 
            // txtMaloai
            // 
            this.txtMaloai.Enabled = false;
            this.txtMaloai.Location = new System.Drawing.Point(856, 23);
            this.txtMaloai.MenuManager = this.barManager1;
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloai.Properties.Appearance.Options.UseFont = true;
            this.txtMaloai.Size = new System.Drawing.Size(217, 30);
            this.txtMaloai.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(140, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Loại sách:";
            // 
            // ptbHinhsach
            // 
            this.ptbHinhsach.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbHinhsach.Image = ((System.Drawing.Image)(resources.GetObject("ptbHinhsach.Image")));
            this.ptbHinhsach.Location = new System.Drawing.Point(2, 20);
            this.ptbHinhsach.Margin = new System.Windows.Forms.Padding(0);
            this.ptbHinhsach.Name = "ptbHinhsach";
            this.ptbHinhsach.Padding = new System.Windows.Forms.Padding(15);
            this.ptbHinhsach.Size = new System.Drawing.Size(130, 249);
            this.ptbHinhsach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbHinhsach.TabIndex = 0;
            this.ptbHinhsach.TabStop = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tlLoaisach);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 39);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1079, 211);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Loại sách";
            // 
            // tlLoaisach
            // 
            this.tlLoaisach.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTenloai,
            this.colDescription});
            this.tlLoaisach.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlLoaisach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlLoaisach.KeyFieldName = "id";
            this.tlLoaisach.Location = new System.Drawing.Point(2, 20);
            this.tlLoaisach.Name = "tlLoaisach";
            this.tlLoaisach.OptionsBehavior.PopulateServiceColumns = true;
            this.tlLoaisach.ParentFieldName = "parent_id";
            this.tlLoaisach.Size = new System.Drawing.Size(1075, 189);
            this.tlLoaisach.TabIndex = 0;
            this.tlLoaisach.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlLoaisach_FocusedNodeChanged);
            // 
            // colTenloai
            // 
            this.colTenloai.Caption = "Tên loại";
            this.colTenloai.FieldName = "name";
            this.colTenloai.Name = "colTenloai";
            this.colTenloai.Visible = true;
            this.colTenloai.VisibleIndex = 0;
            this.colTenloai.Width = 264;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 264;
            // 
            // frmLoaisach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 521);
            this.Controls.Add(this.gcChitiet);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLoaisach";
            this.Text = "Loại sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaisach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChitiet)).EndInit();
            this.gcChitiet.ResumeLayout(false);
            this.gcChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMapid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenparent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaisach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlLoaisach)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl gcChitiet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTenparent;
        private DevExpress.XtraEditors.MemoEdit txtMota;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaloai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox ptbHinhsach;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMapid;
        private DevExpress.XtraEditors.TextEdit txtLoaisach;
        private DevExpress.XtraTreeList.TreeList tlLoaisach;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTenloai;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
    }
}