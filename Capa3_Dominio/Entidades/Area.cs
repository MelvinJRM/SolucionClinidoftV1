using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
   public class Area
    {
        private Boolean activado;
        private String nombre;
        private String idArea;

        public Boolean Activado { get => activado; set => activado = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String IdArea { get => idArea; set => idArea = value; }
    }
}
