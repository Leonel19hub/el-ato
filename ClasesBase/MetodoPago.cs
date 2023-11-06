using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class MetodoPago
    {
        private int metodoPagoId;

        public int MetodoPagoId
        {
            get { return metodoPagoId; }
            set { metodoPagoId = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
