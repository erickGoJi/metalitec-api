using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProveedoresCertificado
    {
        public int IdProveedorCertificado { get; set; }
        public int IdProveedor { get; set; }
        public string NoCertificado { get; set; }
        public string Certificado { get; set; }
        public DateTime? VigenciaInicial { get; set; }
        public DateTime? VigenciaFinal { get; set; }
        public bool Descargado { get; set; }

        public virtual AcProveedore IdProveedorNavigation { get; set; }
    }
}
