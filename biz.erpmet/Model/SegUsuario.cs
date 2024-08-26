using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class SegUsuario
    {
        public SegUsuario()
        {
            AcAditivasExplosions = new HashSet<AcAditivasExplosion>();
            AcAjustesPedidoIdUsuarioCancelacionNavigations = new HashSet<AcAjustesPedido>();
            AcAjustesPedidoIdUsuarioNavigations = new HashSet<AcAjustesPedido>();
            AcAlmacenEntradaIdUsuarioDevolucionNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenEntradaIdUsuarioModificacionNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenEntradaIdUsuarioNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenOproduccions = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenSalidaIdUsuarioModificacionNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaIdUsuarioNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaIdUsuarioRecuperacionNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenTraspasoIdUsuarioModificacionNavigations = new HashSet<AcAlmacenTraspaso>();
            AcAlmacenTraspasoIdUsuarioNavigations = new HashSet<AcAlmacenTraspaso>();
            AcBancosEgresoIdUsuarioCancelacionNavigations = new HashSet<AcBancosEgreso>();
            AcBancosEgresoIdUsuarioNavigations = new HashSet<AcBancosEgreso>();
            AcBancosIngresoIdUsuarioCancelacionNavigations = new HashSet<AcBancosIngreso>();
            AcBancosIngresoIdUsuarioNavigations = new HashSet<AcBancosIngreso>();
            AcBancosTraspasoIdUsuarioCancelacionNavigations = new HashSet<AcBancosTraspaso>();
            AcBancosTraspasoIdUsuarioNavigations = new HashSet<AcBancosTraspaso>();
            AcCatInsumos = new HashSet<AcCatInsumo>();
            AcCfditrasladoIdUsuarioCancelacionNavigations = new HashSet<AcCfditraslado>();
            AcCfditrasladoIdUsuarioNavigations = new HashSet<AcCfditraslado>();
            AcClientesFacturaIdUsuarioCancelacionNavigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdUsuarioNavigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdUsuarioUltimoCambioNavigations = new HashSet<AcClientesFactura>();
            AcClientesFacturasNcIdUsuarioCancelacionNavigations = new HashSet<AcClientesFacturasNc>();
            AcClientesFacturasNcIdUsuarioNavigations = new HashSet<AcClientesFacturasNc>();
            AcClientesRemisioneIdUsuarioNavigations = new HashSet<AcClientesRemisione>();
            AcClientesRemisioneIdUsuarioUltimoCambioNavigations = new HashSet<AcClientesRemisione>();
            AcComplementoPagoIdUsuarioCancelacionNavigations = new HashSet<AcComplementoPago>();
            AcComplementoPagoIdUsuarioNavigations = new HashSet<AcComplementoPago>();
            AcConstanciasRetencioneIdUsuarioCancelacionNavigations = new HashSet<AcConstanciasRetencione>();
            AcConstanciasRetencioneIdUsuarioNavigations = new HashSet<AcConstanciasRetencione>();
            AcConstanciasRetencioneIdUsuarioUltimoCambioNavigations = new HashSet<AcConstanciasRetencione>();
            AcContratoIdUsuarioAutorizaNavigations = new HashSet<AcContrato>();
            AcContratoIdUsuarioNavigations = new HashSet<AcContrato>();
            AcFacturasProveedoreIdUsuarioCancelacionNavigations = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoreIdUsuarioNavigations = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcIdUsuarioCancelacionNavigations = new HashSet<AcFacturasProveedoresNc>();
            AcFacturasProveedoresNcIdUsuarioNavigations = new HashSet<AcFacturasProveedoresNc>();
            AcGastosFinancieroIdUsuarioCancelacionNavigations = new HashSet<AcGastosFinanciero>();
            AcGastosFinancieroIdUsuarioNavigations = new HashSet<AcGastosFinanciero>();
            AcGastosXcomprobarIdUsuarioCancelacionNavigations = new HashSet<AcGastosXcomprobar>();
            AcGastosXcomprobarIdUsuarioNavigations = new HashSet<AcGastosXcomprobar>();
            AcGeneradorPolizaIdUsuarioCancelacionNavigations = new HashSet<AcGeneradorPoliza>();
            AcGeneradorPolizaIdUsuarioNavigations = new HashSet<AcGeneradorPoliza>();
            AcNominaPolizas = new HashSet<AcNominaPoliza>();
            AcOrdenProduccionIdUsuarioCancelacionNavigations = new HashSet<AcOrdenProduccion>();
            AcOrdenProduccionIdUsuarioNavigations = new HashSet<AcOrdenProduccion>();
            AcPedidoIdUsuarioAutorizacionNavigations = new HashSet<AcPedido>();
            AcPedidoIdUsuarioCancelacionNavigations = new HashSet<AcPedido>();
            AcPedidoIdUsuarioNavigations = new HashSet<AcPedido>();
            AcPedidosBitacoras = new HashSet<AcPedidosBitacora>();
            AcProrrateoCostoIdUsuarioCancelacionNavigations = new HashSet<AcProrrateoCosto>();
            AcProrrateoCostoIdUsuarioNavigations = new HashSet<AcProrrateoCosto>();
            AcProyectoConceptos = new HashSet<AcProyectoConcepto>();
            AcRequisicionBitacoras = new HashSet<AcRequisicionBitacora>();
            AcRequisicioneIdUsuarioAutorizacionNavigations = new HashSet<AcRequisicione>();
            AcRequisicioneIdUsuarioCancelacionNavigations = new HashSet<AcRequisicione>();
            AcRequisicioneIdUsuarioNavigations = new HashSet<AcRequisicione>();
            AcSolicitudMaterials = new HashSet<AcSolicitudMaterial>();
            AoAnticiposDestajistaIdUsuarioCancelacionNavigations = new HashSet<AoAnticiposDestajista>();
            AoAnticiposDestajistaIdUsuarioNavigations = new HashSet<AoAnticiposDestajista>();
            AoDestajosEsts = new HashSet<AoDestajosEst>();
            AoMatrizOcs = new HashSet<AoMatrizOc>();
            AoPresupuestoControlOcs = new HashSet<AoPresupuestoControlOc>();
            AoSubContratos = new HashSet<AoSubContrato>();
            AoSubContratosEsts = new HashSet<AoSubContratosEst>();
            AoSubcontratosDetCostos = new HashSet<AoSubcontratosDetCosto>();
            AoSubcontratosOcs = new HashSet<AoSubcontratosOc>();
            BiHistoricos = new HashSet<BiHistorico>();
            Bitacoras = new HashSet<Bitacora>();
            CtbPolizas = new HashSet<CtbPoliza>();
            CtbPolizasDetApIdUsuarioAutorizoNavigations = new HashSet<CtbPolizasDetAp>();
            CtbPolizasDetApIdUsuarioEmitioChequeNavigations = new HashSet<CtbPolizasDetAp>();
            CtbPolizasDetApIdUsuarioManualNavigations = new HashSet<CtbPolizasDetAp>();
            CtbPolizasDetDcs = new HashSet<CtbPolizasDetDc>();
            CtbPolizasDetPps = new HashSet<CtbPolizasDetPp>();
            CvClientesFacturaIdUsuarioCancelacionNavigations = new HashSet<CvClientesFactura>();
            CvClientesFacturaIdUsuarioNavigations = new HashSet<CvClientesFactura>();
            CvClientesFacturaIdUsuarioUltimoCambioNavigations = new HashSet<CvClientesFactura>();
            CvComplementoPagoIdUsuarioCancelacionNavigations = new HashSet<CvComplementoPago>();
            CvComplementoPagoIdUsuarioNavigations = new HashSet<CvComplementoPago>();
            CvVendedores = new HashSet<CvVendedore>();
            FefoliosCfdxRfcs = new HashSet<FefoliosCfdxRfc>();
            FeseriesDigitalesXrfcs = new HashSet<FeseriesDigitalesXrfc>();
            NeoSysCatalogosUsuarios = new HashSet<NeoSysCatalogosUsuario>();
            ParametroUsuarios = new HashSet<ParametroUsuario>();
            SegUsuariosSistemas = new HashSet<SegUsuariosSistema>();
            SegUsuariosXproyectoRemesas = new HashSet<SegUsuariosXproyectoRemesa>();
            SegUsuariosXproyectos = new HashSet<SegUsuariosXproyecto>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public DateTime? FechaCambioPwd { get; set; }
        public bool Caduca { get; set; }
        public int Intentos { get; set; }
        public string Bloqueado { get; set; }
        public string Email { get; set; }

        public virtual AcContratosDatosAdicSeguridad AcContratosDatosAdicSeguridad { get; set; }
        public virtual ICollection<AcAditivasExplosion> AcAditivasExplosions { get; set; }
        public virtual ICollection<AcAjustesPedido> AcAjustesPedidoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcAjustesPedido> AcAjustesPedidoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdUsuarioDevolucionNavigations { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdUsuarioModificacionNavigations { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccions { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdUsuarioModificacionNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdUsuarioRecuperacionNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdUsuarioModificacionNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
        public virtual ICollection<AcCfditraslado> AcCfditrasladoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcCfditraslado> AcCfditrasladoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdUsuarioUltimoCambioNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcClientesRemisione> AcClientesRemisioneIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcClientesRemisione> AcClientesRemisioneIdUsuarioUltimoCambioNavigations { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcConstanciasRetencione> AcConstanciasRetencioneIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcConstanciasRetencione> AcConstanciasRetencioneIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcConstanciasRetencione> AcConstanciasRetencioneIdUsuarioUltimoCambioNavigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdUsuarioAutorizaNavigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedoreIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedoreIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieroIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieroIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobarIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobarIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizaIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizaIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcNominaPoliza> AcNominaPolizas { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccionIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccionIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdUsuarioAutorizacionNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcPedidosBitacora> AcPedidosBitacoras { get; set; }
        public virtual ICollection<AcProrrateoCosto> AcProrrateoCostoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcProrrateoCosto> AcProrrateoCostoIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcProyectoConcepto> AcProyectoConceptos { get; set; }
        public virtual ICollection<AcRequisicionBitacora> AcRequisicionBitacoras { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdUsuarioAutorizacionNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdUsuarioNavigations { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterials { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajistaIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajistaIdUsuarioNavigations { get; set; }
        public virtual ICollection<AoDestajosEst> AoDestajosEsts { get; set; }
        public virtual ICollection<AoMatrizOc> AoMatrizOcs { get; set; }
        public virtual ICollection<AoPresupuestoControlOc> AoPresupuestoControlOcs { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratos { get; set; }
        public virtual ICollection<AoSubContratosEst> AoSubContratosEsts { get; set; }
        public virtual ICollection<AoSubcontratosDetCosto> AoSubcontratosDetCostos { get; set; }
        public virtual ICollection<AoSubcontratosOc> AoSubcontratosOcs { get; set; }
        public virtual ICollection<BiHistorico> BiHistoricos { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
        public virtual ICollection<CtbPoliza> CtbPolizas { get; set; }
        public virtual ICollection<CtbPolizasDetAp> CtbPolizasDetApIdUsuarioAutorizoNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetAp> CtbPolizasDetApIdUsuarioEmitioChequeNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetAp> CtbPolizasDetApIdUsuarioManualNavigations { get; set; }
        public virtual ICollection<CtbPolizasDetDc> CtbPolizasDetDcs { get; set; }
        public virtual ICollection<CtbPolizasDetPp> CtbPolizasDetPps { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturaIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturaIdUsuarioNavigations { get; set; }
        public virtual ICollection<CvClientesFactura> CvClientesFacturaIdUsuarioUltimoCambioNavigations { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagoIdUsuarioCancelacionNavigations { get; set; }
        public virtual ICollection<CvComplementoPago> CvComplementoPagoIdUsuarioNavigations { get; set; }
        public virtual ICollection<CvVendedore> CvVendedores { get; set; }
        public virtual ICollection<FefoliosCfdxRfc> FefoliosCfdxRfcs { get; set; }
        public virtual ICollection<FeseriesDigitalesXrfc> FeseriesDigitalesXrfcs { get; set; }
        public virtual ICollection<NeoSysCatalogosUsuario> NeoSysCatalogosUsuarios { get; set; }
        public virtual ICollection<ParametroUsuario> ParametroUsuarios { get; set; }
        public virtual ICollection<SegUsuariosSistema> SegUsuariosSistemas { get; set; }
        public virtual ICollection<SegUsuariosXproyectoRemesa> SegUsuariosXproyectoRemesas { get; set; }
        public virtual ICollection<SegUsuariosXproyecto> SegUsuariosXproyectos { get; set; }
    }
}
