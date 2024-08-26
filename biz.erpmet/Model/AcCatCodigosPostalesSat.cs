using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatCodigosPostalesSat
    {
        public AcCatCodigosPostalesSat()
        {
            AcClientes = new HashSet<AcCliente>();
            CvClientes = new HashSet<CvCliente>();
            FeneodataMatrizSucursales = new HashSet<FeneodataMatrizSucursale>();
        }

        public int IdCodigoPostalSat { get; set; }
        public string CodigoPostalSat { get; set; }
        public string CodigoEstadoSat { get; set; }
        public string CodigoMunicipioSat { get; set; }
        public string CodigoLocalidadSat { get; set; }
        public string Version { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public bool EsFranjaFronteriza { get; set; }
        public DateTime? FechaIniVig { get; set; }

        public virtual ICollection<AcCliente> AcClientes { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<FeneodataMatrizSucursale> FeneodataMatrizSucursales { get; set; }
    }
}
