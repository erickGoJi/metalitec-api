using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbTiposPoliza
    {
        public CtbTiposPoliza()
        {
            AcBancosTraspasos = new HashSet<AcBancosTraspaso>();
            AcCatTipoCheques = new HashSet<AcCatTipoCheque>();
            AcCatTipoDepositos = new HashSet<AcCatTipoDeposito>();
            AcCatTipoProveedors = new HashSet<AcCatTipoProveedor>();
            AcCatTiposClientes = new HashSet<AcCatTiposCliente>();
            AcCatTiposNcs = new HashSet<AcCatTiposNc>();
            AcGeneradorPolizas = new HashSet<AcGeneradorPoliza>();
            AcTipDocAlmacens = new HashSet<AcTipDocAlmacen>();
            CtbConsecutivosPolizasXanios = new HashSet<CtbConsecutivosPolizasXanio>();
            CtbConsecutivosPolizasXmes = new HashSet<CtbConsecutivosPolizasXme>();
            CtbPolizas = new HashSet<CtbPoliza>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdTipoPoliza { get; set; }
        public string TipoPoliza { get; set; }
        public string Texto { get; set; }
        public bool ContadorMes { get; set; }
        public bool UsarNumeroDeCheque { get; set; }
        public bool EsAutomatica { get; set; }
        public int? IdTipoPolizaSat { get; set; }

        public virtual CtbCatTiposPolizaSat IdTipoPolizaSatNavigation { get; set; }
        public virtual ICollection<AcBancosTraspaso> AcBancosTraspasos { get; set; }
        public virtual ICollection<AcCatTipoCheque> AcCatTipoCheques { get; set; }
        public virtual ICollection<AcCatTipoDeposito> AcCatTipoDepositos { get; set; }
        public virtual ICollection<AcCatTipoProveedor> AcCatTipoProveedors { get; set; }
        public virtual ICollection<AcCatTiposCliente> AcCatTiposClientes { get; set; }
        public virtual ICollection<AcCatTiposNc> AcCatTiposNcs { get; set; }
        public virtual ICollection<AcGeneradorPoliza> AcGeneradorPolizas { get; set; }
        public virtual ICollection<AcTipDocAlmacen> AcTipDocAlmacens { get; set; }
        public virtual ICollection<CtbConsecutivosPolizasXanio> CtbConsecutivosPolizasXanios { get; set; }
        public virtual ICollection<CtbConsecutivosPolizasXme> CtbConsecutivosPolizasXmes { get; set; }
        public virtual ICollection<CtbPoliza> CtbPolizas { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
