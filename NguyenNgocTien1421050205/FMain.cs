using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NguyenNgocTien1421050205
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FMain()
        {
            InitializeComponent();
        }


        private void btnSanPham_Click(object sender, EventArgs e)
        {
            //if (!Container.Controls.Contains(subSanPham.Init))
            //{
            //    Container.Controls.Add(subSanPham.Init);
            //    subSanPham.Init.Dock = DockStyle.Fill;
            //    subSanPham.Init.BringToFront();
            //}
            //subSanPham.Init.BringToFront();
            subSanPham sp = new subSanPham();
            Container.Controls.Add(sp);

        }

        private void AceDoiTac_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(subDoiTac.Init))
            {
                Container.Controls.Add(subDoiTac.Init);
                subDoiTac.Init.Dock = DockStyle.Fill;
                subDoiTac.Init.BringToFront();
            }
            subDoiTac.Init.BringToFront();
        }

        private void AceDoanhThu_Click(object sender, EventArgs e)
        {
            if (!Container.Controls.Contains(subDoanhThu.Init))
            {
                Container.Controls.Add(subDoanhThu.Init);
                subDoanhThu.Init.Dock = DockStyle.Fill;
                subDoanhThu.Init.BringToFront();
            }
            subDoanhThu.Init.BringToFront();
        }
    }
}
