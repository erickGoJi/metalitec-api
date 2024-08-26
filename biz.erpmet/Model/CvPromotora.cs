using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPromotora
    {
        public CvPromotora()
        {
            CvVendedores = new HashSet<CvVendedore>();
        }

        public int IdPromotora { get; set; }
        public string Promotora { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RepLegal { get; set; }
        public string Rfc { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<CvVendedore> CvVendedores { get; set; }
    }
}
