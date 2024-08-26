using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcGastosFinanciero
    {
        public AcGastosFinanciero()
        {
            AcGastosFinancierosDets = new HashSet<AcGastosFinancierosDet>();
        }

        public int IdGastosFinancieros { get; set; }
        public int Folio { get; set; }
        public int IdProyecto { get; set; }
        public int IdCuentaBancaria { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaPoliza { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioCancelacion { get; set; }
        public bool Cancelado { get; set; }
        public int IdPoliza { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string Observaciones { get; set; }

        public virtual AcCuentasBancaria IdCuentaBancariaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual AcProveedore IdProveedorNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual SegUsuario IdUsuarioCancelacionNavigation { get; set; }
        public virtual SegUsuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<AcGastosFinancierosDet> AcGastosFinancierosDets { get; set; }
    }
}
