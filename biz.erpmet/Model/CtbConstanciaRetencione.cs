using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbConstanciaRetencione
    {
        public CtbConstanciaRetencione()
        {
            CtbConstanciaRetencionDets = new HashSet<CtbConstanciaRetencionDet>();
        }

        public int IdConstanciaRetencion { get; set; }
        public int Folio { get; set; }
        public int Ejercicio { get; set; }
        public DateTime Inicial { get; set; }
        public DateTime Final { get; set; }
        public string TipoRetencion { get; set; }
        public string DescripcionRetencion { get; set; }
        public bool Xmlgenerado { get; set; }
        public bool? EsNacional { get; set; }
        public string Rfcreceptor { get; set; }
        public string RazonSocial { get; set; }
        public string Curp { get; set; }
        public string IdFiscal { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoGravado { get; set; }
        public decimal MontoExento { get; set; }
        public decimal MontoRetenido { get; set; }
        public string Xml { get; set; }
        public string MensajeValidacion { get; set; }
        public DateTime? FechaTimbrado { get; set; }

        public virtual CtbCatTipoRetencione TipoRetencionNavigation { get; set; }
        public virtual ICollection<CtbConstanciaRetencionDet> CtbConstanciaRetencionDets { get; set; }
    }
}
