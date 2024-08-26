using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvResumenPago
    {
        public int IdProyecto { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdContrato { get; set; }
        public string Contrato { get; set; }
        public DateTime Fecha { get; set; }
        public string Vivienda { get; set; }
        public string Credito { get; set; }
        public bool? TieneVivienda { get; set; }
        public bool? TieneCredito { get; set; }
        public bool? TieneSaldoPendiente { get; set; }
        public int? Vendedor1 { get; set; }
        public int? Vendedor2 { get; set; }
        public int? Gerente { get; set; }
        public int? Director { get; set; }
        public int? VendedorExterno { get; set; }
    }
}
