using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa3_Dominio.Entidades
{
    public class Usuario
    {
        private Boolean activado;
        private String apellidos;
        private String cargo;
        private String contrasena;
        private String dni;
        private String idUsuario;
        private String nombres;

        private Area Area;

        public bool Activado { get => activado; set => activado = value; }
        public String Apellidos { get => apellidos; set => apellidos = value; }
        public String Cargo { get => cargo; set => cargo = value; }
        public String Contrasena { get => contrasena; set => contrasena = value; }
        public String Dni { get => dni; set => dni = value; }
        public String IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String Nombres { get => nombres; set => nombres = value; }
        public Area Area1 { get => Area; set => Area = value; }

        public Boolean TieneCargo(string cargoAux)
        {
            if (cargo == cargoAux)
                return true;
            return false;
        }
        public Boolean PerteneceId(string idUsuarioAux)
        {
            if(idUsuario==idUsuarioAux)
                return true;
            return false;
        }
    }
}
