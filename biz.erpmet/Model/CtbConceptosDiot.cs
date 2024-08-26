using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbConceptosDiot
    {
        public CtbConceptosDiot()
        {
            AcGastosXcomprobarDetDiots = new HashSet<AcGastosXcomprobarDetDiot>();
            CtbCuenta = new HashSet<CtbCuenta>();
            CtbPolizasDiots = new HashSet<CtbPolizasDiot>();
        }

        public int IdConceptoDiot { get; set; }
        public string Concepto { get; set; }
        public bool? MostrarEnCuentas { get; set; }
        public string DescripcionCuenta { get; set; }

        public virtual ICollection<AcGastosXcomprobarDetDiot> AcGastosXcomprobarDetDiots { get; set; }
        public virtual ICollection<CtbCuenta> CtbCuenta { get; set; }
        public virtual ICollection<CtbPolizasDiot> CtbPolizasDiots { get; set; }
    }
}
