using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcExplosionInsumo
    {
        public AcExplosionInsumo()
        {
            AcAditivasExplosionDets = new HashSet<AcAditivasExplosionDet>();
            AcAlmacenEntradasDets = new HashSet<AcAlmacenEntradasDet>();
            AcAlmacenOproduccionDets = new HashSet<AcAlmacenOproduccionDet>();
            AcAlmacenOproduccions = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenSalidasDets = new HashSet<AcAlmacenSalidasDet>();
            AcAlmacenTraspasosDetIdExplosionInsumosDestinoNavigations = new HashSet<AcAlmacenTraspasosDet>();
            AcAlmacenTraspasosDetIdExplosionInsumosOrigenNavigations = new HashSet<AcAlmacenTraspasosDet>();
            AcBancosEgresosInsumos = new HashSet<AcBancosEgresosInsumo>();
            AcFacturasProveedoresDets = new HashSet<AcFacturasProveedoresDet>();
            AcGastosFinancierosDets = new HashSet<AcGastosFinancierosDet>();
            AcGastosXcomprobarDets = new HashSet<AcGastosXcomprobarDet>();
            AcGeneradorPolizaInsumos = new HashSet<AcGeneradorPolizaInsumo>();
            AcNominaPolizaInsumos = new HashSet<AcNominaPolizaInsumo>();
            AcOrdenProduccionDets = new HashSet<AcOrdenProduccionDet>();
            AcRequisicionDets = new HashSet<AcRequisicionDet>();
            AcalmacenSaldosMensuales = new HashSet<AcalmacenSaldosMensuale>();
            AoProgramaSuministros = new HashSet<AoProgramaSuministro>();
            CvDepositosSofolCta = new HashSet<CvDepositosSofolCta>();
        }

        public int IdExplosionInsumos { get; set; }
        public int IdProyecto { get; set; }
        public int IdInsumo { get; set; }
        public decimal CantidadProgramada { get; set; }
        public decimal CantidadOriginal { get; set; }
        public decimal CantidadAdicional { get; set; }
        public decimal CantidadRequerida { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadTraspasoEntrada { get; set; }
        public decimal CantidadTraspasoSalida { get; set; }
        public decimal CantidadFacturadaSinPedido { get; set; }
        public decimal CantidadFacturadaConPedido { get; set; }
        public decimal CantidadSalidasMultiProyecto { get; set; }
        public decimal CantidadEntradasMultiProyecto { get; set; }
        public decimal CantidadEntradasConPedido { get; set; }
        public decimal CantidadEntradasConFactura { get; set; }
        public decimal CostoOriginal { get; set; }
        public decimal CostoTopeCompra { get; set; }
        public bool? ToparPrecio { get; set; }
        public bool? ToparCantidad { get; set; }
        public bool Bloqueado { get; set; }
        public decimal ExistenciaTotal { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal ExistenciaTotalAyer { get; set; }
        public decimal ImporteTotalAyer { get; set; }
        public decimal ExistenciaTotalTmp { get; set; }
        public decimal ImporteTotalTmp { get; set; }
        public decimal CantidadMaxima { get; set; }
        public decimal CantidadMinima { get; set; }
        public decimal CantidadInventarioInicial { get; set; }
        public decimal CostoInventarioInicial { get; set; }
        public int? IdAditivaInventarioInicial { get; set; }
        public bool NoActualizarPrecioEnCalculo { get; set; }
        public short TipoCaptura { get; set; }
        public decimal CantidadApartadaOp { get; set; }
        public decimal CantidadXgeneradorPoliza { get; set; }
        public decimal CantidadEntradasPorRm { get; set; }
        public decimal CostoOriginalImportado { get; set; }
        public decimal CantidadOriginalImportada { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AcAditivasExplosionDet> AcAditivasExplosionDets { get; set; }
        public virtual ICollection<AcAlmacenEntradasDet> AcAlmacenEntradasDets { get; set; }
        public virtual ICollection<AcAlmacenOproduccionDet> AcAlmacenOproduccionDets { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccions { get; set; }
        public virtual ICollection<AcAlmacenSalidasDet> AcAlmacenSalidasDets { get; set; }
        public virtual ICollection<AcAlmacenTraspasosDet> AcAlmacenTraspasosDetIdExplosionInsumosDestinoNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspasosDet> AcAlmacenTraspasosDetIdExplosionInsumosOrigenNavigations { get; set; }
        public virtual ICollection<AcBancosEgresosInsumo> AcBancosEgresosInsumos { get; set; }
        public virtual ICollection<AcFacturasProveedoresDet> AcFacturasProveedoresDets { get; set; }
        public virtual ICollection<AcGastosFinancierosDet> AcGastosFinancierosDets { get; set; }
        public virtual ICollection<AcGastosXcomprobarDet> AcGastosXcomprobarDets { get; set; }
        public virtual ICollection<AcGeneradorPolizaInsumo> AcGeneradorPolizaInsumos { get; set; }
        public virtual ICollection<AcNominaPolizaInsumo> AcNominaPolizaInsumos { get; set; }
        public virtual ICollection<AcOrdenProduccionDet> AcOrdenProduccionDets { get; set; }
        public virtual ICollection<AcRequisicionDet> AcRequisicionDets { get; set; }
        public virtual ICollection<AcalmacenSaldosMensuale> AcalmacenSaldosMensuales { get; set; }
        public virtual ICollection<AoProgramaSuministro> AoProgramaSuministros { get; set; }
        public virtual ICollection<CvDepositosSofolCta> CvDepositosSofolCta { get; set; }
    }
}
