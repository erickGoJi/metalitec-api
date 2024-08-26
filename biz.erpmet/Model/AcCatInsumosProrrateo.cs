using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatInsumosProrrateo
    {
        public AcCatInsumosProrrateo()
        {
            AcProrrateoCostosDets = new HashSet<AcProrrateoCostosDet>();
        }

        public int IdInsumoProrrateo { get; set; }
        public string InsumoProrrateo { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoriaProrrateo { get; set; }
        public int IdProyectoAbono { get; set; }
        public decimal CostoHora { get; set; }
        public decimal CostoDia { get; set; }
        public decimal CostoSemana { get; set; }
        public decimal CostoMes { get; set; }

        public virtual AcCatCategoriasProrrateo IdCategoriaProrrateoNavigation { get; set; }
        public virtual Proyecto IdProyectoAbonoNavigation { get; set; }
        public virtual ICollection<AcProrrateoCostosDet> AcProrrateoCostosDets { get; set; }
    }
}
