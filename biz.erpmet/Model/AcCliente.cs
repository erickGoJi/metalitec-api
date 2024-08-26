using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCliente
    {
        public AcCliente()
        {
            AcCfditraslados = new HashSet<AcCfditraslado>();
            AcClientesAddenda = new HashSet<AcClientesAddenda>();
            AcClientesFacturasNcs = new HashSet<AcClientesFacturasNc>();
            AcClientesSolicitantes = new HashSet<AcClientesSolicitante>();
            AcComplementoPagos = new HashSet<AcComplementoPago>();
            AcContratos = new HashSet<AcContrato>();
        }

        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public int IdTipoCliente { get; set; }
        public int IdCuenta { get; set; }
        public int? IdCuentaAnticipo { get; set; }
        public int? IdCuentaFongar { get; set; }
        public int IdTipoMoneda { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public decimal LimiteCredito { get; set; }
        public short DiasCredito { get; set; }
        public short Calificacion { get; set; }
        public bool PagoElectronico { get; set; }
        public string Area { get; set; }
        public string Direccion { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Referencia { get; set; }
        public int? IdEstado { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string Delegacion { get; set; }
        public int? IdCiudad { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public string Contacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string PinContacto { get; set; }
        public string MailContacto { get; set; }
        public bool PersonaFisica { get; set; }
        public string DireccionEnvio { get; set; }
        public string ColoniaEnvio { get; set; }
        public string CodigoPostalEnvio { get; set; }
        public string DelegacionEnvio { get; set; }
        public int? IdCiudadEnvio { get; set; }
        public string TelefonoEnvio { get; set; }
        public string FaxEnvio { get; set; }
        public string EntreCallesEnvio { get; set; }
        public string DireccionCobranza { get; set; }
        public string ColoniaCobranza { get; set; }
        public string CodigoPostalCobranza { get; set; }
        public string DelegacionCobranza { get; set; }
        public int? IdCiudadCobranza { get; set; }
        public string TelefonoCobranza { get; set; }
        public string FaxCobranza { get; set; }
        public string EntreCallesCobranza { get; set; }
        public string CuentaBancaria { get; set; }
        public string NumCtaPago { get; set; }
        public int? IdBancoSat { get; set; }
        public string MonedaSatdefault { get; set; }
        public string BancoSat { get; set; }
        public string StrMetodosPago { get; set; }
        public string NumRegIdTrib { get; set; }
        public int? IdPaisSat { get; set; }
        public int? IdCodigoPostalSat { get; set; }

        public virtual AcCatCiudade IdCiudadCobranzaNavigation { get; set; }
        public virtual AcCatCiudade IdCiudadEnvioNavigation { get; set; }
        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AcCatCodigosPostalesSat IdCodigoPostalSatNavigation { get; set; }
        public virtual CtbCuenta IdCuentaAnticipoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaFongarNavigation { get; set; }
        public virtual CtbCuenta IdCuentaNavigation { get; set; }
        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual AcCatPaise IdPaisSatNavigation { get; set; }
        public virtual AcCatTiposCliente IdTipoClienteNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
        public virtual ICollection<AcClientesAddenda> AcClientesAddenda { get; set; }
        public virtual ICollection<AcClientesFacturasNc> AcClientesFacturasNcs { get; set; }
        public virtual ICollection<AcClientesSolicitante> AcClientesSolicitantes { get; set; }
        public virtual ICollection<AcComplementoPago> AcComplementoPagos { get; set; }
        public virtual ICollection<AcContrato> AcContratos { get; set; }
    }
}
