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
    public partial class FrmByCSala : Form
    {
        public FrmByCSala()
        {
            InitializeComponent();
        }

        private void btnCrearS_Click(object sender, EventArgs e)
        {
            FrmCrearSala oFrmCrearSala = new FrmCrearSala();
            this.Hide();
            oFrmCrearSala.Show();
        }

        private void btnBuscarS_Click(object sender, EventArgs e)
        {
            FrmBuscarSala oFrmBuscarSala = new FrmBuscarSala();
            this.Hide();
           oFrmBuscarSala.Show();
        }

        private void btnAtrasE_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login ologin = new Login();
            ologin.Show();



        }
    }
}
