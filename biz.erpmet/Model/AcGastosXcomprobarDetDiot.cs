using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGastosXcomprobarDetDiot
    {
        public int IdGastosXcomprobarDetDiot { get; set; }
        public int IdGastosXcomprobarDet { get; set; }
        public int IdConceptoDiot { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoIva { get; set; }

        public virtual CtbConceptosDiot IdConceptoDiotNavigation { get; set; }
        public virtual AcGastosXcomprobarDet IdGastosXcomprobarDetNavigation { get; set; }
    }
}
