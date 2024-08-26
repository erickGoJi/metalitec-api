using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvVendedore
    {
        public CvVendedore()
        {
            CvAplicacionDepositos = new HashSet<CvAplicacionDeposito>();
            CvClienteDirectorNavigations = new HashSet<CvCliente>();
            CvClienteGerenteNavigations = new HashSet<CvCliente>();
            CvClienteVendedor1Navigations = new HashSet<CvCliente>();
            CvClienteVendedor2Navigations = new HashSet<CvCliente>();
            CvClienteVendedor3Navigations = new HashSet<CvCliente>();
            CvClienteVendedor4Navigations = new HashSet<CvCliente>();
            CvClienteVendedor5Navigations = new HashSet<CvCliente>();
            CvClienteVendedorExternoNavigations = new HashSet<CvCliente>();
            CvComisiones = new HashSet<CvComisione>();
            CvFlujoClienteDirectorNavigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteGerenteNavigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteVendedor1Navigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteVendedor2Navigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteVendedor3Navigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteVendedor4Navigations = new HashSet<CvFlujoCliente>();
            CvFlujoClienteVendedorExternoNavigations = new HashSet<CvFlujoCliente>();
            CvProyectosVendedores = new HashSet<CvProyectosVendedore>();
        }

        public int IdVendedor { get; set; }
        public string Vendedor { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Lada { get; set; }
        public string Curp { get; set; }
        public byte? Tipo { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdSucursal { get; set; }
        public bool Bloqueado { get; set; }
        public int? IdPromotora { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int? IdInsumo { get; set; }
        public byte? TipoContacto { get; set; }
        public decimal PorcentajeBaseParaCalculo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBloqueo { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual CvPromotora IdPromotoraNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual CvSucursale IdSucursalNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositos { get; set; }
        public virtual ICollection<CvCliente> CvClienteDirectorNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteGerenteNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedor1Navigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedor2Navigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedor3Navigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedor4Navigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedor5Navigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteVendedorExternoNavigations { get; set; }
        public virtual ICollection<CvComisione> CvComisiones { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteDirectorNavigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteGerenteNavigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteVendedor1Navigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteVendedor2Navigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteVendedor3Navigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteVendedor4Navigations { get; set; }
        public virtual ICollection<CvFlujoCliente> CvFlujoClienteVendedorExternoNavigations { get; set; }
        public virtual ICollection<CvProyectosVendedore> CvProyectosVendedores { get; set; }
    }
}
