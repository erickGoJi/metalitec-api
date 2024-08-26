using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFlujoCliente
    {
        public CvFlujoCliente()
        {
            CvFlujoClientesDets = new HashSet<CvFlujoClientesDet>();
        }

        public int IdFlujoCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdCetapa { get; set; }
        public bool Terminado { get; set; }
        public DateTime? FechaTerminado { get; set; }
        public int? Vendedor1 { get; set; }
        public int? Vendedor2 { get; set; }
        public int? Gerente { get; set; }
        public int? Director { get; set; }
        public int? VendedorExterno { get; set; }
        public DateTime? FechaInicio { get; set; }
        public bool PagadaVendedor1 { get; set; }
        public bool PagadaVendedor2 { get; set; }
        public bool PagadaGerente { get; set; }
        public bool PagadaDirector { get; set; }
        public bool PagadaVendedorExterno { get; set; }
        public int? Vendedor3 { get; set; }
        public int? Vendedor4 { get; set; }
        public bool PagadaVendedor3 { get; set; }
        public bool PagadaVendedor4 { get; set; }
        public int? Vendedor5 { get; set; }
        public bool PagadaVendedor5 { get; set; }

        public virtual CvVendedore DirectorNavigation { get; set; }
        public virtual CvVendedore GerenteNavigation { get; set; }
        public virtual CvCetapa IdCetapaNavigation { get; set; }
        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvVendedore Vendedor1Navigation { get; set; }
        public virtual CvVendedore Vendedor2Navigation { get; set; }
        public virtual CvVendedore Vendedor3Navigation { get; set; }
        public virtual CvVendedore Vendedor4Navigation { get; set; }
        public virtual CvVendedore VendedorExternoNavigation { get; set; }
        public virtual ICollection<CvFlujoClientesDet> CvFlujoClientesDets { get; set; }
    }
}
