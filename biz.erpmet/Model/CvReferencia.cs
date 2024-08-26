using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvReferencia
    {
        public int IdReferencia { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool? Familiar { get; set; }
        public string Parentesco { get; set; }
        public string Direccion { get; set; }
        public bool ReferenciaBancaria { get; set; }
        public bool Referenciacomercial { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Lada { get; set; }
        public string TelefonoCelular { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
    }
}
