using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvSucursale
    {
        public CvSucursale()
        {
            CvVendedores = new HashSet<CvVendedore>();
        }

        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Texto { get; set; }

        public virtual ICollection<CvVendedore> CvVendedores { get; set; }
    }
}
