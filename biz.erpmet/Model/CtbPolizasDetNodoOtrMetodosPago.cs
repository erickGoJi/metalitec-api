using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetNodoOtrMetodosPago
    {
        public int IdPolizaDetNodoOtrMetodoPago { get; set; }
        public int IdPolizaDet { get; set; }
        public string MetPagoPol { get; set; }
        public DateTime Fecha { get; set; }
        public string Benef { get; set; }
        public string Rfc { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
