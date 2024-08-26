using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetDc
    {
        public int IdPolizaDetDc { get; set; }
        public int IdPolizaDetAbono { get; set; }
        public int? IdPolizaDetCargo { get; set; }
        public decimal Monto { get; set; }
        public int? IdUsuarioManual { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual CtbPolizasDet IdPolizaDetAbonoNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetCargoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioManualNavigation { get; set; }
    }
}
