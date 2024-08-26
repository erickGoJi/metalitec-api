using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposCliente
    {
        public AcCatTiposCliente()
        {
            AcCatTipoClientesCuenta = new HashSet<AcCatTipoClientesCuenta>();
            AcClientes = new HashSet<AcCliente>();
        }

        public int IdTipoCliente { get; set; }
        public string TipoCliente { get; set; }
        public int IdTipoPoliza { get; set; }
        public string Descripcion { get; set; }
        public bool GenerarCtasAuto { get; set; }
        public int? IdCuentaCliente { get; set; }
        public int? IdCuentaAnticipo { get; set; }
        public int? IdCuentaFonGar { get; set; }
        public int ConsecutivoCuentas { get; set; }
        public int IdTipoDeposito { get; set; }

        public virtual CtbCuenta IdCuentaAnticipoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaClienteNavigation { get; set; }
        public virtual CtbCuenta IdCuentaFonGarNavigation { get; set; }
        public virtual AcCatTipoDeposito IdTipoDepositoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcCatTipoClientesCuenta> AcCatTipoClientesCuenta { get; set; }
        public virtual ICollection<AcCliente> AcClientes { get; set; }
    }
}
