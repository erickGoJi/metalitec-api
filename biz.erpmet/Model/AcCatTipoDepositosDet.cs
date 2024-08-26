using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoDepositosDet
    {
        public int IdTipoDepositoDet { get; set; }
        public int IdTipoDeposito { get; set; }
        public int IdCuenta { get; set; }
        public int Renglon { get; set; }
        public bool? SeCarga { get; set; }
        public decimal Porcentaje { get; set; }
        public int SecuenciaDeCalculo { get; set; }
        public bool UtilizarParidadFactura { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatTipoDeposito IdTipoDepositoNavigation { get; set; }
    }
}
