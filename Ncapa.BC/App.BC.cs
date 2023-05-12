using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Ncapa.DAC;
using Ncapa.Entidades;


namespace Ncapa.BC
{
   public class App
    {
        public int insert(insert oInsert)
        {
            AppDac oApp = new AppDac();

            return oApp.insertapp (oInsert);



        }

        public int loginn (login ologin)
        {
            AppDac oApp = new AppDac();
            return oApp.GetAll(ologin);
        }

        public int GetAllEmpresa(Empresa oempresa)
        {

            UsuarioEmpresa oUsuarioEmpresa = new UsuarioEmpresa();
            return oUsuarioEmpresa.EmpresaDAC(oempresa);
        }

        //public int empresainsertar(Empresa empresain)
        //{
        //    AppDac oApp = new AppDac();

        //    return oApp.EmpresaInsert(empresain);

        //}
    }
}
