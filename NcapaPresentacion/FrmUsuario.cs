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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            getallCombo();
        }
        public DataTable getallCombo()
        {

            RolBC oRolbc = new RolBC();





            DataTable dt = oRolbc.Roless();

            cboRoles.DataSource = null;

            cboRoles.DataSource = dt;
            cboRoles.DisplayMember = "Rol";
            cboRoles.ValueMember = "IdRol";


            return dt;

        }

        private void Agregar()
        {
            insert oInsert = new insert();

            oInsert.Usuario = txtApellidoNombre.Text;
            oInsert.Contrasenia = int.Parse(txtContraUs.Text);
            oInsert.Edad =int.Parse( txtEdad.Text);
            oInsert.Telefono = int.Parse(txtTelefonoUs.Text);
            oInsert.Email = txtEmail.Text;
            oInsert.Ubicacion = txtUbicacionUs.Text;
            oInsert.IdRol = int.Parse(cboRoles.SelectedValue.ToString());


            App oapp = new App();
            var rest = oapp.insert(oInsert);






        }

        private void button2_Click(object sender, EventArgs e)
        {

            Agregar();
            MessageBox.Show("Registro exitoso");
            borrar();
        }

        private void btnAtrasU_Click(object sender, EventArgs e)
        {
            FrmUsuario_Empresa oFrmUsuario_Empresa = new FrmUsuario_Empresa();
            this.Hide();
            oFrmUsuario_Empresa.Show();
        }

        private void btnSiguienteU_Click(object sender, EventArgs e)
        {
            
            Login ologin = new Login();
            this.Hide();
            ologin.Show();
        }


        public void borrar()
        {
            txtApellidoNombre.Focus();

            txtApellidoNombre.Clear();
            txtContraUs.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
            txtTelefonoUs.Clear();
            txtUbicacionUs.Clear();




        }
    }
}
