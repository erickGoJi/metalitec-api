using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetAp
    {
        public int IdPolizaDetAp { get; set; }
        public int IdPolizaDetCargo { get; set; }
        public int IdPolizaDetAbono { get; set; }
        public decimal Monto { get; set; }
        public int? IdUsuarioAutorizo { get; set; }
        public int? IdUsuarioManual { get; set; }
        public int? IdUsuarioEmitioCheque { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? TipoCargo { get; set; }

        public virtual CtbPolizasDet IdPolizaDetAbonoNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetCargoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioAutorizoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioEmitioChequeNavigation { get; set; }
        public virtual SegUsuario IdUsuarioManualNavigation { get; set; }
    }
}
