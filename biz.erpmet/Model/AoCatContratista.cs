using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoCatContratista
    {
        public AoCatContratista()
        {
            AoAvanceDiarios = new HashSet<AoAvanceDiario>();
            AoCatDestajista = new HashSet<AoCatDestajista>();
            AoSubContratos = new HashSet<AoSubContrato>();
        }

        public int IdContratista { get; set; }
        public string Contratista { get; set; }
        public string RazonSocial { get; set; }
        public int IdProveedor { get; set; }
        public string Observaciones { get; set; }
        public int IdCiudad { get; set; }
        public string Delegacion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Especialidad { get; set; }
        public string NumEscritura { get; set; }
        public DateTime? FechaEscritura { get; set; }
        public string Notario { get; set; }
        public string CiudadNotario { get; set; }
        public string CiudadRegistroNotario { get; set; }
        public string FolioRegistroNotario { get; set; }
        public string DomicilioNotario { get; set; }
        public string RepresentanteLegal { get; set; }
        public string EscrituraRepresentante { get; set; }
        public DateTime? FechaEscrituraRepresentante { get; set; }
        public string NotarioRepresentante { get; set; }
        public string NumeroNotaria { get; set; }

        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual ICollection<AoAvanceDiario> AoAvanceDiarios { get; set; }
        public virtual ICollection<AoCatDestajista> AoCatDestajista { get; set; }
        public virtual ICollection<AoSubContrato> AoSubContratos { get; set; }
    }
}
