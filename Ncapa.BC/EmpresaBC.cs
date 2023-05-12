using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.DAC;
using Ncapa.Entidades;

namespace Ncapa.BC
{
    public class EmpresaBC
    {
        public int GetAllEmpresa(Empresa oempresa)
        {

            UsuarioEmpresa oUsuarioEmpresa = new UsuarioEmpresa();
            return oUsuarioEmpresa.EmpresaDAC(oempresa);
        }

    }
}
