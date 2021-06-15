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
   public class MovimientoSQLServer :IMovimientoPersistencia
    {
        private GestorSQLServer gestorSQL;
        public MovimientoSQLServer(IGestorAccesoDeDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQLServer)gestorSQL;
        }

        public void Guardar(MovimientoDeBien movimiento)
        {
            string insertarMovimiento = "insert into MovimientoBien(idMovimiento,idPersonalTecnico, idUsuarioOrigen, idUsuarioDestino, asunto, fecha, motivo)" +
                "values(@idMovimiento,@idPersonalTecnico, @idUsuarioOrigen, @idUsuarioDestino, @asunto, @fecha, @motivo)";
            string insertarDetalleMovimiento = "insert into DetalleMovimiento(idMovimiento, idBien, bienEncontrado)values(@idMovimiento, @idBien, @bienEncontrado)";
            string actualizarResponsabilidadBien = "update Bien set idUsuario= @idUsuarioDestino where idUsuario= @idUsuarioOrigen and idBien=@idBien";
            try
            {
                SqlCommand cmd;
                Bien bien;
                cmd = gestorSQL.ObtenerComandoSQL(insertarMovimiento);
                cmd.Parameters.AddWithValue("@idMovimiento", movimiento.IdMovimiento);
                cmd.Parameters.AddWithValue("@idPersonalTecnico", movimiento.UsuarioTecnico.IdUsuario);                
                cmd.Parameters.AddWithValue("@idUsuarioOrigen", movimiento.UsuarioOrigen.IdUsuario);
                cmd.Parameters.AddWithValue("@idUsuarioDestino", movimiento.UsuarioDestino.IdUsuario);

                cmd.Parameters.AddWithValue("@asunto", movimiento.Asunto);
                cmd.Parameters.AddWithValue("@fecha", movimiento.Fecha);
                cmd.Parameters.AddWithValue("@motivo", movimiento.Motivo);
                cmd.ExecuteNonQuery();
                foreach (DetalleMovimiento detalleDeMovimiento in movimiento.DetalleDeMovimiento)
                {
                    // movimiento=detalleDeMovimiento.movi
                    bien = detalleDeMovimiento.Bien;
                    cmd = gestorSQL.ObtenerComandoSQL(insertarDetalleMovimiento);
                    cmd.Parameters.AddWithValue("@idMovimiento", movimiento.IdMovimiento);
                    cmd.Parameters.AddWithValue("@idBien", bien.IdBien);
                    cmd.Parameters.AddWithValue("@bienEncontrado", bien.Encontrado);
                    cmd.ExecuteNonQuery();
                    //actualizar Responsabilidad de Bien
                    cmd = gestorSQL.ObtenerComandoSQL(actualizarResponsabilidadBien);
                    cmd.Parameters.AddWithValue("@idUsuarioDestino", movimiento.UsuarioDestino.IdUsuario);
                    cmd.Parameters.AddWithValue("@idUsuarioOrigen", movimiento.UsuarioOrigen.IdUsuario);
                    cmd.Parameters.AddWithValue("@idBien", bien.IdBien);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Verfique que el codigo del movimiento sea unico");
            }
        }
    }
}
