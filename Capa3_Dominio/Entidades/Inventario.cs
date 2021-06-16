using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
   public class Inventario
    {
        //private int cantidadBien;
        private DateTime fecha;

        private Usuario usuario;
        private List<DetalleDeInventario> detalleDeInventarios;

        public Inventario()
        {
            detalleDeInventarios = new List<DetalleDeInventario>();
        }

        //public int CantidadBien { get => cantidadBien; set => cantidadBien = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal List<DetalleDeInventario> DetalleDeInventarios { get => detalleDeInventarios; }


      

        public Boolean AgregarDetalleInventario(Bien bien) 
        {
            return true;
        }


        public Double CalcularMontoTotalDeBienesEncontrados()  
        {
            return 1;     
        }

        public Double CalcularMontoTotalDeBienesPerdidos()
        {
            return 1;
        }

        public Boolean TieneDetalleInventario()
        {
            return detalleDeInventarios.Count > 0;
        }


    }
}
