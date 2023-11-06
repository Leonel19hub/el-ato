using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ProductoCategoria
    {
        private int prodCategoriaId;

        public int ProdCategoriaId
        {
            get { return prodCategoriaId; }
            set { prodCategoriaId = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
