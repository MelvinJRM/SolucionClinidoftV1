using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa3_Dominio.EstrategiasConcretasValorActual;
using Capa3_Dominio.EstrategiaValorActual;

namespace Capa3_Dominio.Entidades
{
   public class Bien
    {
        private string idBien;
        private string categoria;
        private string codigoPatrimonial;
        private double depreciacion;
        private Boolean encontrado;
        private char estadoConservacion;
        private DateTime fecha;
        private string marca;
        private string modelo;
        private double precio;
        private string serie;
        private string vidaUtil;

        private IEstrategiaValorActual estrategiaValorActual;


        private Usuario usuario;

        public Bien()
        {
            estrategiaValorActual = FabricaEstrategiaValorActual.crearInstancia().crearEstrategiaValorActual();
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public string CodigoPatrimonial { get => codigoPatrimonial; set => codigoPatrimonial = value; }
        public double Depreciacion { get => depreciacion; set => depreciacion = value; }
        public Boolean Encontrado { get => encontrado; set => encontrado = value; }
        public char EstadoConservacion { get => estadoConservacion; set => estadoConservacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string IdBien { get => idBien; set => idBien = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Serie { get => serie; set => serie = value; }
        public string VidaUtil { get => vidaUtil; set => vidaUtil = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }

        public double CalcularValorActual()
        {
            return estrategiaValorActual.CalcularValorActual(this);
        }


    }

   



}
