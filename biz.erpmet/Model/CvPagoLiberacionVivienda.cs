using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPagoLiberacionVivienda
    {
        public CvPagoLiberacionVivienda()
        {
            CvPagoLiberacionViviendasDets = new HashSet<CvPagoLiberacionViviendasDet>();
        }

        public int IdPagoLiberacionVivienda { get; set; }
        public int FolioPagoLiberacionVivienda { get; set; }
        public int IdProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCuentaCargo { get; set; }
        public int IdCuentaPasivo { get; set; }
        public int IdInsumo { get; set; }
        public decimal MontoPago { get; set; }
        public int IdPoliza { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdPolizaInversa { get; set; }
        public string DescripcionCancelacion { get; set; }

        public virtual CtbCuenta IdCuentaCargoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaPasivoNavigation { get; set; }
        public virtual AcCatInsumo IdInsumoNavigation { get; set; }
        public virtual CtbPoliza IdPolizaInversaNavigation { get; set; }
        public virtual CtbPoliza IdPolizaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<CvPagoLiberacionViviendasDet> CvPagoLiberacionViviendasDets { get; set; }
    }
}
