using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoDeposito
    {
        public AcCatTipoDeposito()
        {
            AcBancosIngresos = new HashSet<AcBancosIngreso>();
            AcCatTipoDepositosDets = new HashSet<AcCatTipoDepositosDet>();
            AcCatTiposClientes = new HashSet<AcCatTiposCliente>();
        }

        public int IdTipoDeposito { get; set; }
        public string TipoDeposito { get; set; }
        public string Descripcion { get; set; }
        public int IdFlujo { get; set; }
        public int IdTipoPoliza { get; set; }
        public decimal DividirEntre { get; set; }

        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual ICollection<AcCatTipoDepositosDet> AcCatTipoDepositosDets { get; set; }
        public virtual ICollection<AcCatTiposCliente> AcCatTiposClientes { get; set; }
    }
}
