using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa3_Dominio.Servicios
{
    public class RegistroDeMovimientoDeBien
    {

        public void AgregarDetalleMovimientoBien(MovimientoDeBien movimiento, Bien bien )
        {
            Boolean agregarDetalleMovimiento = movimiento.AgregarDetalleMovimiento(bien);
            if (!agregarDetalleMovimiento)
            {
                throw new Exception("No se puede agregar, los bienes deben estar encontrados.");
  
            }

        }
        public void ValidarMovimientoDeBien(MovimientoDeBien movimiento)
        {
            if (!movimiento.TieneDetalleMovimiento()) 
            {
                throw new Exception("No se puede guardar el movimiento, deben moverse como minimo un bien.");           
            }

        }

        public void ValidarCargoUsuario(Usuario usuario) 
        {
           
            if (!usuario.TieneCargo("Empleado"))
            {
                throw new Exception("El Usuario debe tener el cargo de Empleado.");
            }
        }
        public void ValidarIdUsuario(Usuario usuario, String idUsuario)
        {           
            if (usuario.PerteneceId(idUsuario))
            {
                throw new Exception("El Usuario no debe ser el mismo que el Origen.");
            }
        }

    }
}
