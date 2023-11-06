using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class PlatoOrden
    {
        private int platoOrdenId;

        public int PlatoOrdenId
        {
            get { return platoOrdenId; }
            set { platoOrdenId = value; }
        }
        private int platoId;

        public int PlatoId
        {
            get { return platoId; }
            set { platoId = value; }
        }
        private int ordenId;

        public int OrdenId
        {
            get { return ordenId; }
            set { ordenId = value; }
        }
    }
}
