using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatEstado
    {
        public AcCatEstado()
        {
            AcCatCiudades = new HashSet<AcCatCiudade>();
            AcClientes = new HashSet<AcCliente>();
            AcClientesAntilavados = new HashSet<AcClientesAntilavado>();
            AcClientesFacturas = new HashSet<AcClientesFactura>();
            CvAvales = new HashSet<CvAvale>();
            CvClientes = new HashSet<CvCliente>();
            CvClientesFacturas = new HashSet<CvClientesFactura>();
            CvEmpresas = new HashSet<CvEmpresa>();
            CvPlazas = new HashSet<CvPlaza>();
            FeneodataMatrizSucursales = new HashSet<FeneodataMatrizSucursale>();
        }

        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string EstadoInegi { get; set; }
        public string Nombre { get; set; }
        public string ClaveEstadoSat { get; set; }

        public virtual ICollection<AcCatCiudade> AcCatCiudades { get; set; }
        public virtual ICollection<AcCliente> AcClientes { get; set; }
        public virtual ICollection<AcClientesAntilavado> AcClientesAntilavados { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual ICollection<CvAvale> CvAvales { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturas { get; set; }
        public virtual ICollection<CvEmpresa> CvEmpresas { get; set; }
        public virtual ICollection<CvPlaza> CvPlazas { get; set; }
        public virtual ICollection<FeneodataMatrizSucursale> FeneodataMatrizSucursales { get; set; }
    }
}
