using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesAddenda
    {
        public int IdClienteAddenda { get; set; }
        public int IdCliente { get; set; }
        public string CodigoAddenda { get; set; }
        public bool Predeterminada { get; set; }

        public virtual AcCliente IdClienteNavigation { get; set; }
    }
}
