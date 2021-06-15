using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
   public class DetalleDeInventario
    {
        private Boolean bienEncontrado;

        private Bien Bien;
        private Inventario Inventario;

        public bool BienEncontrado { get => bienEncontrado; set => bienEncontrado = value; }
        internal Bien Bien1 { get => Bien; set => Bien = value; }
        internal Inventario Inventario1 { get => Inventario; set => Inventario = value; }


        public bool EstaBienEncontrado()
        {
            return Bien.Encontrado;
        }

    }
}
