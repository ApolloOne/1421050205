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
    public partial class subDoiTac : DevExpress.XtraEditors.XtraUserControl
    {
        private static subDoiTac _doitac;
        public static subDoiTac Init
        {
            get
            {
                if (_doitac == null)
                {
                    _doitac = new subDoiTac();
                }
                return _doitac;
            }
        }
        public subDoiTac()
        {
            InitializeComponent();
        }
    }
}
