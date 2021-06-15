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
   public class RealizarLoginServicio

    {
        private UsuarioSQLServer usuarioDAO;
        private GestorSQLServer gestorAccesoDatos;

        public RealizarLoginServicio()
        {
            gestorAccesoDatos = new GestorSQLServer();
            usuarioDAO = new UsuarioSQLServer(gestorAccesoDatos);

        }

        public void ValidarLogin(string dni, string contrasena)
        {
            gestorAccesoDatos.AbrirConexion();
            usuarioDAO.ValidarLogin(dni, contrasena);
            gestorAccesoDatos.CerrarConexion();
        }       

        public Usuario BuscarUsuarioPorDni(string dni)
        {
            gestorAccesoDatos.AbrirConexion();
            Usuario usu = usuarioDAO.BuscarUsuarioPorDni(dni);
            gestorAccesoDatos.CerrarConexion();

            return usu;
        }
        public void ValidarTecnico(Usuario usuario)
        {
            RealizarLogin realizarLogin = new RealizarLogin();
            realizarLogin.ValidarCargoUsuario(usuario);
        }


    }
}
