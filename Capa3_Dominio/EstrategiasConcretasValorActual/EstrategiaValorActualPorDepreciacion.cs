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
    public class EstrategiaValorActualPorDepreciacion : IEstrategiaValorActual
    {

        public double CalcularValorActual(Bien bien)
        {
          
            return (bien.Precio*(1-(bien.Depreciacion/100)));
        }






    }
}
