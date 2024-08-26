using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProyectoConcepto
    {
        public AcProyectoConcepto()
        {
            AcCfditrasladoDets = new HashSet<AcCfditrasladoDet>();
            AcConceptosDetNcs = new HashSet<AcConceptosDetNc>();
            AcContratosDets = new HashSet<AcContratosDet>();
        }

        public int IdProyectoConcepto { get; set; }
        public int IdProyecto { get; set; }
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUnidad { get; set; }
        public int IdTipoConceptoCliente { get; set; }
        public int IdTipoMoneda { get; set; }
        public decimal Precio { get; set; }
        public string Unidad { get; set; }
        public int? IdUnidadSat { get; set; }
        public int? IdProductoServicioSat { get; set; }

        public virtual AcCatProductosServicioSat IdProductoServicioSatNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatTipoConceptosCliente IdTipoConceptoClienteNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual AcCatUnidadesSat IdUnidadSatNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcCfditrasladoDet> AcCfditrasladoDets { get; set; }
        public virtual ICollection<AcConceptosDetNc> AcConceptosDetNcs { get; set; }
        public virtual ICollection<AcContratosDet> AcContratosDets { get; set; }
    }
}
