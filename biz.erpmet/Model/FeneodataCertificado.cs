using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class FeneodataCertificado
    {
        public FeneodataCertificado()
        {
            FeneodataFolios = new HashSet<FeneodataFolio>();
        }

        public int IdCertificado { get; set; }
        public int IdMatrizSucursal { get; set; }
        public string NoCertificado { get; set; }
        public string Descripcion { get; set; }
        public string Password { get; set; }
        public string LlavePrivada { get; set; }
        public string Certificado { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
        public bool EsCfdi { get; set; }
        public bool EsCfiel { get; set; }

        public virtual FeneodataMatrizSucursale IdMatrizSucursalNavigation { get; set; }
        public virtual ICollection<FeneodataFolio> FeneodataFolios { get; set; }
    }
}
