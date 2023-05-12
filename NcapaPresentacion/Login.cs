using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ncapa.BC;
using Ncapa.Entidades;

namespace NcapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlc = new SqlConnection("Data Source=DESKTOP-N6B6AO9;Initial Catalog=AppFacultad;Integrated Security=True");

        public void loguear(string Usuario, string Contrasenia)

        {

            try
            {


                sqlc.Open();
                string g = "select l.Usuario,r.Rol from Login as l , Rol as r where l.IdRol=r.IdRol";
                SqlCommand cmd = new SqlCommand("select l.Usuario,l.Contrasenia,r.Rol from Login l, Rol r where l.Usuario =@Usuario and l.Contrasenia =@contra and  r.IdRol = l.IdRol", sqlc);
                cmd.Parameters.AddWithValue("Usuario", Usuario);
                cmd.Parameters.AddWithValue("contra", Contrasenia);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count == 1)
                {

                    {



                        if (dt.Rows[0][2].ToString() == "Persona")
                        {

                            MessageBox.Show("Bienvendido usuario Persona");
                           
                            FrmByCSala oform = new FrmByCSala();

                            oform.Show();
                            this.Hide();
                            

                        }
                        else if (dt.Rows[0][2].ToString() == "Empresa")
                        {


                            MessageBox.Show("Bienvendido usuario Empresa");
                            FrmByCSala oform = new FrmByCSala();

                            oform.Show();
                            this.Hide();
                         


                        }



                    }
                   


                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Error. Usuario no encontrado");
                    this.Hide();
                    Login ologin = new Login();
                    ologin.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlc.Close();

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUsuario_Empresa oFrmUsuario_Empresa = new FrmUsuario_Empresa();
            this.Hide();

            oFrmUsuario_Empresa.Show();


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            loguear(this.txtUsuario.Text, this.txtContrasenia.Text);

        }

    

    }
}
