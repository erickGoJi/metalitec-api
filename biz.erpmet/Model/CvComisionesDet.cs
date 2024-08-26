using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvComisionesDet
    {
        public int IdComisionDet { get; set; }
        public int IdComision { get; set; }
        public int IdFlujoCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdCetapa { get; set; }
        public string TipoVendedor { get; set; }
        public decimal MontoParaCalculo { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal MontoComision { get; set; }
        public bool Cancelada { get; set; }
        public string DescriCancelacion { get; set; }
        public bool ConsideradaEnDeducciones { get; set; }
        public int? IdComisionDeduccion { get; set; }
        public DateTime? FechaTerminado { get; set; }
        public decimal PorcentajeBaseParaCalculo { get; set; }

        public virtual CvCetapa IdCetapaNavigation { get; set; }
        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvComisione IdComisionNavigation { get; set; }
    }
}
