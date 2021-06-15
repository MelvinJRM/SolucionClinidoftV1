using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.Entidades;
namespace Capa3_Dominio.Contratos
{
    public interface IBienPersistencia
    {
        List<Bien> BuscarPorFechaYArea(DateTime fechaminima, DateTime fechamaxima, String area);
        List<Bien> BuscarBienPorDniUsuario(string dni);
        Bien BuscarBienPorId(String idBien);


    }
}
