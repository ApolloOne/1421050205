using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNgocTien1421050205.CustomControls
{
    public partial class Product : UserControl
    {

        private string _productID = string.Empty;

        private Image _image = null;
        private string _firstDecreption = string.Empty;
        private string _secondDecreption = string.Empty;

        public Image Image { get => _image; set => _image = value; }
        public string FirstDecreption { get => _firstDecreption; set => _firstDecreption = value; }
        public string SecondDecreption { get => _secondDecreption; set => _secondDecreption = value; }
        public string ProductID { get => _productID; set => _productID = value; }

        /// <summary>
        /// Contructor without aguments
        /// </summary>
        public Product()
        {

        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="image"></param>
        /// <param name="firstDec"></param>
        /// <param name="secondDecr"></param>
        public Product(Image image, string firstDec, string secondDecr )
        {

            this.Image = image;
            this.FirstDecreption = firstDec;
            this.SecondDecreption = secondDecr;


            InitializeComponent();
        }

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Product_Load(object sender, EventArgs e)
        {
            this.PIC_ProductImage.Image = this.Image;
            this.TXT_FirstDecr.Text = this.FirstDecreption;
            this.TXT_SecondDecr.Text = this.SecondDecreption;
        }

        private void BTN_Buy_Click(object sender, EventArgs e)
        {
            //TODO:Logic here
            var a = string.Empty;
        }
    }
}
