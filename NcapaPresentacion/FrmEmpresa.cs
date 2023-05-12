using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ncapa.Entidades;
using Ncapa.BC;



namespace NcapaPresentacion
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
            getallCombo();
        }


        public DataTable getallCombo()
        {

            RolBC oRolbc = new RolBC();
            
            DataTable dt = oRolbc.Roless();

            cboRoless.DataSource = null;

            cboRoless.DataSource = dt;
            cboRoless.DisplayMember = "Rol";
            cboRoless.ValueMember = "IdRol";


            return dt;

        }
        public void guardar()
        {


            Empresa oempresa = new Empresa();
            oempresa.Usuario = txtApellidoNombre.Text;
            oempresa.Contrasenia = int.Parse(txtContraEm.Text);
            oempresa.Email = txtEmailEm.Text;
            oempresa.Telefono = int.Parse(txtTelefonoEm.Text);
            oempresa.Cuit = int.Parse(txtCuitEm.Text);
            oempresa.Ubicacion = txtUbicacionEm.Text;
            oempresa.IdRol = int.Parse(cboRoless.SelectedValue.ToString());

            EmpresaBC oinsertapp = new EmpresaBC();

            var rest = oinsertapp.GetAllEmpresa(oempresa);



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Login ologin = new Login();
            this.Hide();
            ologin.Show();
        }

        private void btnAtrasE_Click(object sender, EventArgs e)
        {
            FrmUsuario_Empresa oFrmUsuario_Empresa = new FrmUsuario_Empresa();
            this.Hide();
            oFrmUsuario_Empresa.Show();
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
           

            guardar();
            MessageBox.Show("Registro exitoso");
            borrar();
        }
        public void borrar()
        {
            txtApellidoNombre.Focus();

            txtApellidoNombre.Clear();
            txtContraEm.Clear();

            txtTelefonoEm.Clear();
            txtUbicacionEm.Clear();
            txtEmailEm.Clear();
            txtCuitEm.Clear();




        }
    }
}
