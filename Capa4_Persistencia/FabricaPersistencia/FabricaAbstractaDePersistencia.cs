using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Contratos;
using Capa4_Persistencia.Properties;

namespace Capa4_Persistencia.FabricaPersistencia
{
    public abstract class FabricaAbstractaDePersistencia
    {
        public static FabricaAbstractaDePersistencia CrearInstancia()
        {
            Type tipoClaseFabricaDePersistencia = Type.GetType(ConfiguracionDeClases.Default.ParametroClaseFabricaDePersistencia);
            FabricaAbstractaDePersistencia fabricaConcretaDePersistencia = (FabricaAbstractaDePersistencia)Activator.CreateInstance(tipoClaseFabricaDePersistencia);
            return fabricaConcretaDePersistencia;
        }
        public abstract IGestorAccesoDeDatos CrearGestorAccesoDeDatos();
        public abstract IUsuarioPersistencia CrearUsuarioPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos);
        public abstract IMovimientoPersistencia CrearMovimientoPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos);
        public abstract IBienPersistencia CrearBienPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos);
        public abstract IAreaPersistencia CrearAreaPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos);
    }


}
