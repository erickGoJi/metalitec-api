using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatFormasPagoSat
    {
        public AcCatFormasPagoSat()
        {
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            AcComplementoPagos = new HashSet<AcComplementoPago>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
            CvComplementoPagos = new HashSet<CvComplementoPago>();
        }

        public int IdFormaPago { get; set; }
        public string FormaPago { get; set; }
        public string Descripcion { get; set; }
        public string Bancarizado { get; set; }
        public string NoOperacion { get; set; }
        public string RfcemisorCtaOrd { get; set; }
        public string CtaOrdenante { get; set; }
        public string PatronCtaOrd { get; set; }
        public string RfcemisorCtaBen { get; set; }
        public string CtaBeneficiario { get; set; }
        public string PatronCtaBen { get; set; }
        public string TipoCadenaPago { get; set; }
        public string BancoEmisorExtranjero { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagos { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
    }
}
