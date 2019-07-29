using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NguyenNgocTien1421050205.CustomControls;

namespace NguyenNgocTien1421050205
{
    public partial class subSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static subSanPham _sanPham;
        public static subSanPham Init
        {
            get
            {
                if (_sanPham == null)
                {
                    _sanPham = new subSanPham();
                }
                return _sanPham;
            }
        }
        public subSanPham()
        {
            InitializeComponent();
            this.CreateProduct();
        }

        //private void subSanPham_Load(object ojb, EventArgs e)
        //{
        //    for (int productIndex = 0; productIndex <=5; productIndex++)
        //    {
        //        Product newPro = new Product();
        //        newPro.FirstDecreption = productIndex.ToString();
        //        newPro.FirstDecreption = string.Format("1{0}", productIndex);


        //        newPro.Width = 100;
        //        newPro.Height = 100;

        //        this.PNL_Product.Controls.Add(newPro);
                
        //    }
        //}


        private void CreateProduct()
        {
            for (int productIndex = 0; productIndex <= 5; productIndex++)
            {
                Product newPro = new Product(null,"123","123123123");
                //newPro.FirstDecreption = productIndex.ToString();
                //newPro.SecondDecreption = string.Format("1{0}", productIndex);


                newPro.Width = 390;
                newPro.Height = 261;

                this.PNL_Product.Controls.Add(newPro);

            }
            //subDoiTac sb = new subDoiTac();
            //this.PNL_Product.Controls.Add(sb);
        }
    }
}
