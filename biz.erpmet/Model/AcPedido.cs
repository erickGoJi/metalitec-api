using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcPedido
    {
        public AcPedido()
        {
            AcAjustesPedidos = new HashSet<AcAjustesPedido>();
            AcAlmacenEntrada = new HashSet<AcAlmacenEntrada>();
            AcFacturasProveedores = new HashSet<AcFacturasProveedore>();
            AcPedidosBitacoras = new HashSet<AcPedidosBitacora>();
            AcPedidosDescuentos = new HashSet<AcPedidosDescuento>();
            AcPedidosDets = new HashSet<AcPedidosDet>();
        }

        public int IdPedido { get; set; }
        public int IdProyecto { get; set; }
        public int IdRequisicion { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdProveedor { get; set; }
        public int IdComprador { get; set; }
        public int IdElaboro { get; set; }
        public int? IdReviso { get; set; }
        public int? IdAutorizo { get; set; }
        public int? IdContabilidad { get; set; }
        public int IdUsuario { get; set; }
        public string LugarEntregaMateriales { get; set; }
        public decimal MontoAnticipo { get; set; }
        public decimal PorcentajeAnticipo { get; set; }
        public bool? CapturarPorcentajeAnticipo { get; set; }
        public decimal SumaInsumos { get; set; }
        public decimal SubTotalDescuentosCargos { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal MontoIva { get; set; }
        public decimal MontoDescuentos { get; set; }
        public decimal MontoCargos { get; set; }
        public decimal Total { get; set; }
        public decimal MontoOtrosImpuestos { get; set; }
        public bool AplicarAnticipo { get; set; }
        public string Observaciones { get; set; }
        public string EmbarquesePor { get; set; }
        public string Lab { get; set; }
        public string CondicionesPagoTexto { get; set; }
        public bool Cancelado { get; set; }
        public string TextoFechaEntrega { get; set; }
        public bool FacturadoTotalMente { get; set; }
        public bool EntradaTotal { get; set; }
        public decimal SumaEntradas { get; set; }
        public decimal MontoAjuste { get; set; }
        public string ComentarioAjuste { get; set; }
        public DateTime? FechaAjuste { get; set; }
        public int? IdUsuarioAjuste { get; set; }
        public int? IdTipoFiscal { get; set; }
        public bool Autorizado { get; set; }
        public bool VoBo { get; set; }
        public string ObservacionesAlmacen { get; set; }
        public bool? EsInventariable { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public bool EsComisionCv { get; set; }
        public DateTime? FechaUltimaModificacion { get; set; }
        public bool Finiquitado { get; set; }
        public decimal TotalCig { get; set; }
        public decimal SumaInsumosCig { get; set; }
        public decimal SubTotalDescuentosCargosCig { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public int? IdUsuarioAutorizacion { get; set; }

        public virtual Acresponsable IdAutorizoNavigation { get; set; }
        public virtual Acresponsable IdCompradorNavigation { get; set; }
        public virtual Acresponsable IdContabilidadNavigation { get; set; }
        public virtual Acresponsable IdElaboroNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcRequisicione IdRequisicionNavigation { get; set; }
        public virtual Acresponsable IdRevisoNavigation { get; set; }
        public virtual AcTipoFiscal IdTipoFiscalNavigation { get; set; }
        public virtual SegUsuario IdUsuarioAutorizacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcAjustesPedido> AcAjustesPedidos { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntrada { get; set; }
        public virtual ICollection<AcFacturasProveedore> AcFacturasProveedores { get; set; }
        public virtual ICollection<AcPedidosBitacora> AcPedidosBitacoras { get; set; }
        public virtual ICollection<AcPedidosDescuento> AcPedidosDescuentos { get; set; }
        public virtual ICollection<AcPedidosDet> AcPedidosDets { get; set; }
    }
}
