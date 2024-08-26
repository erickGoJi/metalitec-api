using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposRelacionSat
    {
        public AcCatTiposRelacionSat()
        {
            AcCfditraslados = new HashSet<AcCfditraslado>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
        }

        public int IdTipoRelacionSat { get; set; }
        public string CodigoRelacionSat { get; set; }
        public string DescripcionRelacionSat { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
    }
}
