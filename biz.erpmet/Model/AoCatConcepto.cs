using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoCatConcepto
    {
        public AoCatConcepto()
        {
            AoExpXconceptos = new HashSet<AoExpXconcepto>();
            AoMatrizOcs = new HashSet<AoMatrizOc>();
            AoPresupuestoControls = new HashSet<AoPresupuestoControl>();
            BiHistoricoDets = new HashSet<BiHistoricoDet>();
        }

        public int IdConcepto { get; set; }
        public int IdProyecto { get; set; }
        public int IdSubcontrato { get; set; }
        public int? IdDestajo { get; set; }
        public int? IdSubmo { get; set; }
        public string DescripcionLarga { get; set; }
        public decimal DestajoMax { get; set; }
        public decimal SubcontratoMax { get; set; }
        public int FolioOcmatriz { get; set; }

        public virtual AcCatInsumo IdDestajoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatInsumo IdSubcontratoNavigation { get; set; }
        public virtual AcCatInsumo IdSubmoNavigation { get; set; }
        public virtual ICollection<AoExpXconcepto> AoExpXconceptos { get; set; }
        public virtual ICollection<AoMatrizOc> AoMatrizOcs { get; set; }
        public virtual ICollection<AoPresupuestoControl> AoPresupuestoControls { get; set; }
        public virtual ICollection<BiHistoricoDet> BiHistoricoDets { get; set; }
    }
}
