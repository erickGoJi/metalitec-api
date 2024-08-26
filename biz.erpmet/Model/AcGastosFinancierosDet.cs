using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGastosFinancierosDet
    {
        public int IdGastosFinancierosDet { get; set; }
        public int IdGastosFinancieros { get; set; }
        public int IdProyecto { get; set; }
        public string Factura { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Iva { get; set; }
        public int? IdCuentaIva { get; set; }
        public string Observaciones { get; set; }

        public virtual CtbCuenta IdCuentaIvaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcGastosFinanciero IdGastosFinancierosNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
