using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatMoneda
    {
        public AcCatMoneda()
        {
            AcCatInsumos = new HashSet<AcCatInsumo>();
            AcCatMonedasDets = new HashSet<AcCatMonedasDet>();
            AcClientes = new HashSet<AcCliente>();
            AcCuentasBancaria = new HashSet<AcCuentasBancaria>();
            AcProveedores = new HashSet<AcProveedore>();
            AcProyectoConceptos = new HashSet<AcProyectoConcepto>();
            AoCatDestajista = new HashSet<AoCatDestajista>();
            CtbCuenta = new HashSet<CtbCuenta>();
            CvClientes = new HashSet<CvCliente>();
            CvClientesFacturas = new HashSet<CvClientesFactura>();
            CvContratosAccesorios = new HashSet<CvContratosAccesorio>();
            CvPlanesPagos = new HashSet<CvPlanesPago>();
            CvProyectosAccesorios = new HashSet<CvProyectosAccesorio>();
            CvProyectosPaquetes = new HashSet<CvProyectosPaquete>();
            CvProyectosPrototipos = new HashSet<CvProyectosPrototipo>();
            CvViviendasAccesorios = new HashSet<CvViviendasAccesorio>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdTipoMoneda { get; set; }
        public int TipoMoneda { get; set; }
        public string Descripcion { get; set; }
        public decimal Paridad { get; set; }
        public string RemateMoneda { get; set; }
        public string DescripcionParaExportar { get; set; }
        public int? IdCatMonedasSat { get; set; }

        public virtual CtbCatMonedasSat IdCatMonedasSatNavigation { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
        public virtual ICollection<AcCatMonedasDet> AcCatMonedasDets { get; set; }
        public virtual ICollection<AcCliente> AcClientes { get; set; }
        public virtual ICollection<AcCuentasBancaria> AcCuentasBancaria { get; set; }
        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
        public virtual ICollection<AcProyectoConcepto> AcProyectoConceptos { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajista { get; set; }
        public virtual ICollection<CtbCuenta> CtbCuenta { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturas { get; set; }
        public virtual ICollection<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual ICollection<CvPlanesPago> CvPlanesPagos { get; set; }
        public virtual ICollection<CvProyectosAccesorio> CvProyectosAccesorios { get; set; }
        public virtual ICollection<CvProyectosPaquete> CvProyectosPaquetes { get; set; }
        public virtual ICollection<CvProyectosPrototipo> CvProyectosPrototipos { get; set; }
        public virtual ICollection<CvViviendasAccesorio> CvViviendasAccesorios { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
