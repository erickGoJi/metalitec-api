using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcSolicitudMaterial
    {
        public int IdSolicitudMaterial { get; set; }
        public int Folio { get; set; }
        public int IdAlmacenObra { get; set; }
        public int IdAlmacenGeneral { get; set; }
        public int IdAlmacenTransito { get; set; }
        public int IdResponsable { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdRequisicion { get; set; }
        public int? IdTraspasoTransito { get; set; }
        public int? IdTraspasoObra { get; set; }
        public int IdUsuario { get; set; }

        public virtual Proyecto IdAlmacenGeneralNavigation { get; set; }
        public virtual Proyecto IdAlmacenObraNavigation { get; set; }
        public virtual Proyecto IdAlmacenTransitoNavigation { get; set; }
        public virtual AcRequisicione IdRequisicionNavigation { get; set; }
        public virtual Acresponsable IdResponsableNavigation { get; set; }
        public virtual AcAlmacenTraspaso IdTraspasoObraNavigation { get; set; }
        public virtual AcAlmacenTraspaso IdTraspasoTransitoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
