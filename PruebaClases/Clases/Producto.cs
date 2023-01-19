using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.Clases
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public double TandaMinima { get; set; }
        public double CostoUnitario { get; set; }
        public string UnidadMedida { get; set; }
        public Producto() { }
        public Producto(Producto producto) {
            IdProducto= producto.IdProducto;
            Descripcion= producto.Descripcion;
            Presentacion= producto.Presentacion;
            TandaMinima = producto.TandaMinima;
            CostoUnitario= producto.CostoUnitario;
            UnidadMedida= producto.UnidadMedida;
        }
    }
}
