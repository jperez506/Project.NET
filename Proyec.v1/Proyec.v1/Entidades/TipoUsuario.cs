using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyec.v1.Entidades
{
    public class TipoUsuario
    {
        private int idTipoUsuario;  //declarar un atributo

        //public string otroAtributo; //Tambien se puede acceder tiene get/set implicito

        public string descripU { get; set; }   //Tambien es una propiedad

        public int codTipo  //Encapsular atributo en una propiedad
        {
            get { return idTipoUsuario; }
            set
            {
                if (value == 0)
                {
                    idTipoUsuario = 1;
                }
                else
                {
                    idTipoUsuario = value;
                }
            }

        }


    }
}
