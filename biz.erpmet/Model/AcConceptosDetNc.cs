using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcConceptosDetNc
    {
        public int IdConceptosDetNc { get; set; }
        public int IdClienteFacturaNcdet { get; set; }
        public int IdProyectoPartida { get; set; }
        public int Renglon { get; set; }
        public int IdProyectoConcepto { get; set; }
        public string DescripcionAuxiliar { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }

        public virtual AcProyectoConcepto IdProyectoConceptoNavigation { get; set; }
        public virtual AcProyectoPartida IdProyectoPartidaNavigation { get; set; }
    }
}
