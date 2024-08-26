using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRequisicione
    {
        public AcRequisicione()
        {
            AcOrdenProduccions = new HashSet<AcOrdenProduccion>();
            AcPedidos = new HashSet<AcPedido>();
            AcRequisicionBitacoras = new HashSet<AcRequisicionBitacora>();
            AcRequisicionDets = new HashSet<AcRequisicionDet>();
            AcSolicitudMaterials = new HashSet<AcSolicitudMaterial>();
            CvComisiones = new HashSet<CvComisione>();
        }

        public int IdRequisicion { get; set; }
        public int IdProyecto { get; set; }
        public int Requisicion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaPosibleEntrega { get; set; }
        public int? IdAutorizacionTecnica { get; set; }
        public int? IdAutorizacionCompras { get; set; }
        public int IdSolicitante { get; set; }
        public string LugarEntregaMat { get; set; }
        public string CodigoAuxiliar { get; set; }
        public string Observaciones { get; set; }
        public string Contrato { get; set; }
        public bool PedidaTotalmente { get; set; }
        public bool Autorizada { get; set; }
        public int IdUsuario { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public int? IdUsuarioAutorizacion { get; set; }
        public bool VoBo { get; set; }
        public bool RevisadoAlmacen { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool EsComisionCv { get; set; }
        public bool GeneradaPorOp { get; set; }
        public bool GeneradaPorSm { get; set; }
        public bool GeneradaPorPu { get; set; }
        public int? IdCentro { get; set; }
        public int? IdResponsableSeguimiento { get; set; }
        public bool BasadoEnExpPorPartida { get; set; }
        public int? IdPartida { get; set; }

        public virtual Acresponsable IdAutorizacionComprasNavigation { get; set; }
        public virtual Acresponsable IdAutorizacionTecnicaNavigation { get; set; }
        public virtual Centro IdCentroNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual Acresponsable IdResponsableSeguimientoNavigation { get; set; }
        public virtual Acresponsable IdSolicitanteNavigation { get; set; }
        public virtual SegUsuario IdUsuarioAutorizacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccions { get; set; }
        public virtual ICollection<AcPedido> AcPedidos { get; set; }
        public virtual ICollection<AcRequisicionBitacora> AcRequisicionBitacoras { get; set; }
        public virtual ICollection<AcRequisicionDet> AcRequisicionDets { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterials { get; set; }
        public virtual ICollection<CvComisione> CvComisiones { get; set; }
    }
}
