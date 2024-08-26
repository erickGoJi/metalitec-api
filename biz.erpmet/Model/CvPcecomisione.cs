using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPcecomisione
    {
        public int IdPcecomision { get; set; }
        public int IdProyectoCredito { get; set; }
        public int IdCetapa { get; set; }
        public decimal ComisionVendedor1 { get; set; }
        public decimal ComisionVendedor2 { get; set; }
        public decimal ComisionGerente { get; set; }
        public decimal ComisionDirector { get; set; }
        public decimal ComisionExterno { get; set; }
        public decimal ComisionVendedor3 { get; set; }
        public decimal ComisionVendedor4 { get; set; }
        public decimal ComisionVendedor5 { get; set; }

        public virtual CvCetapa IdCetapaNavigation { get; set; }
        public virtual CvProyectosCredito IdProyectoCreditoNavigation { get; set; }
    }
}
