using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcNominaModelosInsumo
    {
        public int IdNominaModeloInsumo { get; set; }
        public int IdNominaModelo { get; set; }
        public int? IdInsumo { get; set; }
        public int IdNominaConcepto { get; set; }
        public int? IdTipoCuadrillaNomina { get; set; }
        public bool EsSueldo { get; set; }

        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual AcNominaCatalogoConcepto IdNominaConceptoNavigation { get; set; }
        public virtual AcNominaModelo IdNominaModeloNavigation { get; set; }
        public virtual AcTiposCuadrillaNomina IdTipoCuadrillaNominaNavigation { get; set; }
    }
}
