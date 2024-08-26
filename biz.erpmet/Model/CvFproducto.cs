using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFproducto
    {
        public CvFproducto()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdFproducto { get; set; }
        public string Fproducto { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
