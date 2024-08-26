using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubContratosEst
    {
        public AoSubContratosEst()
        {
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcs = new HashSet<AcFacturasProveedoresNc>();
            AoSubContratosEstDescuentos = new HashSet<AoSubContratosEstDescuento>();
            AoSubContratosEstDets = new HashSet<AoSubContratosEstDet>();
        }

        public int IdSubContratoEst { get; set; }
        public int IdSubContrato { get; set; }
        public int IdProyecto { get; set; }
        public int FolioEstimacion { get; set; }
        public decimal ImporteAnticipo { get; set; }
        public decimal ImporteFonGar { get; set; }
        public decimal DevolucionFonGar { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ImporteIva { get; set; }
        public bool Autorizada { get; set; }
        public int IdUsuario { get; set; }
        public string Agrupa { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelada { get; set; }
        public bool EnviadoaMizar { get; set; }
        public bool VoBo { get; set; }
        public int? IdEstimacionPu2010 { get; set; }
        public bool EsUltimaEstimacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaImportacionDaltonDin { get; set; }
        public bool ImportadoDaltonDin { get; set; }
        public decimal ImporteOtrasRetenciones { get; set; }
        public decimal DevolucionOtrasRetenciones { get; set; }
        public int? IntIdestimacionDin { get; set; }
        public decimal DevolucionPagoEnEspecie { get; set; }
        public decimal ImportePagoEnEspecie { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AoSubContrato IdSubContratoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
        public virtual ICollection<AoSubContratosEstDescuento> AoSubContratosEstDescuentos { get; set; }
        public virtual ICollection<AoSubContratosEstDet> AoSubContratosEstDets { get; set; }
    }
}
