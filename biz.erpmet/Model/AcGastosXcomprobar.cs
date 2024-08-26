using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGastosXcomprobar
    {
        public AcGastosXcomprobar()
        {
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
        }

        public int IdGastoXcomprobar { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuenta { get; set; }
        public int? IdFlujo { get; set; }
        public DateTime FechaPoliza { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public short Tipo { get; set; }
        public bool Cancelado { get; set; }
        public int IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string Observaciones { get; set; }
        public int? MesPolizaDiot { get; set; }
        public int? IdAcreedor { get; set; }
        public int? IdDeudor { get; set; }

        public virtual AcCatAcreedore IdAcreedorNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatDeudore IdDeudorNavigation { get; set; }
        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
    }
}
