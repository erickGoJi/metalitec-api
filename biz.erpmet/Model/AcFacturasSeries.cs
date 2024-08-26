using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcFacturasSeries
    {
        public int IdFacturaSerie { get; set; }
        public string FacturaSerie { get; set; }
        public int Folio { get; set; }
        public bool Predeterminado { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public int FolioFinal { get; set; }
        public string TipoComprobante { get; set; }
        public byte[] ImagenCbb { get; set; }
        public int FolioInicial { get; set; }
        public int? NoAprobacion { get; set; }
        public bool EsCbb { get; set; }
        public int? IdMatrizSucursal { get; set; }

        public virtual FeneodataMatrizSucursale IdMatrizSucursalNavigation { get; set; }
    }
}
