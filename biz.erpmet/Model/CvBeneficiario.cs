using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvBeneficiario
    {
        public int IdBeneficiario { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public byte Edad { get; set; }
        public byte Parentesco { get; set; }
        public decimal PorParticipacion { get; set; }

        public virtual CvCliente IdClienteNavigation { get; set; }
    }
}
