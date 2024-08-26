using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoestimadoTerminacionDetalle
    {
        public int IdEstimadoDet { get; set; }
        public int IdEstimado { get; set; }
        public decimal Mafaltante { get; set; }
        public decimal Mofaltante { get; set; }
        public decimal Subfaltante { get; set; }
        public decimal Acafaltante { get; set; }
        public decimal Maestimado { get; set; }
        public decimal Moestimado { get; set; }
        public decimal Subestimado { get; set; }
        public decimal Acaestimado { get; set; }
        public decimal Eqfaltante { get; set; }
        public decimal Eqestimado { get; set; }

        public virtual AoestimadoTerminacion IdEstimadoNavigation { get; set; }
    }
}
