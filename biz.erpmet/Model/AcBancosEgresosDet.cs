using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosEgresosDet
    {
        public int IdBancoEgresoDet { get; set; }
        public int IdBancoEgreso { get; set; }
        public int Renglon { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuentaCargo { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }

        public virtual AcBancosEgreso IdBancoEgresoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaCargoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
