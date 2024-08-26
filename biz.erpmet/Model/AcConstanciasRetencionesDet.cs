using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcConstanciasRetencionesDet
    {
        public int IdConstanciaRetencionDet { get; set; }
        public int IdConstanciaRetencion { get; set; }
        public int? IdTipoImpuesto { get; set; }
        public decimal? MontoBase { get; set; }
        public decimal MontoRetencion { get; set; }
        public bool EsPagoDefinitivo { get; set; }
        public int? Renglon { get; set; }

        public virtual AcConstanciasRetencione IdConstanciaRetencionNavigation { get; set; }
        public virtual AcCatTiposImpuesto IdTipoImpuestoNavigation { get; set; }
    }
}
