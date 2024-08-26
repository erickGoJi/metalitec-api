using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcContrato
    {
        public AcContrato()
        {
            AcClientesFacturas = new HashSet<AcClientesFactura>();
            AcClientesFacturasNc2017s = new HashSet<AcClientesFacturasNc2017>();
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
            AcContratosDets = new HashSet<AcContratosDet>();
            AcContratosOcs = new HashSet<AcContratosOc>();
        }

        public int IdContrato { get; set; }
        public string Contrato { get; set; }
        public int IdProyecto { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaDelContrato { get; set; }
        public DateTime? FechaUltimoCambio { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool AplicarAnticipo { get; set; }
        public string Observaciones { get; set; }
        public bool Cancelado { get; set; }
        public decimal PorcentajeAnticipo { get; set; }
        public decimal MontoIvaAnticipo { get; set; }
        public decimal MontoAnticipo { get; set; }
        public bool? CapturarPorcentajeAnticipo { get; set; }
        public decimal PorcentajeFonGar { get; set; }
        public decimal MontoFonGar { get; set; }
        public bool? CapturarPorcentajeFonGar { get; set; }
        public decimal MontoContrato { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal MontoIva { get; set; }
        public bool? CapturarPorcentajeIva { get; set; }
        public decimal ImporteAntesIva { get; set; }
        public bool FacturadoTotal { get; set; }
        public int? IdCatResponsable1 { get; set; }
        public int? IdCatResponsable2 { get; set; }
        public int? IdCatResponsable3 { get; set; }
        public int? IdCatResponsable4 { get; set; }
        public int? IdTipoFiscal { get; set; }
        public int IdUsuario { get; set; }
        public bool Autorizado { get; set; }
        public int? IdUsuarioAutoriza { get; set; }
        public int NumeroOrdenCambio { get; set; }
        public string DescripcionContrato { get; set; }
        public bool Bloqueado { get; set; }
        public string ServidorPu2010 { get; set; }
        public string BaseDatosPu2010 { get; set; }
        public int? IdPresupuestoPu2010 { get; set; }
        public int? IdContratoPu2010 { get; set; }
        public int TipoControlAnticipo { get; set; }
        public bool ConsiderarFgcomoDescuento { get; set; }

        public virtual Acresponsable IdCatResponsable1Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable2Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable3Navigation { get; set; }
        public virtual Acresponsable IdCatResponsable4Navigation { get; set; }
        public virtual AcCliente IdClienteNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcTipoFiscal IdTipoFiscalNavigation { get; set; }
        public virtual SegUsuario IdUsuarioAutorizaNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual AcContratosDatosAdicionale AcContratosDatosAdicionale { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturas { get; set; }
        public virtual ICollection<AcClientesFacturasNc2017> AcClientesFacturasNc2017s { get; set; }
        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
        public virtual ICollection<AcContratosDet> AcContratosDets { get; set; }
        public virtual ICollection<AcContratosOc> AcContratosOcs { get; set; }
    }
}
