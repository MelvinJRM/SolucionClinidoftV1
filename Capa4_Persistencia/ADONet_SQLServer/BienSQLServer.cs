using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Contratos;
namespace Capa4_Persistencia.ADONet_SQLServer
{
   public class BienSQLServer :IBienPersistencia
    {
        private GestorSQLServer gestorSQL;
        public BienSQLServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        //
        public List<Bien> BuscarBienPorDniUsuario(string dni)
        {
            List<Bien> listaDeBienes = new List<Bien>();
            Bien bien;
            string consultaSQL = "select b.idBien,b.categoria,b.marca,b.modelo,b.serie,b.encontrado, b.precio, b.depreciacion, b.fecha from Bien b inner join Usuario u on b.idUsuario = u.idUsuario and u.dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    bien = ObtenerBien(resultadoSQL);
                    listaDeBienes.Add(bien);
                }
            }
            catch (Exception er)
            {
                throw er;
            }

            return listaDeBienes;
        }

        private Bien ObtenerBien(SqlDataReader resultadoSQL)
        {
            Bien bien = new Bien();
            bien.IdBien = resultadoSQL.GetString(0);
            bien.Categoria = resultadoSQL.GetString(1);
            bien.Marca = resultadoSQL.GetString(2);
            bien.Modelo = resultadoSQL.GetString(3);
            bien.Serie = resultadoSQL.GetString(4);
            bien.Encontrado = resultadoSQL.GetBoolean(5);
            bien.Precio = resultadoSQL.GetDouble(6);
            bien.Depreciacion = resultadoSQL.GetDouble(7);
            bien.Fecha = resultadoSQL.GetDateTime(8);
            return bien;
        }


        //
        public Bien BuscarBienPorId(String idBien)
        {
            Bien bien;
            string consultaSQL = " select b.idBien,b.categoria,b.marca,b.modelo,b.serie,b.encontrado, b.precio, b.depreciacion, b.fecha from Bien b where b.idBien= '" + idBien + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    bien = ObtenerBien(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Bien");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return bien;
        }
        //
        public List<Bien> BuscarPorFechaYArea(DateTime fechaminima, DateTime fechamaxima, String area)
        {
            //afafafa
            Bien bien;
            List<Bien> listaDeBienes = new List<Bien>();
           
             String consultaSQL = "select  b.idBien,b.categoria,b.marca,b.modelo,b.serie,b.encontrado, b.precio, b.depreciacion, b.fecha" +
                                  "from bien b inner join DetalleInventario di on b.idBien=di.idBien" +
                                  "inner join Inventario i on i.idInventario=di.idInventario " +
                                  "inner join Usuario u on u.idUsuario=b.idUsuario " +
                                  "inner join Area a on u.idArea=a.idArea" +
                                  "where b.encontrado=0 and (i.fecha between '" + fechaminima +"' and '"+ fechamaxima + "') and and a.nombre='"+area+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);

                while (resultadoSQL.Read())
                {

                    bien = ObtenerBien(resultadoSQL);
                    listaDeBienes.Add(bien);
                }

            }
            catch (Exception er)
            {
                throw er;
            }
   
            return listaDeBienes;        
        }

    }
}
