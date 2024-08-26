using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoSubContrato
    {
        public AoSubContrato()
        {
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AoSubContratosEsts = new HashSet<AoSubContratosEst>();
            AoSubcontratosDets = new HashSet<AoSubcontratosDet>();
            AoSubcontratosOcs = new HashSet<AoSubcontratosOc>();
        }

        public int IdSubContrato { get; set; }
        public int IdProyecto { get; set; }
        public int FolioSubcontrato { get; set; }
        public bool EsSubMo { get; set; }
        public string DocumentoLegal { get; set; }
        public int IdContratista { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool? CapturarPorcentajeAnticipo { get; set; }
        public decimal PorcentajeAnticipo { get; set; }
        public decimal Anticipo { get; set; }
        public bool? CapturarPorcentajeFonGar { get; set; }
        public decimal PorcentajeFonGar { get; set; }
        public decimal FonGar { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal Iva { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFin { get; set; }
        public string FianzaAnticipo { get; set; }
        public string FianzaCumplimiento { get; set; }
        public string FianzaGarantia { get; set; }
        public decimal ImporteSubcontrato { get; set; }
        public bool Finiquitado { get; set; }
        public int IdResidente { get; set; }
        public int? IdSupIntendente1 { get; set; }
        public int? IdSupIntendente2 { get; set; }
        public int? IdVoBo { get; set; }
        public string ClausulaSub { get; set; }
        public int NumeroProrroga { get; set; }
        public DateTime? FechaProrroga { get; set; }
        public string Objeto { get; set; }
        public bool Autorizado { get; set; }
        public bool Cancelado { get; set; }
        public int IdUsuario { get; set; }
        public string Area { get; set; }
        public string Frente { get; set; }
        public string Prototipo { get; set; }
        public int? IdPlantillaContrato { get; set; }
        public decimal MontoPaquete { get; set; }
        public string CodigoAuxiliar { get; set; }
        public bool EnviadoaMizar { get; set; }
        public bool EsManodeObra { get; set; }
        public int FolioEstimaciones { get; set; }
        public int FolioOc { get; set; }
        public string ServidorPu2010 { get; set; }
        public string BaseDatosPu2010 { get; set; }
        public int? IdPresupuestoPu2010 { get; set; }
        public int? IdContratoPu2010 { get; set; }
        public int? IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool ImportadoDaltonDin { get; set; }
        public DateTime? FechaImportacionDaltonDin { get; set; }
        public int? IntInmdocumentoContratoDeObraKey { get; set; }
        public bool CapturarPorcentajeOr { get; set; }
        public bool CapturarPorcentajePe { get; set; }
        public decimal PorcentajePagoEnEspecie { get; set; }
        public decimal OtrasRetenciones { get; set; }
        public decimal PorcentajeOtrasRetenciones { get; set; }
        public decimal PagoEnEspecie { get; set; }

        public virtual AoCatContratista IdContratistaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual Acresponsable IdResidenteNavigation { get; set; }
        public virtual Acresponsable IdSupIntendente1Navigation { get; set; }
        public virtual Acresponsable IdSupIntendente2Navigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual Acresponsable IdVoBoNavigation { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AoSubContratosEst> AoSubContratosEsts { get; set; }
        public virtual ICollection<AoSubcontratosDet> AoSubcontratosDets { get; set; }
        public virtual ICollection<AoSubcontratosOc> AoSubcontratosOcs { get; set; }
    }
}
