using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Servicios;
using Capa3_Dominio.Contratos;
using Capa4_Persistencia.ADONet_SQLServer;
using Capa4_Persistencia.FabricaPersistencia;

namespace Capa2_Aplicación.Servicios
{
    public class ReportarTotalDePerdidasEnBienesServicio
    {

        private IGestorAccesoDeDatos gestorAccesoDatos;
        private IBienPersistencia bienDAO;
        private IAreaPersistencia areaDAO;
        //  private GestorSQLServer gestorAccesoDatos;
        // private BienSQLServer bienDAO;
        // private UsuarioSQLServer usuarioDAO;
        // private MovimientoSQLServer movimientoDAO;
        public ReportarTotalDePerdidasEnBienesServicio()
        {
            gestorAccesoDatos = FabricaAbstractaDePersistencia.CrearInstancia().CrearGestorAccesoDeDatos();
            bienDAO = FabricaAbstractaDePersistencia.CrearInstancia().CrearBienPersistencia(gestorAccesoDatos);
            areaDAO= FabricaAbstractaDePersistencia.CrearInstancia().CrearAreaPersistencia(gestorAccesoDatos);
        }
        public List<Area> ListarAreas()
        {
            gestorAccesoDatos.AbrirConexion();
            List<Area> are =areaDAO.ListarArea();
            gestorAccesoDatos.CerrarConexion();
            return are;
        }
        public List<Bien> BuscarBienes(DateTime fechaminima, DateTime fechamaxima, String area)
        {
            gestorAccesoDatos.AbrirConexion();
            List<Bien> bienes = bienDAO.BuscarPorFechaYArea(fechaminima,fechamaxima,area);
            gestorAccesoDatos.CerrarConexion();
            
            return bienes;

        }

        public double CalcularPromedioDePerdidas(List<Bien> bienes )
        {
            double promedio=0;
            return promedio;

        }
        public double SumaTotalDeBienesPerdidos(List<Bien> bienes)
        {
            double suma = 0;
            return suma;

        }
        public double CantidadDeBienesPerdidos(List<Bien> bienes)
        {
            double cantidad= 0;
            return cantidad;

        }


      




    }
}
