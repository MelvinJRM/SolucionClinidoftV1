using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa3_Dominio.Entidades;
using Capa3_Dominio.Contratos;

namespace Capa4_Persistencia.ADONet_SQLServer
{
    public class UsuarioSQLServer : IUsuarioPersistencia
    {
        private GestorSQLServer gestorSQL;

        public UsuarioSQLServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public Usuario BuscarUsuarioPorDni(string dni)
        {
            Usuario usuario;
            string consultaSQL = "select u.idUsuario,u.nombres,u.apellidos,u.dni, a.idArea,a.nombre,u.cargo from Usuario u, Area a where a.idArea=u.idArea and u.dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    usuario = ObtenerUsuario(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el Usuario.");
                }
            }
            catch (Exception err)
            {
              throw err;
            }
            return usuario;
        }
        public void ValidarLogin(string dni, string contrasena)
        {
            Usuario usuario= new Usuario();
            string consultaSQL = "select u.dni,u.contrasena from Usuario u where u.dni = '" + dni + "' and u.contrasena = '"+contrasena+"'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.EjecutarConsulta(consultaSQL);
                if (!resultadoSQL.Read())
                {
                    throw new Exception("Datos Invalidos.");
                }
            }
            catch (Exception )
            {
                throw ;
            }
           
        }

        private Usuario ObtenerUsuario(SqlDataReader resultadoSQL)
        {
            Usuario usuario = new Usuario();
           
            usuario.IdUsuario = resultadoSQL.GetString(0);
            usuario.Nombres = resultadoSQL.GetString(1);
            usuario.Apellidos = resultadoSQL.GetString(2);
            usuario.Dni = resultadoSQL.GetString(3);

            usuario.Area1 = new Area();
            usuario.Area1.IdArea = resultadoSQL.GetString(4);
            usuario.Area1.Nombre = resultadoSQL.GetString(5);

            usuario.Cargo= resultadoSQL.GetString(6);
            return usuario;
        }
    }
}
