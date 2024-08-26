using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetNodoCheque
    {
        public int IdPolizaDetNodoCheque { get; set; }
        public int IdPolizaDet { get; set; }
        public string Num { get; set; }
        public string BanEmisNal { get; set; }
        public string BanEmisExt { get; set; }
        public string CtaOri { get; set; }
        public DateTime Fecha { get; set; }
        public string Benef { get; set; }
        public string Rfc { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
