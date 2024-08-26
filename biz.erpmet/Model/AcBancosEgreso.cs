using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosEgreso
    {
        public AcBancosEgreso()
        {
            AcBancosEgresosCuenta = new HashSet<AcBancosEgresosCuenta>();
            AcBancosEgresosDets = new HashSet<AcBancosEgresosDet>();
            AcBancosEgresosInsumos = new HashSet<AcBancosEgresosInsumo>();
            CtbPolizasDetPps = new HashSet<CtbPolizasDetPp>();
        }

        public int IdBancoEgreso { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdTipoMovBanco { get; set; }
        public int IdTipoCheque { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public bool Cancelado { get; set; }
        public decimal Monto { get; set; }
        public bool Impreso { get; set; }
        public string DescripcionCancelacion { get; set; }
        public bool AutorizaImpresion { get; set; }
        public int? IdPoliza { get; set; }
        public decimal Paridad { get; set; }
        public decimal MontoPesos { get; set; }
        public string Beneficiario { get; set; }
        public int IdUsuario { get; set; }
        public string Referencia { get; set; }
        public bool? ImprimeLeyenda { get; set; }
        public int IdFlujo { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public decimal ParidadBursatil { get; set; }
        public decimal ParidadPasivo { get; set; }
        public bool EsMultiCentro { get; set; }
        public bool ImprimeIngles { get; set; }
        public bool Autorizado { get; set; }
        public bool TieneDetallePasivo { get; set; }
        public bool TieneDetalleFacturas { get; set; }
        public decimal DividirEntre { get; set; }
        public byte EsCheque { get; set; }
        public bool EsMultimoneda { get; set; }
        public string Observaciones { get; set; }
        public int Cheque { get; set; }
        public bool EsChequeManual { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public short Marca { get; set; }
        public bool EnviadoaAscii { get; set; }
        public int NumEnviosAtxt { get; set; }
        public bool CvsC { get; set; }
        public string RfcBeneficiario { get; set; }
        public int? IdBancoSatbeneficiario { get; set; }
        public string CuentaBancariaBeneficiario { get; set; }
        public string MonedaSatbeneficiario { get; set; }
        public string BanEmisExt { get; set; }
        public string BancoSatbeneficiario { get; set; }
        public bool AutomaticoCaabsa { get; set; }
        public string TipoDeCuentaCash { get; set; }
        public string ConceptoCiecash { get; set; }
        public string ReferenciaNumericaCash { get; set; }
        public string ReferenciaCiecash { get; set; }
        public string ConvenioCiecash { get; set; }
        public string ClaveTransferencia { get; set; }
        public string PlazaBanxico { get; set; }
        public string Sucursal { get; set; }
        public int? IdPartidaFlujo { get; set; }
        public bool AutomaticoDalton { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public int? IdUsuarioEmision { get; set; }
        public int? IdUsuarioGeneracion { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string FolioFacturaCash { get; set; }
        public string FechaProbablePagoCash { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual AcCatFlujo IdFlujoNavigation { get; set; }
        public virtual AcCatPartidaFlujo IdPartidaFlujoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatTipoCheque IdTipoChequeNavigation { get; set; }
        public virtual AcTipoMovBanco IdTipoMovBancoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcBancosEgresosCuenta> AcBancosEgresosCuenta { get; set; }
        public virtual ICollection<AcBancosEgresosDet> AcBancosEgresosDets { get; set; }
        public virtual ICollection<AcBancosEgresosInsumo> AcBancosEgresosInsumos { get; set; }
        public virtual ICollection<CtbPolizasDetPp> CtbPolizasDetPps { get; set; }
    }
}
