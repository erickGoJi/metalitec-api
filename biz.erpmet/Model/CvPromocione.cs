using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPromocione
    {
        public CvPromocione()
        {
            CvProyectosPromociones = new HashSet<CvProyectosPromocione>();
        }

        public int IdPromocion { get; set; }
        public string Promocion { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvProyectosPromocione> CvProyectosPromociones { get; set; }
    }
}
