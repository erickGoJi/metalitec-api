using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAplicacionApartado
    {
        public CvAplicacionApartado()
        {
            CvAplicacionApartadosDets = new HashSet<CvAplicacionApartadosDet>();
        }

        public int IdAplicacionApartado { get; set; }
        public int IdApartado { get; set; }
        public int IdContrato { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public decimal MontoDocumento { get; set; }
        public decimal MontoMoratorio { get; set; }
        public decimal MontoIvadocumento { get; set; }
        public decimal MontoIvamoratorio { get; set; }
        public decimal MontoExcedente { get; set; }
        public int IdPoliza { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public int? IdAjusteCliente { get; set; }
        public bool Reclasificado { get; set; }
        public decimal MontoAbonoCapital { get; set; }
        public decimal MontoGastosAdicionales { get; set; }
        public decimal MontoInteres { get; set; }
        public decimal MontoIvaExcedente { get; set; }
        public decimal Paridad { get; set; }
        public int? IdClienteFactura { get; set; }

        public virtual CvAjusteCliente IdAjusteClienteNavigation { get; set; }
        public virtual CvApartado IdApartadoNavigation { get; set; }
        public virtual CvContrato IdContratoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual ICollection<CvAplicacionApartadosDet> CvAplicacionApartadosDets { get; set; }
    }
}
