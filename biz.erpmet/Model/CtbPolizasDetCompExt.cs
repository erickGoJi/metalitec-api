using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetCompExt
    {
        public int IdPolizaDetCompExt { get; set; }
        public int IdPolizaDet { get; set; }
        public string NumFactExt { get; set; }
        public string TaxId { get; set; }
        public decimal MontoTotal { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
