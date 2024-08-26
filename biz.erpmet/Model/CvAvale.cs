using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvAvale
    {
        public int IdAval { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public int? IdEstado { get; set; }
        public string MpioDeleg { get; set; }
        public string Telefono { get; set; }
        public string NumOficial { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
    }
}
