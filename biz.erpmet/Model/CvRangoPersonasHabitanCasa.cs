using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvRangoPersonasHabitanCasa
    {
        public CvRangoPersonasHabitanCasa()
        {
            CvClientes = new HashSet<CvCliente>();
        }

        public int IdRangoPersonasHabitanCasa { get; set; }
        public string RangoPersonasHabitanCasa { get; set; }
        public int Orden { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
    }
}
