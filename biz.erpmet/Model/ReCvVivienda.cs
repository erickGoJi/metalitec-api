using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReCvVivienda
    {
        public string Proyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string Prototipo { get; set; }
        public string PrototipoComercial { get; set; }
        public int IdVivienda { get; set; }
        public string Plaza { get; set; }
        public string Desarrollo { get; set; }
        public string Etapa { get; set; }
        public decimal PrecioVentaEscritura { get; set; }
        public string EstatusEscritura { get; set; }
        public string EstatusAsignación { get; set; }
        public string TipoLote { get; set; }
        public string Vivienda { get; set; }
        public string EstatusConstrucción { get; set; }
    }
}
