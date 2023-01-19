using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.Clases
{
    public class Demanda
    {
        public string IdDemanda { get; set; }
        public string Descripcion { get; set; }
        public string IdProducto   { get; set; }
        public string IdCliente { get; set; }
        public double CantidadRequerida { get; set; }
        public double CantidadProgramada { get; set; }
        public double suma { get; set; }
        public Demanda() 
        {
        }
        public Demanda(Demanda demanda)
        {
            IdDemanda= demanda.IdDemanda;
            Descripcion= demanda.Descripcion;
            IdProducto= demanda.IdProducto;
            IdCliente = demanda.IdCliente;
            CantidadRequerida= demanda.CantidadRequerida;
            CantidadProgramada= demanda.CantidadProgramada;
            suma = demanda.suma;
        }
    }
}
