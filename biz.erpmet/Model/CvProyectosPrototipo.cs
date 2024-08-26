using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosPrototipo
    {
        public CvProyectosPrototipo()
        {
            CvPpecostos = new HashSet<CvPpecosto>();
            CvPppresupuestos = new HashSet<CvPppresupuesto>();
            CvProyectosDescuentos = new HashSet<CvProyectosDescuento>();
            CvProyectosPreciosLista = new HashSet<CvProyectosPreciosLista>();
        }

        public int IdProyectoPrototipo { get; set; }
        public int IdProyecto { get; set; }
        public int IdPrototipo { get; set; }
        public decimal Precio { get; set; }
        public decimal Enganche { get; set; }
        public int IdTipoMoneda { get; set; }
        public decimal PrecioTerreno { get; set; }
        public decimal CostoVivienda { get; set; }
        public decimal CostoTerreno { get; set; }
        public decimal BaseCalculoComisiones { get; set; }
        public string Partida { get; set; }
        public long? ViviendasMax { get; set; }
        public decimal Descuento { get; set; }
        public string RutaImagenCotizacion { get; set; }

        public virtual CvPrototipo IdPrototipoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual ICollection<CvPpecosto> CvPpecostos { get; set; }
        public virtual ICollection<CvPppresupuesto> CvPppresupuestos { get; set; }
        public virtual ICollection<CvProyectosDescuento> CvProyectosDescuentos { get; set; }
        public virtual ICollection<CvProyectosPreciosLista> CvProyectosPreciosLista { get; set; }
    }
}
