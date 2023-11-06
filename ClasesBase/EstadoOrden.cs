using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class EstadoOrden
    {
        private int estadoOrdenId;

        public int EstadoOrdenId
        {
            get { return estadoOrdenId; }
            set { estadoOrdenId = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
