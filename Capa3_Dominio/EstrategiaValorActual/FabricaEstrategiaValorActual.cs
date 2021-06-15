using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Properties;

namespace Capa3_Dominio.EstrategiaValorActual
{

    public class FabricaEstrategiaValorActual
    {
        private static FabricaEstrategiaValorActual fabricaEstrategiaValorActual;
        private IEstrategiaValorActual estrategiaValorActual;
        public static FabricaEstrategiaValorActual crearInstancia()
        {
            if (fabricaEstrategiaValorActual == null)
            {
                fabricaEstrategiaValorActual = new FabricaEstrategiaValorActual();
            }
            return fabricaEstrategiaValorActual;
        }
        public IEstrategiaValorActual crearEstrategiaValorActual()
        {
            Type tipoClaseEstrategiaDescuento = Type.GetType(ConfiguracionDeClases.Default.ParametroClaseEstrategiaValorActual);
            estrategiaValorActual = (IEstrategiaValorActual)Activator.CreateInstance(tipoClaseEstrategiaDescuento);
            return estrategiaValorActual;
        }






    }

   
}
