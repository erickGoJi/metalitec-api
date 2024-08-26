using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesPlanta
    {
        public AcClientesPlanta()
        {
            AcClientesRemisiones = new HashSet<AcClientesRemisione>();
        }

        public int IdClientePlanta { get; set; }
        public string Planta { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public int IdCiudad { get; set; }
        public string Delegacion { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Encargado { get; set; }

        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual ICollection<AcClientesRemisione> AcClientesRemisiones { get; set; }
    }
}
