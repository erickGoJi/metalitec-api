using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoCheque
    {
        public AcCatTipoCheque()
        {
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
            AcCatTipoChequeDets = new HashSet<AcCatTipoChequeDet>();
            AcCatTipoProveedors = new HashSet<AcCatTipoProveedor>();
        }

        public int IdTipoCheque { get; set; }
        public string TipoCheque { get; set; }
        public string Descripcion { get; set; }
        public decimal DividirEntre { get; set; }
        public int IdFlujo { get; set; }
        public int IdTipoPoliza { get; set; }

        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
        public virtual ICollection<AcCatTipoChequeDet> AcCatTipoChequeDets { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedors { get; set; }
    }
}
