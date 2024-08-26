using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcMetodoPago
    {
        public AcMetodoPago()
        {
            AcClientesFacturas = new HashSet<AcClientesFactura>();
            CvClientesFacturas = new HashSet<CvClientesFactura>();
        }

        public int IdMetodoPago { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturas { get; set; }
    }
}
