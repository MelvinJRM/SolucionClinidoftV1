using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.EstrategiaValorActual;

namespace Capa3_Dominio.EstrategiasConcretasValorActual
{
    public class EstrategiaValorActualSinDepreciacion : IEstrategiaValorActual
    {

        public double CalcularValorActual(Bien bien)
        {
            return bien.Precio;
        }
    }
}
