using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Quanlibansach
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmSanpham fSanpham;
        frmRent fRent;
        frmUser fUser;
        frmLoaisach fLoaisach;
        frmPermission fPermission;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Bar bar1 = new Bar();
            BarItemLink link1 = bar1.AddItem(btnDangnhap);
            btnDangnhap_ItemClick(sender, new ItemClickEventArgs(btnDangnhap, link1));

            btnDangxuat.Enabled = false;
            btnKhosach.Enabled = false;
            btnUsers.Enabled = false;
            btnLoaisach.Enabled = false;
            btnPermission.Enabled = false;
            btnRent.Enabled = false;
        }

        public void setSigninPass()
        {
            btnDangnhap.Enabled = false;
            btnDangxuat.Enabled = true;
            btnKhosach.Enabled = true;
            btnUsers.Enabled = true;
            btnLoaisach.Enabled = true;
            btnPermission.Enabled = true;
            btnRent.Enabled = true;
        }

        public void setTxtUserInfo(String info)
        {
            txtUserInfo.Caption = info;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype) return f;
            }
            return null;
        }

        private void btnDangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangnhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangnhap f = new frmDangnhap();
                f.MdiParent = this;
                f.Show();
                f.setTxtUserInfo += setTxtUserInfo;
                f.setSigninPass += setSigninPass;
            }
        }
        
        private void btnDangky_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangky));
            if (frm != null) frm.Activate();
            else
            {
                frmDangky f = new frmDangky();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhosach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSanpham));
            if (frm != null) frm.Activate();
            else
            {
                fSanpham = new frmSanpham();
                fSanpham.MdiParent = this;
                fSanpham.Show();
                if (fRent!=null) fSanpham.refreshProductUserDlg += fRent.refreshProductUser;
                if (fLoaisach != null) fLoaisach.refreshTreeview += fSanpham.refreshTreeview;
            }
        }

        private void btnDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnDangnhap.Enabled = true;
            btnDangxuat.Enabled = false;
            btnKhosach.Enabled = false;
            btnUsers.Enabled = false;

            txtUserInfo.Caption = "Information user";
            Program.user = null;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != null) frm.Close();
            }
        }

        private void btnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmUser));
            if (frm != null) frm.Activate();
            else
            {
                fUser = new frmUser();
                fUser.MdiParent = this;
                fUser.Show();
                if (fRent != null) fUser.refreshProductUserDlg += fRent.refreshProductUser;
                if (fPermission != null) fPermission.refreshPermission += fUser.refreshPermission;
            }
        }

        private void btnLoaisach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLoaisach));
            if (frm != null) frm.Activate();
            else
            {
                fLoaisach = new frmLoaisach();
                fLoaisach.MdiParent = this;
                fLoaisach.Show();
                if (fSanpham != null) fLoaisach.refreshTreeview += fSanpham.refreshTreeview;
            }
        }

        private void btnPermission_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPermission));
            if (frm != null) frm.Activate();
            else
            {
                fPermission = new frmPermission();
                fPermission.MdiParent = this;
                fPermission.Show();
                if (fUser != null) fPermission.refreshPermission += fUser.refreshPermission;
            }
        }

        private void btnRent_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRent));
            if (frm != null) frm.Activate();
            else
            {
                fRent = new frmRent();
                fRent.MdiParent = this;
                fRent.Show();
                if (fUser != null) fUser.refreshProductUserDlg += fRent.refreshProductUser;
                if (fSanpham != null) fSanpham.refreshProductUserDlg += fRent.refreshProductUser;
            }
        }
    }
}