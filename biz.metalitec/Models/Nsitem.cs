using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Nsitem
    {
        public string Code { get; set; }
        public string Descr { get; set; }
        public string Shortdes { get; set; }
        public decimal Rate { get; set; }
        public string Unit { get; set; }
        public decimal Unitqty { get; set; }
        public string Pcat { get; set; }
        public string Ccode { get; set; }
        public string Unittype { get; set; }
        public decimal Weight { get; set; }
        public decimal Diam { get; set; }
        public decimal Len { get; set; }
        public string Grade { get; set; }
        public string Cup { get; set; }
        public string Fin { get; set; }
        public decimal Minlevel { get; set; }
        public decimal Maxlevel { get; set; }
        public string Lastsupp { get; set; }
        public decimal Lastrate { get; set; }
        public DateTime Lastdate { get; set; }
        public string Prefsupp { get; set; }
        public decimal Lastqty { get; set; }
        public bool Stockitem { get; set; }
        public decimal Sprice1 { get; set; }
        public decimal Sprice2 { get; set; }
        public decimal Sprice3 { get; set; }
        public decimal Reorderqty { get; set; }
    }
}
