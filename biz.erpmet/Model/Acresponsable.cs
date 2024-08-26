using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Acresponsable
    {
        public Acresponsable()
        {
            AcAlmacenEntradaIdAutorizoNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenEntradaIdResponsableNavigations = new HashSet<AcAlmacenEntrada>();
            AcAlmacenOproduccionIdAutorizoNavigations = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenOproduccionIdElaboroNavigations = new HashSet<AcAlmacenOproduccion>();
            AcAlmacenSalidaIdAutorizoNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaIdResponsableNavigations = new HashSet<AcAlmacenSalida>();
            AcAlmacenTraspasoIdAutorizoNavigations = new HashSet<AcAlmacenTraspaso>();
            AcAlmacenTraspasoIdResponsableNavigations = new HashSet<AcAlmacenTraspaso>();
            AcClientesFacturaIdCatResponsable1Navigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdCatResponsable2Navigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdCatResponsable3Navigations = new HashSet<AcClientesFactura>();
            AcClientesFacturaIdCatResponsable4Navigations = new HashSet<AcClientesFactura>();
            AcContratoIdCatResponsable1Navigations = new HashSet<AcContrato>();
            AcContratoIdCatResponsable2Navigations = new HashSet<AcContrato>();
            AcContratoIdCatResponsable3Navigations = new HashSet<AcContrato>();
            AcContratoIdCatResponsable4Navigations = new HashSet<AcContrato>();
            AcOrdenProduccions = new HashSet<AcOrdenProduccion>();
            AcPedidoIdAutorizoNavigations = new HashSet<AcPedido>();
            AcPedidoIdCompradorNavigations = new HashSet<AcPedido>();
            AcPedidoIdContabilidadNavigations = new HashSet<AcPedido>();
            AcPedidoIdElaboroNavigations = new HashSet<AcPedido>();
            AcPedidoIdRevisoNavigations = new HashSet<AcPedido>();
            AcRequisicioneIdAutorizacionComprasNavigations = new HashSet<AcRequisicione>();
            AcRequisicioneIdAutorizacionTecnicaNavigations = new HashSet<AcRequisicione>();
            AcRequisicioneIdResponsableSeguimientoNavigations = new HashSet<AcRequisicione>();
            AcRequisicioneIdSolicitanteNavigations = new HashSet<AcRequisicione>();
            AcSolicitudMaterials = new HashSet<AcSolicitudMaterial>();
            AcactivoFijoDets = new HashSet<AcactivoFijoDet>();
            AoSubContratoIdResidenteNavigations = new HashSet<AoSubContrato>();
            AoSubContratoIdSupIntendente1Navigations = new HashSet<AoSubContrato>();
            AoSubContratoIdSupIntendente2Navigations = new HashSet<AoSubContrato>();
            AoSubContratoIdVoBoNavigations = new HashSet<AoSubContrato>();
            ProyectoIdAutorizoNavigations = new HashSet<Proyecto>();
            ProyectoIdContabilidadNavigations = new HashSet<Proyecto>();
            ProyectoIdResponsableNavigations = new HashSet<Proyecto>();
            ProyectoIdResponsableProyectoNavigations = new HashSet<Proyecto>();
            ProyectoIdRevisoNavigations = new HashSet<Proyecto>();
        }

        public int IdResponsable { get; set; }
        public string Responsable { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Lada { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }

        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdAutorizoNavigations { get; set; }
        public virtual ICollection<AcAlmacenEntrada> AcAlmacenEntradaIdResponsableNavigations { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccionIdAutorizoNavigations { get; set; }
        public virtual ICollection<AcAlmacenOproduccion> AcAlmacenOproduccionIdElaboroNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdAutorizoNavigations { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalidaIdResponsableNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdAutorizoNavigations { get; set; }
        public virtual ICollection<AcAlmacenTraspaso> AcAlmacenTraspasoIdResponsableNavigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdCatResponsable1Navigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdCatResponsable2Navigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdCatResponsable3Navigations { get; set; }
        public virtual ICollection<AcClientesFactura> AcClientesFacturaIdCatResponsable4Navigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdCatResponsable1Navigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdCatResponsable2Navigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdCatResponsable3Navigations { get; set; }
        public virtual ICollection<AcContrato> AcContratoIdCatResponsable4Navigations { get; set; }
        public virtual ICollection<AcOrdenProduccion> AcOrdenProduccions { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdAutorizoNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdCompradorNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdContabilidadNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdElaboroNavigations { get; set; }
        public virtual ICollection<AcPedido> AcPedidoIdRevisoNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdAutorizacionComprasNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdAutorizacionTecnicaNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdResponsableSeguimientoNavigations { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisicioneIdSolicitanteNavigations { get; set; }
        public virtual ICollection<AcSolicitudMaterial> AcSolicitudMaterials { get; set; }
        public virtual ICollection<AcactivoFijoDet> AcactivoFijoDets { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratoIdResidenteNavigations { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratoIdSupIntendente1Navigations { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratoIdSupIntendente2Navigations { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratoIdVoBoNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdAutorizoNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdContabilidadNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdResponsableNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdResponsableProyectoNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoIdRevisoNavigations { get; set; }
    }
}
