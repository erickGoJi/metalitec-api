using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvComisione
    {
        public CvComisione()
        {
            CvComisionesDets = new HashSet<CvComisionesDet>();
        }

        public int IdComision { get; set; }
        public int FolioComision { get; set; }
        public int IdProyecto { get; set; }
        public int IdVendedor { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal MontoComisionesClientes { get; set; }
        public decimal MontoComisionesExtras { get; set; }
        public decimal MontoDeducciones { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Cancelada { get; set; }
        public string Observaciones { get; set; }
        public int? IdRequisicion { get; set; }
        public bool Pagada { get; set; }
        public DateTime? FechaPagada { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcRequisicione IdRequisicionNavigation { get; set; }
        public virtual CvVendedore IdVendedorNavigation { get; set; }
        public virtual ICollection<CvComisionesDet> CvComisionesDets { get; set; }
    }
}
