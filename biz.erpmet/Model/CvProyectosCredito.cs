using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosCredito
    {
        public CvProyectosCredito()
        {
            CvPcecomisiones = new HashSet<CvPcecomisione>();
            CvPppresupuestos = new HashSet<CvPppresupuesto>();
        }

        public int IdProyectoCredito { get; set; }
        public int IdProyecto { get; set; }
        public int IdCredito { get; set; }
        public decimal InteresMoratorio { get; set; }
        public string NoFijoReferencia { get; set; }
        public string ConsecutivoReferencia { get; set; }

        public virtual CvCredito IdCreditoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<CvPcecomisione> CvPcecomisiones { get; set; }
        public virtual ICollection<CvPppresupuesto> CvPppresupuestos { get; set; }
    }
}
