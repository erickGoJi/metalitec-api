using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTipoProveedorCuenta
    {
        public int IdTipoProveedorCuenta { get; set; }
        public int IdTipoProveedor { get; set; }
        public int IdCuenta { get; set; }
        public bool? SeCarga { get; set; }
        public decimal Porcentaje { get; set; }
        public int SecuenciaDeCalculo { get; set; }
        public string DescripcionFactura { get; set; }
        public int ParaAnticipo { get; set; }

        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatTipoProveedor IdTipoProveedorNavigation { get; set; }
    }
}
