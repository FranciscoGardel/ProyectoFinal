using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco_Gardel
{
    internal class Producto : Usuario
    {
        public string IdProducto { get; set; }
        private string DescripcionProducto { get; set; }
        private double CostoProducto { get; set; }
        private double PrecioVentaProducto { get; set; }
        public int StockProducto { get; set; }

        public Producto() { }

        public Producto (string idProducto, string descripcionProducto, double costoProducto, double precioVentaProducto, int stockProducto)
        {
            this.IdProducto = idProducto;
            this.DescripcionProducto = descripcionProducto;
            this.CostoProducto = costoProducto;
            this.PrecioVentaProducto = precioVentaProducto;
            this.StockProducto = stockProducto;
        }
    }
}
