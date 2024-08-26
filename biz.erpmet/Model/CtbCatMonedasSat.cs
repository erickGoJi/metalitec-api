using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbCatMonedasSat
    {
        public CtbCatMonedasSat()
        {
            AcCatMoneda = new HashSet<AcCatMoneda>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            AcComplementoPagos = new HashSet<AcComplementoPago>();
            AcCuentasBancaria = new HashSet<AcCuentasBancaria>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
            CvComplementoPagos = new HashSet<CvComplementoPago>();
        }

        public int IdCatMonedasSat { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public byte Decimales { get; set; }
        public string Version { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public decimal? PorcentajeVariacion { get; set; }
        public DateTime? FechaFinVig { get; set; }

        public virtual ICollection<AcCatMoneda> AcCatMoneda { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagos { get; set; }
        public virtual ICollection<AcCuentasBancaria> AcCuentasBancaria { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
    }
}
