using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvTiposFalla
    {
        public CvTiposFalla()
        {
            CvCancelaciones = new HashSet<CvCancelacione>();
        }

        public int IdTipoFalla { get; set; }
        public string TipoFalla { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvCancelacione> CvCancelaciones { get; set; }
    }
}
