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

namespace NguyenNgocTien1421050205
{
    public partial class subDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        private static subDoanhThu _doitac;
        public static subDoanhThu Init
        {
            get
            {
                if (_doitac == null)
                {
                    _doitac = new subDoanhThu();
                }
                return _doitac;
            }
        }
        public subDoanhThu()
        {
            InitializeComponent();
        }
    }
}
