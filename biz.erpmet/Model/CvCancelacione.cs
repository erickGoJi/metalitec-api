using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCancelacione
    {
        public int IdCancelacion { get; set; }
        public int FolioCancelacion { get; set; }
        public int? IdContrato { get; set; }
        public int IdTipoFalla { get; set; }
        public int IdCliente { get; set; }
        public int? IdPoliza { get; set; }
        public bool TipoDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoDevolucion { get; set; }
        public decimal MontoPenalizacion { get; set; }
        public string Observaciones { get; set; }
        public decimal MontoIvaPenalizacion { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoApartadoSinAplicar { get; set; }
        public string Vivienda { get; set; }
        public string Lote { get; set; }
        public string Manzana { get; set; }
        public string M2terreno { get; set; }
        public decimal PrecioTerreno { get; set; }
        public bool TieneRecContVenta { get; set; }
        public int? IdClienteFactura { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvContrato IdContratoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual CvTiposFalla IdTipoFallaNavigation { get; set; }
    }
}
