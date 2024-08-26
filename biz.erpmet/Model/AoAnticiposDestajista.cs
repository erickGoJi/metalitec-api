using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoAnticiposDestajista
    {
        public int IdAnticipoDestajista { get; set; }
        public int IdDestajista { get; set; }
        public int IdProyecto { get; set; }
        public int IdPoliza { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuario { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string DescripcionCancelacion { get; set; }
        public int? IdUsuarioCancelacion { get; set; }

        public virtual AoCatDestajista IdDestajistaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
