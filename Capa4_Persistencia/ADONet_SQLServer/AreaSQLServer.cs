using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Contratos;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class AreaSQLServer :IAreaPersistencia
    {
        private GestorSQLServer gestorSQL;

        public AreaSQLServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public List<Area> ListarArea()
        {
            List<Area> listaDeAreas = new List<Area>();
            Area area;
            string consultaSQL = "select idArea,nombre from Area where activado=1";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    area = ObtenerArea(resultadoSQL);
                    listaDeAreas.Add(area);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return listaDeAreas;
        }
        //public Area BuscarAreaPorID(int idA)
        //{
        //    Area area;
        //    string consultaSQL = "select idArea,nombre  from Area where idArea = '" + idA + "'";
        //    try
        //    {
        //        SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
        //        if (resultadoSQL.Read())
        //        {
        //            area = ObtenerArea(resultadoSQL);
        //        }
        //        else
        //        {
        //            throw new Exception("No existe el AREA.");
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        throw err;
        //    }
        //    return area;
        //}
        private Area ObtenerArea(SqlDataReader resultadoSQL)
        {
            Area ar = new Area();
            ar.IdArea= resultadoSQL.GetString(0);
            ar.Nombre = resultadoSQL.GetString(1);
            return ar;
        }





    }
}
