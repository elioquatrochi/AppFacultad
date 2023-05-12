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
    public partial class FrmUsuario_Empresa : Form
    {
        public FrmUsuario_Empresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmEmpresa oFrmEmpresa = new FrmEmpresa();
            this.Hide();
            oFrmEmpresa.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmUsuario oFrmUsuario = new FrmUsuario();
            this.Hide();
            oFrmUsuario.Show();



        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            this.Hide();
            oFrmUsuario.Show();
        }

        private void btnAtrasE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ologin = new Login();
            ologin.Show();
        }
    }
}
