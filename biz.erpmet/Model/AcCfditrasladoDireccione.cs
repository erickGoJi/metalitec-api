using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCfditrasladoDireccione
    {
        public AcCfditrasladoDireccione()
        {
            AcCfditraslados = new HashSet<AcCfditraslado>();
        }

        public int IdCfditrasladoDirecciones { get; set; }
        public string NombreDireccion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Delegacion { get; set; }
        public int? IdCiudad { get; set; }
        public string Telefono { get; set; }
        public string EntreCalles { get; set; }

        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual ICollection<AcCfditraslado> AcCfditraslados { get; set; }
    }
}
