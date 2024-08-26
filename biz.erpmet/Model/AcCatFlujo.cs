using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatFlujo
    {
        public AcCatFlujo()
        {
            AcBancosEgresos = new HashSet<AcBancosEgreso>();
            AcBancosIngresos = new HashSet<AcBancosIngreso>();
            AcCatTipoCheques = new HashSet<AcCatTipoCheque>();
            AcCatTipoDepositos = new HashSet<AcCatTipoDeposito>();
            AcGastosXcomprobars = new HashSet<AcGastosXcomprobar>();
            CtbPolizasDets = new HashSet<CtbPolizasDet>();
            CtbSaldoXflujos = new HashSet<CtbSaldoXflujo>();
            CvTiposPlans = new HashSet<CvTiposPlan>();
            ProyectoCvIdFlujoAjustesNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoCancelacionesNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoDepositosNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoExcedentesNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoGastosAdicionalesNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoInteresesNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoMoratoriosNavigations = new HashSet<Proyecto>();
            ProyectoCvIdFlujoPenalizacionesNavigations = new HashSet<Proyecto>();
        }

        public int IdFlujo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Ingreso { get; set; }
        public bool ConsiderarEnflujo { get; set; }
        public bool GenerarIetu { get; set; }
        public int? IdConceptoIetu { get; set; }
        public bool GenerarDiot { get; set; }

        public virtual AcCatConceptosIetu IdConceptoIetuNavigation { get; set; }
        public virtual ICollection<AcBancosEgreso> AcBancosEgresos { get; set; }
        public virtual ICollection<AcBancosIngreso> AcBancosIngresos { get; set; }
        public virtual ICollection<AcCatTipoCheque> AcCatTipoCheques { get; set; }
        public virtual ICollection<AcCatTipoDeposito> AcCatTipoDepositos { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobars { get; set; }
        public virtual ICollection<CtbPolizasDet> CtbPolizasDets { get; set; }
        public virtual ICollection<CtbSaldoXflujo> CtbSaldoXflujos { get; set; }
        public virtual ICollection<CvTiposPlan> CvTiposPlans { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoAjustesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoCancelacionesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoDepositosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoExcedentesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoGastosAdicionalesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoInteresesNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoMoratoriosNavigations { get; set; }
        public virtual ICollection<Proyecto> ProyectoCvIdFlujoPenalizacionesNavigations { get; set; }
    }
}
