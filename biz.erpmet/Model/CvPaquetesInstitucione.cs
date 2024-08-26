using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPaquetesInstitucione
    {
        public int IdPaqueteInstitucion { get; set; }
        public int IdProyectoPaquete { get; set; }
        public int IdVivienda { get; set; }

        public virtual CvProyectosPaquete IdProyectoPaqueteNavigation { get; set; }
    }
}
