using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatCategoriasProrrateo
    {
        public AcCatCategoriasProrrateo()
        {
            AcCatInsumosProrrateos = new HashSet<AcCatInsumosProrrateo>();
        }

        public int IdCategoriaProrrateo { get; set; }
        public string Categoria { get; set; }
        public int IdCuentaCargo { get; set; }
        public int IdCuentaAbono { get; set; }
        public decimal CostoHora { get; set; }
        public decimal CostoDia { get; set; }
        public decimal CostoSemana { get; set; }
        public decimal CostoMes { get; set; }

        public virtual CtbCuenta IdCuentaAbonoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaCargoNavigation { get; set; }
        public virtual ICollection<AcCatInsumosProrrateo> AcCatInsumosProrrateos { get; set; }
    }
}
