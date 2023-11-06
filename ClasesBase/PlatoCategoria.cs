using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class PlatoCategoria
    {
        private int platoCategoriaId;

        public int PlatoCategoriaId
        {
            get { return platoCategoriaId; }
            set { platoCategoriaId = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
