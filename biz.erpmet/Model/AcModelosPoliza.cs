using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcModelosPoliza
    {
        public AcModelosPoliza()
        {
            AcGeneradorPolizas = new HashSet<AcGeneradorPoliza>();
        }

        public int IdPolizaModelo { get; set; }
        public string PolizaModelo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizas { get; set; }
    }
}
