using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPrototipo
    {
        public CvPrototipo()
        {
            CvClienteIdPrototipoDeseadoNavigations = new HashSet<CvCliente>();
            CvClienteIdPrototipoPreContratadoNavigations = new HashSet<CvCliente>();
            CvPetapas = new HashSet<CvPetapa>();
            CvPrototiposAccesorios = new HashSet<CvPrototiposAccesorio>();
            CvPrototiposAdjuntos = new HashSet<CvPrototiposAdjunto>();
            CvProyectosPrototipos = new HashSet<CvProyectosPrototipo>();
        }

        public int IdPrototipo { get; set; }
        public string Prototipo { get; set; }
        public string Comercial { get; set; }
        public string Texto { get; set; }
        public string Descri { get; set; }
        public int? TipoRelleno { get; set; }
        public string Ansi { get; set; }
        public decimal? SuperficieConstruida { get; set; }
        public string Partida { get; set; }
        public decimal EscalaRelleno { get; set; }

        public virtual ICollection<CvCliente> CvClienteIdPrototipoDeseadoNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteIdPrototipoPreContratadoNavigations { get; set; }
        public virtual ICollection<CvPetapa> CvPetapas { get; set; }
        public virtual ICollection<CvPrototiposAccesorio> CvPrototiposAccesorios { get; set; }
        public virtual ICollection<CvPrototiposAdjunto> CvPrototiposAdjuntos { get; set; }
        public virtual ICollection<CvProyectosPrototipo> CvProyectosPrototipos { get; set; }
    }
}
