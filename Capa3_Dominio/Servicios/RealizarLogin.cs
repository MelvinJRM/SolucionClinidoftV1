using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;

namespace Capa3_Dominio.Servicios
{
    public class RealizarLogin
    {
        public void ValidarCargoUsuario(Usuario usuario)
        {
            if (!usuario.TieneCargo("Tecnico"))
            {
                throw new Exception("El Usuario debe tener el cargo de Empleado");
            }
        }

    }
}
