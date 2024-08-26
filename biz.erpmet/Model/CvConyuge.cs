using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvConyuge
    {
        public int IdConyuge { get; set; }
        public int IdCliente { get; set; }
        public int? IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string NoImss { get; set; }
        public byte? Escolaridad { get; set; }
        public bool Trabaja { get; set; }
        public decimal PuntosInfonavit { get; set; }
        public decimal IngresoMensComp { get; set; }
        public string Lada { get; set; }
        public string Telefono { get; set; }
        public string TelefonoCelular { get; set; }
        public string Email { get; set; }
        public decimal FpensionAlimenticia { get; set; }
        public decimal FmontoAutorizado { get; set; }

        public virtual CvFescolaridad EscolaridadNavigation { get; set; }
        public virtual CvCliente IdClienteNavigation { get; set; }
        public virtual CvEmpresa IdEmpresaNavigation { get; set; }
    }
}
