using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatCiudade
    {
        public AcCatCiudade()
        {
            AcCfditrasladoDirecciones = new HashSet<AcCfditrasladoDireccione>();
            AcClienteIdCiudadCobranzaNavigations = new HashSet<AcCliente>();
            AcClienteIdCiudadEnvioNavigations = new HashSet<AcCliente>();
            AcClienteIdCiudadNavigations = new HashSet<AcCliente>();
            AcClientesAntilavados = new HashSet<AcClientesAntilavado>();
            AcClientesFacturas = new HashSet<AcClientesFactura>();
            AcClientesPlanta = new HashSet<AcClientesPlanta>();
            AcProveedores = new HashSet<AcProveedore>();
            AoCatContratista = new HashSet<AoCatContratista>();
            AoCatDestajista = new HashSet<AoCatDestajista>();
            CvClientesFacturas = new HashSet<CvClientesFactura>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdCiudad { get; set; }
        public string Ciudad { get; set; }
        public string Descripcion { get; set; }
        public int IdEstado { get; set; }

        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual ICollection<AcCfditrasladoDireccione> AcCfditrasladoDirecciones { get; set; }
        public virtual ICollection<AcCliente> AcClienteIdCiudadCobranzaNavigations { get; set; }
        public virtual ICollection<AcCliente> AcClienteIdCiudadEnvioNavigations { get; set; }
        public virtual ICollection<AcCliente> AcClienteIdCiudadNavigations { get; set; }
        public virtual ICollection<AcClientesAntilavado> AcClientesAntilavados { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual ICollection<AcClientesPlanta> AcClientesPlanta { get; set; }
        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
        public virtual ICollection<AoCatContratista> AoCatContratista { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajista { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturas { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
