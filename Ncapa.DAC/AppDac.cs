using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Entidades;
using System.Data.SqlClient;
using System.Data;


namespace Ncapa.DAC
{

    public class AppDac
    {
        string conexion = "Data Source =DESKTOP-N6B6AO9;Initial Catalog = AppFacultad; Integrated Security=True";

        public int GetAll(login obe)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = conexion;





            conn.Open();


            string sqlsentecia = "Get_All";



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = obe.Usuario;
            comm.Parameters.Add("@Constraseña", SqlDbType.Int).Value = obe.Contrasenia;

            

            IDataReader _reader = comm.ExecuteReader();
            int resultado;
            if (_reader.Read())

                resultado = 1;
            else

                resultado = 0;




            conn.Close();


            return resultado;
        }



        public int insertapp(insert obe)
        {


            string sqlsentencia = "Usuario_insert";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;
            SqlCommand comm = new SqlCommand(sqlsentencia, conn);

            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = obe.Usuario;
            comm.Parameters.Add("@Contraseña", SqlDbType.Int).Value = obe.Contrasenia;           
            comm.Parameters.Add("@EmailEm", SqlDbType.NVarChar).Value = obe.Email;
            comm.Parameters.Add("@TelefonoEm", SqlDbType.Int).Value = obe.Telefono;
            comm.Parameters.Add("@EdadEm", SqlDbType.Int).Value = obe.Edad;
            comm.Parameters.Add("@UbicacionEm", SqlDbType.NVarChar).Value = obe.Ubicacion;
            comm.Parameters.Add("@Rol", SqlDbType.Int).Value = obe.IdRol;
                              
            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }


        public int EmpresaInsert(Empresa obe)
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
            comm.Parameters.Add("@UbicacionEm", SqlDbType.NVarChar).Value = obe.Ubicacion;
            comm.Parameters.Add("@Rol", SqlDbType.Int).Value = obe.IdRol;
            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }

        //    comm.ExecuteNonQuery();
        //    IDataReader _reader = comm.ExecuteReader();
        //    int resultado;
        //    if (_reader.Read())

        //        resultado = 1;
        //    else

        //        resultado = 0;




        //    conn.Close();


        //    return resultado;





        //}


    }


}
