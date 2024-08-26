using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosPaquete
    {
        public CvProyectosPaquete()
        {
            CvPaquetesInstituciones = new HashSet<CvPaquetesInstitucione>();
        }

        public int IdProyectoPaquete { get; set; }
        public int IdProyecto { get; set; }
        public int IdCredito { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int IdTipoMoneda { get; set; }
        public DateTime Fecha { get; set; }

        public virtual CvCredito IdCreditoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual ICollection<CvPaquetesInstitucione> CvPaquetesInstituciones { get; set; }
    }
}
