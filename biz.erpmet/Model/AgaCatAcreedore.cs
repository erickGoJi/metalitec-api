using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AgaCatAcreedore
    {
        public AgaCatAcreedore()
        {
            AcProveedores = new HashSet<AcProveedore>();
        }

        public int IdAgaCatAcreedor { get; set; }
        public string AgaCodigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AcProveedore> AcProveedores { get; set; }
    }
}
