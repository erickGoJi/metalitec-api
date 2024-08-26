using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcTiposInsumo
    {
        public AcTiposInsumo()
        {
            AcCatInsumos = new HashSet<AcCatInsumo>();
        }

        public int IdTipoInsumo { get; set; }
        public short Tipo { get; set; }
        public string Descripcion { get; set; }
        public bool? EsInventariable { get; set; }
        public bool EsNoInventariable { get; set; }
        public bool EsManoDeObra { get; set; }
        public bool EsDestajo { get; set; }
        public bool EsSubcontrato { get; set; }
        public bool EsAdministrativo { get; set; }
        public bool NoMostrarEnReq { get; set; }
        public bool NoMostrarEnFacSinPed { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PorcentajeIndirecto { get; set; }
        public bool ConsiderarEnIvadeSubcon { get; set; }

        public virtual ICollection<AcCatInsumo> AcCatInsumos { get; set; }
    }
}
