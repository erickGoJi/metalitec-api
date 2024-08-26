using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvInmobiliaria
    {
        public int IdInmobiliaria { get; set; }
        public string Inmobiliaria { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
    }
}
