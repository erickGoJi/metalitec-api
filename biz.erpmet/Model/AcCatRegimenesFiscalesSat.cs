using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatRegimenesFiscalesSat
    {
        public AcCatRegimenesFiscalesSat()
        {
            Feregimenes = new HashSet<Feregimene>();
        }

        public int IdCatRegimen { get; set; }
        public string CodigoRegimen { get; set; }
        public string DescripcionRegimen { get; set; }
        public bool AplicaPfisica { get; set; }
        public bool AplicaPmoral { get; set; }
        public DateTime? FechaIniVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Version { get; set; }

        public virtual ICollection<Feregimene> Feregimenes { get; set; }
    }
}
