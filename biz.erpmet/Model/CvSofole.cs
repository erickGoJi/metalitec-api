using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvSofole
    {
        public CvSofole()
        {
            CvClientes = new HashSet<CvCliente>();
            CvDepositosSofols = new HashSet<CvDepositosSofol>();
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdSofol { get; set; }
        public string Sofol { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string MpioDeleg { get; set; }
        public string RepLegal { get; set; }
        public string Rfc { get; set; }
        public string FnoCuenta { get; set; }
        public string Fbanco { get; set; }
        public string Fplaza { get; set; }
        public string Fclave { get; set; }
        public string FnombreBeneficiario { get; set; }

        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvDepositosSofol> CvDepositosSofols { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
