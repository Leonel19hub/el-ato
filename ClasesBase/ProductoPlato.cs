using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ProductoPlato
    {
        private int productoPlatoId;

        public int ProductoPlatoId
        {
            get { return productoPlatoId; }
            set { productoPlatoId = value; }
        }
        private int productoId;

        public int ProductoId
        {
            get { return productoId; }
            set { productoId = value; }
        }
        private int platoId;

        public int PlatoId
        {
            get { return platoId; }
            set { platoId = value; }
        }
    }
}
