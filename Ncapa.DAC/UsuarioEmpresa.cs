using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Entidades;

namespace Ncapa.DAC
{
    public class UsuarioEmpresa
    {
        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=AppFacultad;Integrated Security=True";

        public int EmpresaDAC(Empresa obe)
        {
            


            string sqlsentencia = "Empresa_insert";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;
            SqlCommand comm = new SqlCommand(sqlsentencia, conn);

            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = obe.Usuario;
            comm.Parameters.Add("@Contraseña", SqlDbType.Int).Value = obe.Contrasenia;
            comm.Parameters.Add("@EmailEm", SqlDbType.NVarChar).Value = obe.Email;
            comm.Parameters.Add("@TelefonoEm", SqlDbType.Int).Value = obe.Telefono;
            comm.Parameters.Add("@Cuit", SqlDbType.Int).Value = obe.Cuit;
            comm.Parameters.Add("@Ubi", SqlDbType.NVarChar).Value = obe.Ubicacion;
            comm.Parameters.Add("@Rol", SqlDbType.Int).Value = obe.IdRol;

            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }

        

    }
}
