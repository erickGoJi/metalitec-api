using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvDepositosSofol
    {
        public CvDepositosSofol()
        {
            CvComplementoPagos = new HashSet<CvComplementoPago>();
            CvDepositosSofolCta = new HashSet<CvDepositosSofolCta>();
            CvDepositosSofolDets = new HashSet<CvDepositosSofolDet>();
        }

        public int IdDepositoSofol { get; set; }
        public int FolioDepositoSofol { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int IdProyecto { get; set; }
        public int IdSofol { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public decimal MontoDeposito { get; set; }
        public decimal MontoPago { get; set; }
        public bool Aplicado { get; set; }
        public bool Cancelado { get; set; }
        public int? IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public decimal MontoComisiones { get; set; }
        public decimal MontoAmortizaciones { get; set; }
        public string FolioSolicitud { get; set; }
        public int TipoDeposito { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CvSofole IdSofolNavigation { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagos { get; set; }
        public virtual ICollection<CvDepositosSofolCta> CvDepositosSofolCta { get; set; }
        public virtual ICollection<CvDepositosSofolDet> CvDepositosSofolDets { get; set; }
    }
}
