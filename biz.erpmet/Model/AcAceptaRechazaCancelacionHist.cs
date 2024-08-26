using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcAceptaRechazaCancelacionHist
    {
        public int IdAceptaRechazaCancelacionHist { get; set; }
        public string RfcEmisor { get; set; }
        public string Uuid { get; set; }
        public string EstatusUuid { get; set; }
        public string Respuesta { get; set; }
        public string SolicitudEnviada { get; set; }
        public DateTime? FechaRespuesta { get; set; }
    }
}
