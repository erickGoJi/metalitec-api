using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProrrateoCostosDet
    {
        public int IdProrrateoCostosDet { get; set; }
        public int IdProrrateoCostos { get; set; }
        public int IdInsumoProrrateo { get; set; }
        public int Periodo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual AcCatInsumosProrrateo IdInsumoProrrateoNavigation { get; set; }
        public virtual AcProrrateoCosto IdProrrateoCostosNavigation { get; set; }
    }
}
