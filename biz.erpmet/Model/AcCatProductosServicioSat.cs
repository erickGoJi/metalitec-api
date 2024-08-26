using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatProductosServicioSat
    {
        public AcCatProductosServicioSat()
        {
            AcCfditrasladoDets = new HashSet<AcCfditrasladoDet>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasDets = new HashSet<AcClientesFacturasDet>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            AcClientesFacturasNcdets = new HashSet<AcClientesFacturasNcdet>();
            AcProyectoConceptos = new HashSet<AcProyectoConcepto>();
            CvCatConceptosCfdis = new HashSet<CvCatConceptosCfdi>();
            CvClientesFacturasDets = new HashSet<CvClientesFacturasDet>();
        }

        public int IdProductoServicioSat { get; set; }
        public string ClaveProductoServicio { get; set; }
        public string DescripcionProductoServicio { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string IncluirIvaTprodServ { get; set; }
        public string IncluirIepstrasladadoPs { get; set; }
        public string ComplementoAincluirPs { get; set; }
        public string Version { get; set; }
        public string PalabrasSimilares { get; set; }
        public bool EsFranjaFronteriza { get; set; }

        public virtual ICollection<AcCfditrasladoDet> AcCfditrasladoDets { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasDet> AcClientesFacturasDets { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNcdet> AcClientesFacturasNcdets { get; set; }
        public virtual ICollection<AcProyectoConcepto> AcProyectoConceptos { get; set; }
        public virtual ICollection<CvCatConceptosCfdi> CvCatConceptosCfdis { get; set; }
        public virtual ICollection<CvClientesFacturasDet> CvClientesFacturasDets { get; set; }
    }
}
