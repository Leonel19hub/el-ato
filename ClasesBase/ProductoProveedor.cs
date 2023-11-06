using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ProductoProveedor
    {
        private int prodProvId;

        public int ProdProvId
        {
            get { return prodProvId; }
            set { prodProvId = value; }
        }
        private int productoId;

        public int ProductoId
        {
            get { return productoId; }
            set { productoId = value; }
        }
        private int proveedorId;

        public int ProveedorId
        {
            get { return proveedorId; }
            set { proveedorId = value; }
        }
    }
}
