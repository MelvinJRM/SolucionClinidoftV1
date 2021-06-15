using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
  public class DetalleMovimiento
    {

        private Boolean bienEncontrado;
        
        private Bien bien;

      
        public Bien Bien { get => bien; set => bien = value; }
        public Boolean BienEncontrado { get => bienEncontrado; set => bienEncontrado = value; }

        public DetalleMovimiento(Bien bien)
        {
            this.bien = bien;
            bienEncontrado = bien.Encontrado;
            
        }

        public Boolean ValidarEstadoDeBien() 
        {          
            return bienEncontrado;
        }

      


        
    }
}
