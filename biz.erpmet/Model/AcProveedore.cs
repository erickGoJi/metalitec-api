using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcProveedore
    {
        public AcProveedore()
        {
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcCatInsumos = new HashSet<AcCatInsumo>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcFacturasProveedoresNcs = new HashSet<AcFacturasProveedoresNc>();
            AcGastosFinancieros = new HashSet<AcGastosFinanciero>();
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
            AcPedidos = new HashSet<AcPedido>();
            AcProveedoresCertificados = new HashSet<AcProveedoresCertificado>();
            AcProveedoresCfds = new HashSet<AcProveedoresCfd>();
            AcactivoFijos = new HashSet<AcactivoFijo>();
            AcproveedoresInsumos = new HashSet<AcproveedoresInsumo>();
            AoCatContratista = new HashSet<AoCatContratista>();
            CvVendedores = new HashSet<CvVendedore>();
        }

        public int IdProveedor { get; set; }
        public string Codigo { get; set; }
        public string RazonSocial { get; set; }
        public int? IdGiro { get; set; }
        public int IdTipoProveedor { get; set; }
        public string Rfc { get; set; }
        public int IdCiudad { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public string Delegacion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public decimal LimiteCredito { get; set; }
        public short DiasCredito { get; set; }
        public short DiasEntrega { get; set; }
        public short CalifPuntualidad { get; set; }
        public short CalifCalidad { get; set; }
        public string Contacto { get; set; }
        public string NombreJefe { get; set; }
        public string PuestoJefe { get; set; }
        public string Observaciones { get; set; }
        public string RegistroPatronal { get; set; }
        public string RegistroCamara { get; set; }
        public string Infonavit { get; set; }
        public string TipoFiscal { get; set; }
        public int IdTipoMoneda { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Celular { get; set; }
        public string PaginaWeb { get; set; }
        public string CondicionesPago { get; set; }
        public bool? PersonaMoral { get; set; }
        public string Curp { get; set; }
        public string PersonasAtiendenPedidos { get; set; }
        public bool Suspendido { get; set; }
        public int IdCuentaProveedor { get; set; }
        public int? IdCuentaAnticipo { get; set; }
        public int? IdCuentaFonGar { get; set; }
        public int? IdCuentaDeudor { get; set; }
        public bool ConPagoElectronico { get; set; }
        public string Clabe { get; set; }
        public string Banco { get; set; }
        public int IdTipoTerceros { get; set; }
        public int IdTipoOperacion { get; set; }
        public bool GastosFinancieros { get; set; }
        public string ClaveCliente { get; set; }
        public string CodigoSap { get; set; }
        public int? IdAgaCatAcreedor { get; set; }
        public bool PermitirExentoIva { get; set; }
        public string CuentaBancaria { get; set; }
        public int? IdBancoSat { get; set; }
        public string MonedaSatdefault { get; set; }
        public string BancoSat { get; set; }
        public string TipoDeCuentaCash { get; set; }
        public string ConceptoCiecash { get; set; }
        public string ReferenciaCiecash { get; set; }
        public string ConvenioCiecash { get; set; }
        public string NumRegIdFiscal { get; set; }
        public string PlazaBanxico { get; set; }
        public int? IdPais { get; set; }
        public int? IdClaveTransferencia { get; set; }
        public string Nacionalidad { get; set; }
        public string Sucursal { get; set; }
        public int? IdCuentaPagoEnEspecie { get; set; }
        public int? IdCuentaOtrasRetenciones { get; set; }

        public virtual AgaCatAcreedore IdAgaCatAcreedorNavigation { get; set; }
        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AcCatClavesTransferencia IdClaveTransferenciaNavigation { get; set; }
        public virtual CtbCuenta IdCuentaAnticipoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaDeudorNavigation { get; set; }
        public virtual CtbCuenta IdCuentaFonGarNavigation { get; set; }
        public virtual CtbCuenta IdCuentaOtrasRetencionesNavigation { get; set; }
        public virtual CtbCuenta IdCuentaPagoEnEspecieNavigation { get; set; }
        public virtual CtbCuenta IdCuentaProveedorNavigation { get; set; }
        public virtual AcCatGiro IdGiroNavigation { get; set; }
        public virtual AcCatPaise IdPaisNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual CtbDiottipoOperacion IdTipoOperacionNavigation { get; set; }
        public virtual AcCatTipoProveedor IdTipoProveedorNavigation { get; set; }
        public virtual CtbDiottipoTercero IdTipoTercerosNavigation { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcFacturasProveedoresNc> AcFacturasProveedoresNcs { get; set; }
        public virtual ICollection<AcGastosFinanciero> AcGastosFinancieros { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual ICollection<AcPedido> AcPedidos { get; set; }
        public virtual ICollection<AcProveedoresCertificado> AcProveedoresCertificados { get; set; }
        public virtual ICollection<AcProveedoresCfd> AcProveedoresCfds { get; set; }
        public virtual ICollection<AcactivoFijo> AcactivoFijos { get; set; }
        public virtual ICollection<AcproveedoresInsumo> AcproveedoresInsumos { get; set; }
        public virtual ICollection<AoCatContratista> AoCatContratista { get; set; }
        public virtual ICollection<CvVendedore> CvVendedores { get; set; }
    }
}
