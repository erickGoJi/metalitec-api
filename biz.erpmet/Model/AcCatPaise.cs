using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatPaise
    {
        public AcCatPaise()
        {
            AcClientes = new HashSet<AcCliente>();
            AcClientesFacturas2017s = new HashSet<AcClientesFacturas2017>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            AcProveedores = new HashSet<AcProveedore>();
            CvClientes = new HashSet<CvCliente>();
            CvClientesFacturas2017s = new HashSet<CvClientesFacturas2017>();
            FeneodataMatrizSucursales = new HashSet<FeneodataMatrizSucursale>();
        }

        public int IdPais { get; set; }
        public string ClavePais { get; set; }
        public string DescripcionPais { get; set; }
        public string Agrupaciones { get; set; }
        public string FormatoCp { get; set; }
        public string ValidacionRegIdTrib { get; set; }
        public string FormatoRegIdTrib { get; set; }
        public string Version { get; set; }

        public virtual ICollection<AcCliente> AcClientes { get; set; }
        public virtual ICollection<AcClientesFacturas2017> AcClientesFacturas2017s { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvClientesFacturas2017> CvClientesFacturas2017s { get; set; }
        public virtual ICollection<FeneodataMatrizSucursale> FeneodataMatrizSucursales { get; set; }
    }
}
