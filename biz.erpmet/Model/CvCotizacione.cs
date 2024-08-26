using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCotizacione
    {
        public CvCotizacione()
        {
            CvCotizacionesDets = new HashSet<CvCotizacionesDet>();
        }

        public int IdCotizacion { get; set; }
        public int FolioCotizacion { get; set; }
        public int IdCliente { get; set; }
        public int IdVivienda { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public decimal MontoApartado { get; set; }
        public DateTime FechaIndividualizacion { get; set; }
        public string TextoExtra { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<CvCotizacionesDet> CvCotizacionesDets { get; set; }
    }
}
