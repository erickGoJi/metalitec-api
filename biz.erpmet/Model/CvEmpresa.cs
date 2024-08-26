using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvEmpresa
    {
        public CvEmpresa()
        {
            CvClientes = new HashSet<CvCliente>();
            CvConyuges = new HashSet<CvConyuge>();
        }

        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public string Telefono { get; set; }
        public int? IdEstado { get; set; }
        public string MpioDeleg { get; set; }
        public string Imss { get; set; }
        public string PuestoRepLegal { get; set; }
        public string RepLegal { get; set; }
        public string Rfc { get; set; }
        public string RegistroPatronal { get; set; }
        public int? IdSindicato { get; set; }
        public string FnumInterior { get; set; }
        public string FnumExterior { get; set; }
        public string Flote { get; set; }
        public string Fmanzana { get; set; }
        public string Flocalidad { get; set; }
        public string Lada { get; set; }
        public string Extension { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }

        public virtual AcCatEstado IdEstadoNavigation { get; set; }
        public virtual CvSindicato IdSindicatoNavigation { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvConyuge> CvConyuges { get; set; }
    }
}
