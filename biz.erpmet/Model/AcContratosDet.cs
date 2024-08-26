using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContratosDet
    {
        public AcContratosDet()
        {
            AcClientesFacturasDets = new HashSet<AcClientesFacturasDet>();
            AcClientesRemisionesDets = new HashSet<AcClientesRemisionesDet>();
            AcContratosOcdets = new HashSet<AcContratosOcdet>();
        }

        public int IdContratoDet { get; set; }
        public int IdContrato { get; set; }
        public int IdProyectoPartida { get; set; }
        public int Renglon { get; set; }
        public int IdProyectoConcepto { get; set; }
        public string DescripcionAuxiliar { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadOrdenCambio { get; set; }
        public decimal Precio { get; set; }
        public int TipoExtraOrdinario { get; set; }
        public int? ControlPu2010 { get; set; }

        public virtual AcContrato IdContratoNavigation { get; set; }
        public virtual AcProyectoConcepto IdProyectoConceptoNavigation { get; set; }
        public virtual AcProyectoPartida IdProyectoPartidaNavigation { get; set; }
        public virtual ICollection<AcClientesFacturasDet> AcClientesFacturasDets { get; set; }
        public virtual ICollection<AcClientesRemisionesDet> AcClientesRemisionesDets { get; set; }
        public virtual ICollection<AcContratosOcdet> AcContratosOcdets { get; set; }
    }
}
