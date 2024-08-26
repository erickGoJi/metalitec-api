using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvApartado
    {
        public CvApartado()
        {
            CvAplicacionApartados = new HashSet<CvAplicacionApartado>();
        }

        public int IdApartado { get; set; }
        public int FolioApartado { get; set; }
        public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoApartado { get; set; }
        public int IdProyecto { get; set; }
        public int IdPoliza { get; set; }
        public bool Aplicado { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string DescripcionCancelacion { get; set; }
        public bool Reclasificado { get; set; }
        public decimal Paridad { get; set; }
        public int? FolioPorProyecto { get; set; }
        public int? IdClienteFactura { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvDepositosCliente IdDepositoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<CvAplicacionApartado> CvAplicacionApartados { get; set; }
    }
}
