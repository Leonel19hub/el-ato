using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private int productoId;

        public int ProductoId
        {
            get { return productoId; }
            set { productoId = value; }
        }
        private int prodCategoriaId;

        public int ProdCategoriaId
        {
            get { return prodCategoriaId; }
            set { prodCategoriaId = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        private string unidadMedida;

        public string UnidadMedida
        {
            get { return unidadMedida; }
            set { unidadMedida = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
