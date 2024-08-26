using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasIetu
    {
        public int IdPolizaIetu { get; set; }
        public int IdPolizaDet { get; set; }
        public decimal MontoIvaacreditable15 { get; set; }
        public decimal MontoIvaacreditable10 { get; set; }
        public decimal MontoIvanoAcreditable15 { get; set; }
        public decimal MontoIvanoAcreditable10 { get; set; }
        public decimal MontoIvaretenido { get; set; }
        public decimal MontoIvaTrasladado { get; set; }
        public short OrigenIetu { get; set; }

        public virtual CtbPolizasDet IdPolizaDetNavigation { get; set; }
    }
}
