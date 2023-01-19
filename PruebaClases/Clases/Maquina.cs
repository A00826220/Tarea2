using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.Clases
{
    public class Maquina
    {
        public string IdMaquina { get; set; }
        public string Descripcion { get; set; }
        public List<string> ListaIdProductos { get; set; }
        public double TandaMinima { get; set; }
    }
}
