using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyec.v1.Entidades
{
    public class Usuario
    {
        public int Cedula { get; set; }
        public string NombreCompleto { get; set; }

        public string rol { get; set; }

        public string FechaMOdificacion { get; set; }

        public string Clave { get; set; }

    }
}
