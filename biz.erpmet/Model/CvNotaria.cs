using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvNotaria
    {
        public CvNotaria()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdNotaria { get; set; }
        public string Notaria { get; set; }
        public string NombreNotaria { get; set; }
        public string Notario { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string DireccionCompleta { get; set; }

        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
