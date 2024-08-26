using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDepositosSofolCta
    {
        public int IdDepositoSofolCta { get; set; }
        public int IdDepositoSofol { get; set; }
        public int IdCuenta { get; set; }
        public decimal Monto { get; set; }
        public int? IdExplosionInsumos { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual CvDepositosSofol IdDepositoSofolNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
    }
}
