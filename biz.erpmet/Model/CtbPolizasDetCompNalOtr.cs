using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetCompNalOtr
    {
        public int IdPolizaDetCompNalOtr { get; set; }
        public int IdPolizaDet { get; set; }
        public string CfdCbbSerie { get; set; }
        public string CfdCbbNumFol { get; set; }
        public string Rfc { get; set; }
        public decimal MontoTotal { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
