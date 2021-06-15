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
    public class RealizarMovimientoDeBienServicio
    {
        private MovimientoDeBien movimiento;
        
        private IGestorAccesoDeDatos gestorAccesoDatos;
        private IBienPersistencia bienDAO;
        private IUsuarioPersistencia usuarioDAO;
        private IMovimientoPersistencia movimientoDAO;

        public MovimientoDeBien Movimiento { get => movimiento; set => movimiento = value; }

        public RealizarMovimientoDeBienServicio()
        {
            movimiento = new MovimientoDeBien();

            gestorAccesoDatos = FabricaAbstractaDePersistencia.CrearInstancia().CrearGestorAccesoDeDatos();
            bienDAO = FabricaAbstractaDePersistencia.CrearInstancia().CrearBienPersistencia(gestorAccesoDatos);
            usuarioDAO = FabricaAbstractaDePersistencia.CrearInstancia().CrearUsuarioPersistencia(gestorAccesoDatos);
            movimientoDAO = FabricaAbstractaDePersistencia.CrearInstancia().CrearMovimientoPersistencia(gestorAccesoDatos);
        }

        public void AgregarDetalleDeMovimiento(string idBien) 
        {
            gestorAccesoDatos.AbrirConexion();
            Bien bien = bienDAO.BuscarBienPorId(idBien);
            gestorAccesoDatos.CerrarConexion();
            RegistroDeMovimientoDeBien registro = new RegistroDeMovimientoDeBien();
            registro.AgregarDetalleMovimientoBien(movimiento, bien);
        }

        public Usuario BuscarUsuarioPorDni(string dni)
        {
            gestorAccesoDatos.AbrirConexion();
            Usuario usu = usuarioDAO.BuscarUsuarioPorDni(dni);
            gestorAccesoDatos.CerrarConexion();

            return usu;
        }

        public List<Bien> BuscarBienPorDniUsuario(string dni )
        {
            gestorAccesoDatos.AbrirConexion();
            List<Bien> bienes = bienDAO.BuscarBienPorDniUsuario(dni);
            gestorAccesoDatos.CerrarConexion();
            return bienes;
        }

        public void GuardarMovimientoDeBien()
        {
            RegistroDeMovimientoDeBien registroDeMovimientoDeBien = new RegistroDeMovimientoDeBien();
            registroDeMovimientoDeBien.ValidarMovimientoDeBien(movimiento);
            gestorAccesoDatos.IniciarTransaccion();
            movimientoDAO.Guardar(movimiento);
            gestorAccesoDatos.TerminarTransaccion();
        }

        public void ValidarEmpleado(Usuario usuario)
        {
            RegistroDeMovimientoDeBien registro = new RegistroDeMovimientoDeBien();
            registro.ValidarCargoUsuario(usuario);
        }
        public void ValidarIdEmpleado(Usuario usuario, string idUsuario)
        {
            RegistroDeMovimientoDeBien registro = new RegistroDeMovimientoDeBien();
            registro.ValidarIdUsuario(usuario,idUsuario);
        }

    }
}
