using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvFtipoDiscapacidad
    {
        public CvFtipoDiscapacidad()
        {
            CvClienteFtipoDiscapacidadDependienteNavigations = new HashSet<CvCliente>();
            CvClienteFtipoDiscapacidadNavigations = new HashSet<CvCliente>();
        }

        public byte IdFtipoDiscapacidad { get; set; }
        public string FtipoDiscapacidad { get; set; }

        public virtual ICollection<CvCliente> CvClienteFtipoDiscapacidadDependienteNavigations { get; set; }
        public virtual ICollection<CvCliente> CvClienteFtipoDiscapacidadNavigations { get; set; }
    }
}
