using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPolizasDet
    {
        public CtbPolizasDet()
        {
            AcClientesFacturas = new HashSet<AcClientesFactura>();
            AcClientesFacturasNcIdPolizaDetFacturaNavigations = new HashSet<AcClientesFacturasNc>();
            AcClientesFacturasNcIdPolizaDetNavigations = new HashSet<AcClientesFacturasNc>();
            AcComplementoPagoDets = new HashSet<AcComplementoPagoDet>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcs = new HashSet<AcFacturasProveedoresNc>();
            CtbPolizasDetApIdPolizaDetAbonoNavigations = new HashSet<CtbPolizasDetAp>();
            CtbPolizasDetApIdPolizaDetCargoNavigations = new HashSet<CtbPolizasDetAp>();
            CtbPolizasDetClientes = new HashSet<CtbPolizasDetCliente>();
            CtbPolizasDetCompExts = new HashSet<CtbPolizasDetCompExt>();
            CtbPolizasDetCompNalOtrs = new HashSet<CtbPolizasDetCompNalOtr>();
            CtbPolizasDetCompNals = new HashSet<CtbPolizasDetCompNal>();
            CtbPolizasDetDcIdPolizaDetAbonoNavigations = new HashSet<CtbPolizasDetDc>();
            CtbPolizasDetDcIdPolizaDetCargoNavigations = new HashSet<CtbPolizasDetDc>();
            CtbPolizasDetNodoCheques = new HashSet<CtbPolizasDetNodoCheque>();
            CtbPolizasDetNodoOtrMetodosPagos = new HashSet<CtbPolizasDetNodoOtrMetodosPago>();
            CtbPolizasDetNodoTransferencia = new HashSet<CtbPolizasDetNodoTransferencia>();
            CtbPolizasDetPps = new HashSet<CtbPolizasDetPp>();
            CtbPolizasIetuconceptos = new HashSet<CtbPolizasIetuconcepto>();
            CtbPolizasIetus = new HashSet<CtbPolizasIetu>();
        }

        public int IdPolizaDet { get; set; }
        public int IdPoliza { get; set; }
        public int IdCuenta { get; set; }
        public int IdProyecto { get; set; }
        public int? IdFlujo { get; set; }
        public bool? EsAutomatica { get; set; }
        public int Renglon { get; set; }
        public string Observaciones { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public bool MovIntercentro { get; set; }
        public DateTime? FechaProbablePago { get; set; }
        public bool EnDisputa { get; set; }
        public decimal MontoIetu { get; set; }
        public int? IdClienteAntilavado { get; set; }
        public decimal TipoCambioSat { get; set; }
        public string MonedaSat { get; set; }
        public bool EsEfectivo { get; set; }

        public virtual AcClientesAntilavado IdClienteAntilavadoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdPolizaDetFacturaNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdPolizaDetNavigations { get; set; }
        public virtual ICollection<AcComplementoPagoDet> AcComplementoPagoDets { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
        public virtual ICollection<CtbPolizasDetAp> CtbPolizasDetApIdPolizaDetAbonoNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetAp> CtbPolizasDetApIdPolizaDetCargoNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetCliente> CtbPolizasDetClientes { get; set; }
        public virtual ICollection<CtbPolizasDetCompExt> CtbPolizasDetCompExts { get; set; }
        public virtual ICollection<CtbPolizasDetCompNalOtr> CtbPolizasDetCompNalOtrs { get; set; }
        public virtual ICollection<CtbPolizasDetCompNal> CtbPolizasDetCompNals { get; set; }
        public virtual ICollection<CtbPolizasDetDc> CtbPolizasDetDcIdPolizaDetAbonoNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetDc> CtbPolizasDetDcIdPolizaDetCargoNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetNodoCheque> CtbPolizasDetNodoCheques { get; set; }
        public virtual ICollection<CtbPolizasDetNodoOtrMetodosPago> CtbPolizasDetNodoOtrMetodosPagos { get; set; }
        public virtual ICollection<CtbPolizasDetNodoTransferencia> CtbPolizasDetNodoTransferencia { get; set; }
        public virtual ICollection<CtbPolizasDetPp> CtbPolizasDetPps { get; set; }
        public virtual ICollection<CtbPolizasIetuconcepto> CtbPolizasIetuconceptos { get; set; }
        public virtual ICollection<CtbPolizasIetu> CtbPolizasIetus { get; set; }
    }
}
