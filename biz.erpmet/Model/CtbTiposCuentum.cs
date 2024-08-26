using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbTiposCuentum
    {
        public CtbTiposCuentum()
        {
            CtbCuenta = new HashSet<CtbCuenta>();
        }

        public int IdTipoCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string SubTipoCuenta { get; set; }
        public bool Naturaleza { get; set; }
        public string Texto { get; set; }
        public string TextoSubtipo { get; set; }
        public string CuentaInicial { get; set; }
        public string CuentaFinal { get; set; }
        public string TiposDeUtilidad { get; set; }
        public string Operador { get; set; }

        public virtual ICollection<CtbCuenta> CtbCuenta { get; set; }
    }
}
