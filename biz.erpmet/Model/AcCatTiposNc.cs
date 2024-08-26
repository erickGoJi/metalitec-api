using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposNc
    {
        public AcCatTiposNc()
        {
            AcClientesFacturasNcs = new HashSet<AcClientesFacturasNc>();
            AcFacturasProveedoresNcs = new HashSet<AcFacturasProveedoresNc>();
        }

        public int IdTipoNc { get; set; }
        public string TipoNc { get; set; }
        public string Descripcion { get; set; }
        public int IdCuentaDescuento { get; set; }
        public int IdTipoPoliza { get; set; }
        public bool? EsParaProveedor { get; set; }
        public int IdCuentaIva { get; set; }

        public virtual CtbCuenta IdCuentaDescuentoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaIvaNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcs { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
    }
}
