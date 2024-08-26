using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcOrdenProduccion
    {
        public AcOrdenProduccion()
        {
            AcAlmacenSalida = new HashSet<AcAlmacenSalida>();
            AcOrdenProduccionDets = new HashSet<AcOrdenProduccionDet>();
        }

        public int IdOrdenProduccion { get; set; }
        public int IdProyecto { get; set; }
        public int IdProyectoDestino { get; set; }
        public int FolioOrdenProduccion { get; set; }
        public DateTime Fecha { get; set; }
        public int IdResponsable { get; set; }
        public string Observaciones { get; set; }
        public int? IdRequisicion { get; set; }
        public bool Cancelada { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool Calculada { get; set; }

        public virtual Proyecto IdProyectoDestinoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcRequisicione IdRequisicionNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalida { get; set; }
        public virtual ICollection<AcOrdenProduccionDet> AcOrdenProduccionDets { get; set; }
    }
}
