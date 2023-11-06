using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Plato
    {
        private int platoId;

        public int PlatoId
        {
            get { return platoId; }
            set { platoId = value; }
        }
        private int platoCategoriaId;

        public int PlatoCategoriaId
        {
            get { return platoCategoriaId; }
            set { platoCategoriaId = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
