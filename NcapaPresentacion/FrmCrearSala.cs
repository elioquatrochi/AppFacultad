using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NcapaPresentacion
{
    public partial class FrmCrearSala : Form
    {
        public FrmCrearSala()
        {
            InitializeComponent();
        }

        private void btnAtrasE_Click(object sender, EventArgs e)
        {

            FrmByCSala ofrm = new FrmByCSala();
            this.Hide();

            ofrm.Show();

        }
    }
}
