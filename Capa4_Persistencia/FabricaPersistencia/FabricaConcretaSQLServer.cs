using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Contratos;
using Capa4_Persistencia.ADONet_SQLServer;

namespace Capa4_Persistencia.FabricaPersistencia
{
    public class FabricaConcretaSQLServer : FabricaAbstractaDePersistencia
    {
        public override IAreaPersistencia CrearAreaPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos)
        {
            return new AreaSQLServer(gestorAccesoDeDatos);
        }

        public override IBienPersistencia CrearBienPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos)
        {
            return new BienSQLServer(gestorAccesoDeDatos);
        }

        public override IGestorAccesoDeDatos CrearGestorAccesoDeDatos()
        {
            return new GestorSQLServer();
        }

        public override IMovimientoPersistencia CrearMovimientoPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos)
        {
            return new MovimientoSQLServer(gestorAccesoDeDatos);
        }

        public override IUsuarioPersistencia CrearUsuarioPersistencia(IGestorAccesoDeDatos gestorAccesoDeDatos)
        {
            return new UsuarioSQLServer(gestorAccesoDeDatos);
        }
    }
}
