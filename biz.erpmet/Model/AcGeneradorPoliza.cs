using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGeneradorPoliza
    {
        public AcGeneradorPoliza()
        {
            AcGeneradorPolizaCuenta = new HashSet<AcGeneradorPolizaCuenta>();
            AcGeneradorPolizaInsumos = new HashSet<AcGeneradorPolizaInsumo>();
        }

        public int IdGeneradorPoliza { get; set; }
        public int Folio { get; set; }
        public int IdPolizaModelo { get; set; }
        public int IdProyecto { get; set; }
        public int MesPoliza { get; set; }
        public DateTime FechaPoliza { get; set; }
        public int IdTipoPoliza { get; set; }
        public string Concepto { get; set; }
        public int IdUsuario { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }

        public virtual AcModelosPoliza IdPolizaModeloNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcGeneradorPolizaCuenta> AcGeneradorPolizaCuenta { get; set; }
        public virtual ICollection<AcGeneradorPolizaInsumo> AcGeneradorPolizaInsumos { get; set; }
    }
}
