using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFlujoEfectivoOtrosIngresosEgreso
    {
        public int IdFlujoEfectivoOtroIngresoEgreso { get; set; }
        public int IdProyecto { get; set; }
        public int IdTipoOtroIngresoEgreso { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public int IdCuentaBancaria { get; set; }
        public bool EsEgreso { get; set; }
        public decimal Monto { get; set; }
        public bool YaSaldado { get; set; }
        public string Observaciones { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatFlujoEfectivoOtrosIngresosEgreso IdTipoOtroIngresoEgresoNavigation { get; set; }
    }
}
