using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProyectosConsecutivo
    {
        public int IdProyectoConsecutivo { get; set; }
        public int IdProyecto { get; set; }
        public int Requisicion { get; set; }
        public int OcpresupuestoControl { get; set; }
        public int OcpresupuestoCliente { get; set; }
        public int Pedido { get; set; }
        public int Subcontratos { get; set; }
        public int Prorrateo { get; set; }
        public int EstimacionesDestajos { get; set; }
        public int EstimacionesSubcontratos { get; set; }
        public int AditivasExplosion { get; set; }
        public int GastosXcomprobar { get; set; }
        public int GastosFinancieros { get; set; }
        public int NominaPoliza { get; set; }
        public int OrdenProduccion { get; set; }
        public int PartidaAvanceFisico { get; set; }
        public int SolicitudMaterial { get; set; }
        public int CvApartados { get; set; }
        public int GeneradorPoliza { get; set; }
        public int PedidosBitacora { get; set; }
        public int RequisicionBitacora { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
    }
}
