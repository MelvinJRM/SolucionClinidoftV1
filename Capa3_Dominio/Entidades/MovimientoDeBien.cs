using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
   public class MovimientoDeBien
    {
        private String idMovimiento;
        private String asunto;
        private DateTime fecha;
        private String motivo;

        private Usuario usuarioTecnico;
        private Usuario usuarioDestino;
        private Usuario usuarioOrigen;
        private List<DetalleMovimiento> detalleDeMovimiento;

        public String Asunto { get => asunto; set => asunto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public String Motivo { get => motivo; set => motivo = value; }
        public Usuario UsuarioTecnico { get => usuarioTecnico; set => usuarioTecnico = value; }
        public Usuario UsuarioDestino { get => usuarioDestino; set => usuarioDestino = value; }
        public Usuario UsuarioOrigen { get => usuarioOrigen; set => usuarioOrigen = value; }
        public List<DetalleMovimiento> DetalleDeMovimiento { get => detalleDeMovimiento; set => detalleDeMovimiento = value; }
        public String IdMovimiento { get => idMovimiento; set => idMovimiento = value; }

        public MovimientoDeBien()
        {
            fecha = DateTime.Now;
            detalleDeMovimiento = new List<DetalleMovimiento>();
        }


        public Boolean TieneDetalleMovimiento()
        {
            Boolean tieneDetalle=false;
            if (detalleDeMovimiento.Count >=1)
            {
                tieneDetalle = true;
            }         
            return tieneDetalle;
        }

        public Boolean AgregarDetalleMovimiento(Bien bien)
        {
            Boolean movimiento = false;
            DetalleMovimiento detalle = new DetalleMovimiento(bien);
            if (detalle.ValidarEstadoDeBien())
            {
                detalleDeMovimiento.Add(detalle);
                movimiento = true;
            }

            return movimiento;
        }
        
        public double CalcularMontoTotalDeBienesAMover()
        {
            double montoTotal = 0;
            foreach(DetalleMovimiento detalle in detalleDeMovimiento)
            {                
                montoTotal += detalle.Bien.CalcularValorActual();
            }
            return montoTotal;
        }


        public DetalleMovimiento RetornarUltimoDetalleMovimiento()
        {
            return detalleDeMovimiento.Last();
        }





    }
}
