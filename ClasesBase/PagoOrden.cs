using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class PagoOrden
    {
        private int pagoOrdenId;

        public int PagoOrdenId
        {
            get { return pagoOrdenId; }
            set { pagoOrdenId = value; }
        }
        private int metodoPagoId;

        public int MetodoPagoId
        {
            get { return metodoPagoId; }
            set { metodoPagoId = value; }
        }
        private int ordenId;

        public int OrdenId
        {
            get { return ordenId; }
            set { ordenId = value; }
        }
    }
}
