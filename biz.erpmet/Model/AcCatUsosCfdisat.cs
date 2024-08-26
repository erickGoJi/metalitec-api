using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatUsosCfdisat
    {
        public AcCatUsosCfdisat()
        {
            AcCfditraslados = new HashSet<AcCfditraslado>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
        }

        public int IdUsoCfdiSat { get; set; }
        public string CodigoUso { get; set; }
        public string DescripcionUso { get; set; }
        public bool AplicaPfisica { get; set; }
        public bool AplicaPmoral { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
    }
}
