using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPoliza
    {
        public CtbPoliza()
        {
            AcAlmacenEntradaIdPolizaInversaNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenEntradaIdPolizaNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenOproduccions = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenSalidaIdPolizaInversaNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaIdPolizaNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenTraspasoIdPolizaInversaNavigations = new HashSet<AcAlmacenTraspaso>();
            AcAlmacenTraspasoIdPolizaNavigations = new HashSet<AcAlmacenTraspaso>();
            AcBancosEgresoIdPolizaInversaNavigations = new HashSet<AcBancosEgreso>();
            AcBancosEgresoIdPolizaNavigations = new HashSet<AcBancosEgreso>();
            AcBancosIngresoIdPolizaInversaNavigations = new HashSet<AcBancosIngreso>();
            AcBancosIngresoIdPolizaNavigations = new HashSet<AcBancosIngreso>();
            AcBancosTraspasoIdPolizaInversaNavigations = new HashSet<AcBancosTraspaso>();
            AcBancosTraspasoIdPolizaNavigations = new HashSet<AcBancosTraspaso>();
            AcClientesFacturaIdPolizaInversaNavigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdPolizaNavigations = new HashSet<AcClientesFactura>();
            AcClientesFacturasNcIdPolizaInversaNavigations = new HashSet<AcClientesFacturasNc>();
            AcClientesFacturasNcIdPolizaNavigations = new HashSet<AcClientesFacturasNc>();
            AcFacturasProveedoreIdPolizaInversaNavigations = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoreIdPolizaNavigations = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcIdPolizaInversaNavigations = new HashSet<AcFacturasProveedoresNc>();
            AcFacturasProveedoresNcIdPolizaNavigations = new HashSet<AcFacturasProveedoresNc>();
            AcGastosFinancieroIdPolizaInversaNavigations = new HashSet<AcGastosFinanciero>();
            AcGastosFinancieroIdPolizaNavigations = new HashSet<AcGastosFinanciero>();
            AcGastosXcomprobarIdPolizaInversaNavigations = new HashSet<AcGastosXcomprobar>();
            AcGastosXcomprobarIdPolizaNavigations = new HashSet<AcGastosXcomprobar>();
            AcGeneradorPolizas = new HashSet<AcGeneradorPoliza>();
            AcNominaPolizaIdPolizaInversaNavigations = new HashSet<AcNominaPoliza>();
            AcNominaPolizaIdPolizaNavigations = new HashSet<AcNominaPoliza>();
            AcProrrateoCostoIdPolizaInversaNavigations = new HashSet<AcProrrateoCosto>();
            AcProrrateoCostoIdPolizaNavigations = new HashSet<AcProrrateoCosto>();
            AcProveedoresCfds = new HashSet<AcProveedoresCfd>();
            AoAnticiposDestajistaIdPolizaInversaNavigations = new HashSet<AoAnticiposDestajista>();
            AoAnticiposDestajistaIdPolizaNavigations = new HashSet<AoAnticiposDestajista>();
            AoDestajosEsts = new HashSet<AoDestajosEst>();
            CtbPolizasDets = new HashSet<CtbPolizasDet>();
            CtbPolizasDiots = new HashSet<CtbPolizasDiot>();
            CvAjusteClienteIdPolizaInversaNavigations = new HashSet<CvAjusteCliente>();
            CvAjusteClienteIdPolizaNavigations = new HashSet<CvAjusteCliente>();
            CvApartadoIdPolizaInversaNavigations = new HashSet<CvApartado>();
            CvApartadoIdPolizaNavigations = new HashSet<CvApartado>();
            CvAplicacionApartadoIdPolizaInversaNavigations = new HashSet<CvAplicacionApartado>();
            CvAplicacionApartadoIdPolizaNavigations = new HashSet<CvAplicacionApartado>();
            CvAplicacionDepositoIdPolizaInversaNavigations = new HashSet<CvAplicacionDeposito>();
            CvAplicacionDepositoIdPolizaNavigations = new HashSet<CvAplicacionDeposito>();
            CvCancelaciones = new HashSet<CvCancelacione>();
            CvClienteEscrituracionIdPolizaInversaNavigations = new HashSet<CvClienteEscrituracion>();
            CvClienteEscrituracionIdPolizaNavigations = new HashSet<CvClienteEscrituracion>();
            CvDepositosClienteIdPolizaInversaNavigations = new HashSet<CvDepositosCliente>();
            CvDepositosClienteIdPolizaNavigations = new HashSet<CvDepositosCliente>();
            CvDepositosSofolIdPolizaInversaNavigations = new HashSet<CvDepositosSofol>();
            CvDepositosSofolIdPolizaNavigations = new HashSet<CvDepositosSofol>();
            CvNotasEscrituraIdPolizaInversaNavigations = new HashSet<CvNotasEscritura>();
            CvNotasEscrituraIdPolizaNavigations = new HashSet<CvNotasEscritura>();
            CvPagoLiberacionViviendaIdPolizaInversaNavigations = new HashSet<CvPagoLiberacionVivienda>();
            CvPagoLiberacionViviendaIdPolizaNavigations = new HashSet<CvPagoLiberacionVivienda>();
        }

        public int IdPoliza { get; set; }
        public int MesPoliza { get; set; }
        public int IdTipoPoliza { get; set; }
        public int NumPoliza { get; set; }
        public int? IdCuentaBancaria { get; set; }
        public int IdProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool Contabilizada { get; set; }
        public int IdUsuario { get; set; }
        public bool Cancelada { get; set; }
        public bool? EsAutomatica { get; set; }
        public bool PolizaDescuadrada { get; set; }
        public bool TieneInversa { get; set; }
        public bool EsInversa { get; set; }
        public bool EsGuardarComo { get; set; }
        public bool EsPolizaAjuste { get; set; }
        public int? MesFiscal { get; set; }
        public bool ConsiderarParaPolizaMensual { get; set; }
        public int? IdPolizaOrigen { get; set; }
        public bool GeneradaToSap { get; set; }
        public bool GeneradaCanceladaToSap { get; set; }
        public short MovimientoConciliado { get; set; }
        public int? FolioConciliacion { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaConciliacion { get; set; }
        public int? IdUsuarioConciliacion { get; set; }
        public bool StatusConciliacion { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
        public bool ImportadoDalton { get; set; }
        public DateTime? FechaImportadoDalton { get; set; }
        public int? IntGenencabezadoPolizaKey { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdPolizaNavigations { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccions { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdPolizaNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdPolizaNavigations { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresoIdPolizaNavigations { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresoIdPolizaNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasoIdPolizaNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdPolizaNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcIdPolizaNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedoreIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedoreIdPolizaNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcIdPolizaNavigations { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieroIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieroIdPolizaNavigations { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobarIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobarIdPolizaNavigations { get; set; }
        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizas { get; set; }
        public virtual ICollection<AcNominaPoliza> AcNominaPolizaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcNominaPoliza> AcNominaPolizaIdPolizaNavigations { get; set; }
        public virtual ICollection<AcProrrateoCosto> AcProrrateoCostoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AcProrrateoCosto> AcProrrateoCostoIdPolizaNavigations { get; set; }
        public virtual ICollection<AcProveedoresCfd> AcProveedoresCfds { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajistaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajistaIdPolizaNavigations { get; set; }
        public virtual ICollection<AoDestajosEst> AoDestajosEsts { get; set; }
        public virtual ICollection<CtbPolizasDet> CtbPolizasDets { get; set; }
        public virtual ICollection<CtbPolizasDiot> CtbPolizasDiots { get; set; }
        public virtual ICollection<CvAjusteCliente> CvAjusteClienteIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvAjusteCliente> CvAjusteClienteIdPolizaNavigations { get; set; }
        public virtual ICollection<CvApartado> CvApartadoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvApartado> CvApartadoIdPolizaNavigations { get; set; }
        public virtual ICollection<CvAplicacionApartado> CvAplicacionApartadoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvAplicacionApartado> CvAplicacionApartadoIdPolizaNavigations { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositoIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvAplicacionDeposito> CvAplicacionDepositoIdPolizaNavigations { get; set; }
        public virtual ICollection<CvCancelacione> CvCancelaciones { get; set; }
        public virtual ICollection<CvClienteEscrituracion> CvClienteEscrituracionIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvClienteEscrituracion> CvClienteEscrituracionIdPolizaNavigations { get; set; }
        public virtual ICollection<CvDepositosCliente> CvDepositosClienteIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvDepositosCliente> CvDepositosClienteIdPolizaNavigations { get; set; }
        public virtual ICollection<CvDepositosSofol> CvDepositosSofolIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvDepositosSofol> CvDepositosSofolIdPolizaNavigations { get; set; }
        public virtual ICollection<CvNotasEscritura> CvNotasEscrituraIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvNotasEscritura> CvNotasEscrituraIdPolizaNavigations { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionViviendaIdPolizaInversaNavigations { get; set; }
        public virtual ICollection<CvPagoLiberacionVivienda> CvPagoLiberacionViviendaIdPolizaNavigations { get; set; }
    }
}
