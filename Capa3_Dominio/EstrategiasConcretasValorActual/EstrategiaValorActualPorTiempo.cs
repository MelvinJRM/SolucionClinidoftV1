using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.EstrategiaValorActual;

namespace Capa3_Dominio.EstrategiasConcretasValorActual
{
    public class EstrategiaValorActualPorTiempo : IEstrategiaValorActual
    {

        public double CalcularValorActual(Bien bien)
        {
            int aux = DateTime.Now.Year-bien.Fecha.Year;
         
            double valor=1;
            if (aux <=1)
            {
                valor = 0.9;
            }
            else if (aux <= 3)
            {
                valor = 0.75;
            }
            else if (aux <= 5)
            {
                valor = 0.6;
            }
            else
            {
                valor = 0.5;
            }           
            return (bien.Precio*valor);
        }

    }
}
