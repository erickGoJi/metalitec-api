using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGastosXcomprobarDet
    {
        public AcGastosXcomprobarDet()
        {
            AcGastosXcomprobarDetDiots = new HashSet<AcGastosXcomprobarDetDiot>();
        }

        public int IdGastoXcomprobarDet { get; set; }
        public int IdGastoXcomprobar { get; set; }
        public int IdProyecto { get; set; }
        public string Factura { get; set; }
        public int IdExplosionInsumos { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal Iva { get; set; }
        public int? IdCuentaIva { get; set; }
        public int IdProveedor { get; set; }
        public string Observaciones { get; set; }
        public int? IdXmlproveedor { get; set; }
        public int? IdCuentaRetencionIsr { get; set; }
        public decimal MontoRetencionIsr { get; set; }
        public decimal MontoRetencionIva { get; set; }
        public int? IdCuentaRetencionIva { get; set; }

        public virtual CtbCuenta IdCuentaIvaNavigation { get; set; }
        public virtual AcExplosionInsumo IdExplosionInsumosNavigation { get; set; }
        public virtual AcGastosXcomprobar IdGastoXcomprobarNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcProveedoresXml IdXmlproveedorNavigation { get; set; }
        public virtual ICollection<AcGastosXcomprobarDetDiot> AcGastosXcomprobarDetDiots { get; set; }
    }
}
