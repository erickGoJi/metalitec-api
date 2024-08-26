using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class RepDestajoNomina
    {
        public int? Proyecto { get; set; }
        public string Subcont { get; set; }
        public decimal? Importe { get; set; }
        public decimal? AnticipoCan { get; set; }
        public decimal? FonGarCan { get; set; }
        public decimal? FonGarAm { get; set; }
        public decimal? Descuen { get; set; }
        public decimal? Liquido { get; set; }
        public decimal? TotalPercep { get; set; }
        public decimal? TotalDeduc { get; set; }
        public decimal? SueldoLiquido { get; set; }
    }
}
