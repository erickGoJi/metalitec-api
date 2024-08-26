using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPagoLiberacionViviendasDet
    {
        public int IdPagoLiberacionViviendaDet { get; set; }
        public int IdPagoLiberacionVivienda { get; set; }
        public int IdVivienda { get; set; }
        public decimal MontoAmortizacion { get; set; }

        public virtual CvPagoLiberacionVivienda IdPagoLiberacionViviendaNavigation { get; set; }
    }
}
