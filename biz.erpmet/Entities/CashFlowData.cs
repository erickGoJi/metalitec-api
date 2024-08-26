using System;
using System.ComponentModel;

namespace biz.erpmet.Entities
{
    public class CashFlowData
    {
        [Description("FechaFactura")]
        public DateTime InvoiceDate { get; set; }
        [Description("anio")]
        public int Year { get; set; }
        [Description("mes")]
        public int Month { get; set; }
        [Description("Categoria")]
        public string Category { get; set; }
        [Description("idPoliza")]
        public int IdPolicy { get; set; }
        [Description("Descripcion")]
        public string Description { get; set; }
        [Description("ActFor")]
        public string Action { get; set; }
        [Description("Monto")]
        public decimal Amount { get; set; }
    }
}