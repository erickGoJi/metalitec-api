using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaPoliza
    {
        public AcNominaPoliza()
        {
            AcNominaPolizaCuenta = new HashSet<AcNominaPolizaCuenta>();
            AcNominaPolizaInsumos = new HashSet<AcNominaPolizaInsumo>();
        }

        public int IdNominaPoliza { get; set; }
        public int IdNominaTipo { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int Ejercicio { get; set; }
        public int NumNomina { get; set; }
        public int? IdNominaModelo { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }

        public virtual AcNominaModelo IdNominaModeloNavigation { get; set; }
        public virtual AcNominaTipo IdNominaTipoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcNominaPolizaCuenta> AcNominaPolizaCuenta { get; set; }
        public virtual ICollection<AcNominaPolizaInsumo> AcNominaPolizaInsumos { get; set; }
    }
}
