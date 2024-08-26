using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbConstanciaRetencionDet
    {
        public int IdConstanciaRetencionDet { get; set; }
        public int IdConstanciaRetencion { get; set; }
        public string TipoImpuesto { get; set; }
        public decimal MontoBase { get; set; }
        public decimal MontoRetencion { get; set; }
        public bool? EsPagoDefinitivo { get; set; }

        public virtual CtbConstanciaRetencione IdConstanciaRetencionNavigation { get; set; }
        public virtual CtbCatTipoImpuesto TipoImpuestoNavigation { get; set; }
    }
}
