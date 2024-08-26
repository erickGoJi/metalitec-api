using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatTiposComprobanteSat
    {
        public AcCatTiposComprobanteSat()
        {
            AcCfditraslados = new HashSet<AcCfditraslado>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
        }

        public int IdTipoComprobanteSat { get; set; }
        public string CodigoTipoComprobante { get; set; }
        public string DescripcionTipoComprob { get; set; }
        public decimal ValorMaximoTc { get; set; }
        public decimal ValosMaximoTcns { get; set; }
        public decimal ValorMaximoTcndS { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
    }
}
