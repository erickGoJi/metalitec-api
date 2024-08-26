using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatBancosSat
    {
        public AcCatBancosSat()
        {
            AcCuentasBancaria = new HashSet<AcCuentasBancaria>();
        }

        public int IdBancoSat { get; set; }
        public string Clave { get; set; }
        public string NombreCorto { get; set; }
        public string RazonSocial { get; set; }

        public virtual ICollection<AcCuentasBancaria> AcCuentasBancaria { get; set; }
    }
}
