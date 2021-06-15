using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Servicios;
using Capa4_Persistencia.ADONet_SQLServer;


namespace Capa2_Aplicación.Servicios
{
    public class ReportarTotalDePerdidasEnBienesServicio
    {

        // private MovimientoDeBien movimiento
      //  private GestorSQLServer gestorAccesoDatos;
       // private BienSQLServer bienDAO;
       // private UsuarioSQLServer usuarioDAO;
       // private MovimientoSQLServer movimientoDAO;


        public List<Bien> BuscarBienes(DateTime fechaminima, DateTime fechamaxima, String area)
        {
            List<Bien> bienes = new List<Bien>();
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


        public List<Area> ListarAreas()
        {
            List<Area> areas= new List<Area>();
            

            return areas;
        }




    }
}
