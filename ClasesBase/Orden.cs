using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Orden
    {
        private int ordenId;

        public int OrdenId
        {
            get { return ordenId; }
            set { ordenId = value; }
        }
        private DateTime fechaHora;

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }
        private int mesa;

        public int Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }
        private int estadoOrdenId;

        public int EstadoOrdenId
        {
            get { return estadoOrdenId; }
            set { estadoOrdenId = value; }
        }
    }
}
