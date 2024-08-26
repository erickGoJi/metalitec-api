using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDetPp
    {
        public int IdPolizaDetPp { get; set; }
        public int IdCuentaProveedor { get; set; }
        public int IdPolizaDetAbono { get; set; }
        public decimal MontoApagar { get; set; }
        public bool Autorizar { get; set; }
        public int? IdUsuarioAutorizo { get; set; }
        public int? IdBancoEgreso { get; set; }

        public virtual AcBancosEgreso IdBancoEgresoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaProveedorNavigation { get; set; }
        public virtual CtbPolizasDet IdPolizaDetAbonoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioAutorizoNavigation { get; set; }
    }
}
