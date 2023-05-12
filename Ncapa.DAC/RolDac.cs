using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Entidades;
using System.Data.SqlClient;

namespace Ncapa.DAC
{
    public class RolDac
    {

        string conexion = "Data Source=DESKTOP-N6B6AO9;Initial Catalog=AppFacultad;Integrated Security=True";
        public DataTable SPRol()
        {


            string sqlsentecia = "SP_Rol ";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;


            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            return ds.Tables[0];


        }
    }
}
