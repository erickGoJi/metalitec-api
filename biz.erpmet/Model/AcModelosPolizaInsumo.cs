using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcModelosPolizaInsumo
    {
        public int IdModeloPolizaInsumo { get; set; }
        public int IdPolizaModelo { get; set; }
        public bool EsCuenta { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdCuenta { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
    }
}
