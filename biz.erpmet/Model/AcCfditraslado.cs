using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCfditraslado
    {
        public AcCfditraslado()
        {
            AcCfditrasladoCfds = new HashSet<AcCfditrasladoCfd>();
            AcCfditrasladoDets = new HashSet<AcCfditrasladoDet>();
            AcCfditrasladoRelacs = new HashSet<AcCfditrasladoRelac>();
        }

        public int IdCfditraslado { get; set; }
        public int? IdCfditrasladoDirecciones { get; set; }
        public int IdProyecto { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoComprobanteSat { get; set; }
        public int? IdTipoRelacionSat { get; set; }
        public int IdUsoCfdiSat { get; set; }
        public int IdUsuario { get; set; }
        public int? Folio { get; set; }
        public string Serie { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public string FolioFiscalCfdi { get; set; }
        public string NoCertificado { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public string DescripcionCancelacion { get; set; }
        public byte EstatusSat { get; set; }
        public bool? EnProcesoCancelacion { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
        public DateTime? FechaSolicitudCancelacion { get; set; }
        public byte? EstatusDeCancelacion { get; set; }
        public byte? EsCancelable { get; set; }
        public string Observaciones { get; set; }

        public virtual AcCfditrasladoDireccione IdCfditrasladoDireccionesNavigation { get; set; }
        public virtual AcCliente IdClienteNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatTiposComprobanteSat IdTipoComprobanteSatNavigation { get; set; }
        public virtual AcCatTiposRelacionSat IdTipoRelacionSatNavigation { get; set; }
        public virtual AcCatUsosCfdisat IdUsoCfdiSatNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcCfditrasladoCfd> AcCfditrasladoCfds { get; set; }
        public virtual ICollection<AcCfditrasladoDet> AcCfditrasladoDets { get; set; }
        public virtual ICollection<AcCfditrasladoRelac> AcCfditrasladoRelacs { get; set; }
    }
}
