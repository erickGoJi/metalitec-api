using System;

namespace biz.erpmet.Entities
{
    public class PurchaseHistory
    {
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }
        public string Insumo { get; set; }
        public DateTime FechaPedido { get; set; }
        public int IdProveedor { get; set; }
        public int IdProyecto { get; set; }
        public string Tipo { get; set; }
        public string DescripcionLarga { get; set; }
        public int IdInsumo { get; set; }
    }
}