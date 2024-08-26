using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetNodoTransferencia
    {
        public int IdPolizaDetNodoTransferencia { get; set; }
        public int IdPolizaDet { get; set; }
        public string CtaOri { get; set; }
        public string BancoOriNal { get; set; }
        public string BancoOriExt { get; set; }
        public string CtaDest { get; set; }
        public string BancoDestNal { get; set; }
        public string BancoDestExt { get; set; }
        public DateTime Fecha { get; set; }
        public string Benef { get; set; }
        public string Rfc { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public decimal TipCamb { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
