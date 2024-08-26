using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoDestajosEst
    {
        public AoDestajosEst()
        {
            AoDestajosEstDets = new HashSet<AoDestajosEstDet>();
        }

        public int IdDestajoEst { get; set; }
        public int IdProyecto { get; set; }
        public int IdDestajista { get; set; }
        public int FolioEstimacion { get; set; }
        public decimal ImporteFonGar { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime Fecha { get; set; }
        public decimal DevolucionFonGar { get; set; }
        public bool Autorizada { get; set; }
        public int IdUsuario { get; set; }
        public string Agrupa { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelada { get; set; }
        public bool EnviadoaMizar { get; set; }
        public bool VoBo { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdUsuarioPoliza { get; set; }
        public DateTime? FechaPoliza { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteOriginal { get; set; }
        public string ServidorPu2010 { get; set; }
        public string BaseDatosPu2010 { get; set; }
        public int? IdPresupuestoPu2010 { get; set; }
        public int? IdEstimacionPu2010 { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioPolizaNavigation { get; set; }
        public virtual ICollection<AoDestajosEstDet> AoDestajosEstDets { get; set; }
    }
}
