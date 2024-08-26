using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatMonedasDet
    {
        public int IdMonedaDet { get; set; }
        public int IdTipoMoneda { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Paridad { get; set; }

        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
    }
}
