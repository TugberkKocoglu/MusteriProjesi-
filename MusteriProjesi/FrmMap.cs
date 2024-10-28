using System;
using System.Windows.Forms;

namespace MusteriProjesi
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
        }

        private void btnSehirAc_Click(object sender, EventArgs e)
        {
            FrmCity frmCity = new FrmCity();
            frmCity.Show();
        }
    }
}
