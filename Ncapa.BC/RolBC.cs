using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ncapa.Entidades;
using Ncapa.DAC;

namespace Ncapa.BC
{
 public   class RolBC
    {

        public DataTable Roless()
        {

            RolDac oRoles = new RolDac();
            return oRoles.SPRol();
        }


    }
}
