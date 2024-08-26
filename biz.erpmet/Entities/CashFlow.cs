using System;
using System.ComponentModel;

namespace biz.erpmet.Entities
{
    public class CashFlow
    {
        public DateTime FechaFactura { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public decimal CargoCuentaClientesAnticpos { get; set; }
        public decimal CargoCuentaClientesAnticposPedidos { get; set; }
        public decimal AbonoCuentaProveedorAnticipos { get; set; }
        public decimal AbonoCuentaProveedorEstimacionPedidos { get; set; }
        public int idPoliza { get; set; }
        public decimal Pagado { get; set; }
        [DefaultValue(0)]
        public decimal PagadoTrasladado { get; set; }
        [DefaultValue(0)]
        public decimal MayorTresMeses { get; set; }
        public string Descripcion { get; set; }
    }
}