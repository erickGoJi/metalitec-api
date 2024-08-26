using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcactivoFijo
    {
        public AcactivoFijo()
        {
            AcactivoFijoDets = new HashSet<AcactivoFijoDet>();
        }

        public int IdActivo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public DateTime FechaCompra { get; set; }
        public string LugarDeCompra { get; set; }
        public decimal ImporteCompra { get; set; }
        public int? IdProveedor { get; set; }
        public string Observaciones { get; set; }
        public int IdCategoriaActivo { get; set; }

        public virtual AccategoriaActivoFijo IdCategoriaActivoNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual ICollection<AcactivoFijoDet> AcactivoFijoDets { get; set; }
    }
}
