using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class ReCvCancelacione
    {
        public int Folio { get; set; }
        public string FechaCancelación { get; set; }
        public decimal MontoAnticipos { get; set; }
        public decimal MontoIvaPenalización { get; set; }
        public decimal MontoPenalización { get; set; }
        public decimal? MontoDevuelto { get; set; }
        public string Contrato { get; set; }
        public string TipoFalla { get; set; }
        public string Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Ejecutivo { get; set; }
        public string Proyecto { get; set; }
        public string NombreProyecto { get; set; }
        public string FechaContrato { get; set; }
        public int? DíasTranscurridos { get; set; }
        public int? Año { get; set; }
        public string Mes { get; set; }
        public int ContratoImpreso { get; set; }
        public string Crédito { get; set; }
    }
}
