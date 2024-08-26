using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFlujoClientesDet
    {
        public int IdFlujoClienteDet { get; set; }
        public int IdFlujoCliente { get; set; }
        public int IdCetapaDet { get; set; }
        public bool Terminado { get; set; }
        public DateTime? FechaTerminado { get; set; }
        public string RutaDocumento { get; set; }

        public virtual CvCetapasDet IdCetapaDetNavigation { get; set; }
        public virtual CvFlujoCliente IdFlujoClienteNavigation { get; set; }
    }
}
