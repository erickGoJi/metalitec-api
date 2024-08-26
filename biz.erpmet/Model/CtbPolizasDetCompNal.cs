using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetCompNal
    {
        public int IdPolizaDetCompNal { get; set; }
        public int IdPolizaDet { get; set; }
        public string UuidCfdi { get; set; }
        public decimal MontoTotal { get; set; }
        public string Rfc { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
