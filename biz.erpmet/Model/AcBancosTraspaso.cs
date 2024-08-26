using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcBancosTraspaso
    {
        public int IdBancoTraspaso { get; set; }
        public int Folio { get; set; }
        public int IdProyectoOrigen { get; set; }
        public int IdProyectoDestino { get; set; }
        public int IdCuentaBancariaOrigen { get; set; }
        public int IdCuentaBancariaDestino { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }
        public bool Cancelado { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdPoliza { get; set; }
        public int IdTipoPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public bool Marca { get; set; }
        public decimal ProductoFinanciero { get; set; }
        public bool CapturarPorcentaje { get; set; }
        public decimal PorcentajeIsr { get; set; }
        public decimal MontoIsr { get; set; }
        public short TipoMovimiento { get; set; }
        public string CuentaBancariaMovimiento { get; set; }
        public int? IdBancoSatmovimiento { get; set; }
        public string RfcMovimiento { get; set; }
        public string BancoSatmovimiento { get; set; }
        public string MonedaSatmovimiento { get; set; }
        public string BanEmisExt { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaDestinoNavigation { get; set; }
        public virtual AcCuentasBancaria IdCuentaBancariaOrigenNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoDestinoNavigation { get; set; }
        public virtual Proyecto IdProyectoOrigenNavigation { get; set; }
        public virtual CtbTiposPoliza IdTipoPolizaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
    }
}
