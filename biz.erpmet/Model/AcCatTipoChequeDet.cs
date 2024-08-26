using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoChequeDet
    {
        public int IdTipoChequeDet { get; set; }
        public int IdTipoCheque { get; set; }
        public int IdCuenta { get; set; }
        public int Renglon { get; set; }
        public bool? SeCarga { get; set; }
        public decimal Porcentaje { get; set; }
        public int SecuenciaDeCalculo { get; set; }
        public bool UtilizarParidadFactura { get; set; }

        public virtual AcCatTipoCheque IdTipoChequeNavigation { get; set; }
    }
}
