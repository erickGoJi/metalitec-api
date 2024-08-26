using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoProveedor
    {
        public AcCatTipoProveedor()
        {
            AcCatTipoProveedorCuenta = new HashSet<AcCatTipoProveedorCuenta>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdTipoProveedor { get; set; }
        public string TipoProveedor { get; set; }
        public int IdTipoPoliza { get; set; }
        public string Descripcion { get; set; }
        public bool GenerarCtasAuto { get; set; }
        public int? IdCuentaProveedor { get; set; }
        public int? IdCuentaAnticipo { get; set; }
        public int? IdCuentaFonGar { get; set; }
        public decimal FactorAplicarImportes { get; set; }
        public int IdTipoCheque { get; set; }
        public int ConsecutivoCuentas { get; set; }
        public bool UtilizarCuentaEntradas { get; set; }
        public int? IdCuentaOtrasRetenciones { get; set; }
        public int? IdCuentaPagoEnEspecie { get; set; }

        public virtual CtbCuenta IdCuentaAnticipoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaFonGarNavigation { get; set; }
        public virtual CtbCuenta IdCuentaOtrasRetencionesNavigation { get; set; }
        public virtual CtbCuenta IdCuentaPagoEnEspecieNavigation { get; set; }
        public virtual CtbCuenta IdCuentaProveedorNavigation { get; set; }
        public virtual AcCatTipoCheque IdTipoChequeNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcCatTipoProveedorCuenta> AcCatTipoProveedorCuenta { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
