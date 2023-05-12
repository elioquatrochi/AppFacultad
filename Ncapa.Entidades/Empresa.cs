using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncapa.Entidades
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public int Contrasenia { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        
        public int Cuit { get; set; }

        public int Edad { get; set; }
        public string Ubicacion { get; set; }
        public int IdRol { get; set; }


    }

}
