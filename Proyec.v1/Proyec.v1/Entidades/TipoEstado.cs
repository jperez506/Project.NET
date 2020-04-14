using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyec.v1.Entidades
{
    public class TipoEstado
    {
        private int idTipoEstado;  //declarar un atributo

        //public string otroAtributo; //Tambien se puede acceder tiene get/set implicito

        public string descripEstado { get; set; }   //Tambien es una propiedad

        public int codEstado  //Encapsular atributo en una propiedad
        {
            get { return idTipoEstado; }
            set
            {
                if (value == 0)
                {
                    idTipoEstado = 1;
                }
                else
                {
                    idTipoEstado = value;
                }
            }

        }
    }
}
