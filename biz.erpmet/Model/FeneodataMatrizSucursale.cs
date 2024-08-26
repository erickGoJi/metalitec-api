using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class FeneodataMatrizSucursale
    {
        public FeneodataMatrizSucursale()
        {
            AcFacturasSeries = new HashSet<AcFacturasSeries>();
            FeneodataCertificados = new HashSet<FeneodataCertificado>();
        }

        public int IdMatrizSucursal { get; set; }
        public string MatrizSucursal { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Referencia { get; set; }
        public string Municipio { get; set; }
        public int? IdEstado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public bool EsMatriz { get; set; }
        public string LugarDeExpedicion { get; set; }
        public int? IdCodigoPostalSat { get; set; }
        public int? IdPaisSat { get; set; }
        public bool UsarEstimuloIvafronterizo { get; set; }

        public virtual AcCatCodigosPostalesSat IdCodigoPostalSatNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual AcCatPaise IdPaisSatNavigation { get; set; }
        public virtual ICollection<AcFacturasSeries> AcFacturasSeries { get; set; }
        public virtual ICollection<FeneodataCertificado> FeneodataCertificados { get; set; }
    }
}
