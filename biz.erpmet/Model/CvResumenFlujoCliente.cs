using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvResumenFlujoCliente
    {
        public int IdCliente { get; set; }
        public string Proyecto { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Credito { get; set; }
        public string Texto { get; set; }
        public bool? FlujoTerminado { get; set; }
        public bool EscrituradoReal { get; set; }
        public string EtapaCliente { get; set; }
        public short? Duracion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public bool? TieneVivienda { get; set; }
        public string Vivienda { get; set; }
        public bool? TieneCredito { get; set; }
        public int? Retraso { get; set; }
        public DateTime? FechaProbableFin { get; set; }
        public int? RetrasoAcumulado { get; set; }
        public int? IdFlujoCliente { get; set; }
        public int? IdProyecto { get; set; }
        public int? Vendedor1 { get; set; }
        public int? Vendedor2 { get; set; }
        public int? Gerente { get; set; }
        public int? Director { get; set; }
        public int? VendedorExterno { get; set; }
        public string Notas { get; set; }
        public string SofolPuente { get; set; }
        public string SofolCredito { get; set; }
    }
}
