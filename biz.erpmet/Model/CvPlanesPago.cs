using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPlanesPago
    {
        public CvPlanesPago()
        {
            CvContratosAccesorios = new HashSet<CvContratosAccesorio>();
            CvPlanesPagosDets = new HashSet<CvPlanesPagosDet>();
        }

        public int IdPlanPago { get; set; }
        public short PlanPago { get; set; }
        public int IdContrato { get; set; }
        public int IdTipoPlan { get; set; }
        public string Descri { get; set; }
        public decimal Monto { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal MontoIva { get; set; }
        public decimal Total { get; set; }
        public short NumeroPeriodos { get; set; }
        public int IdTipoMoneda { get; set; }
        public byte Periodicidad { get; set; }
        public byte Prioridad { get; set; }
        public decimal PorcentajeEnganche { get; set; }
        public bool Cancelado { get; set; }
        public decimal TasaIntAnual { get; set; }
        public int? IdCuentaSe { get; set; }
        public int? IdCuentaCe { get; set; }
        public bool ConsiderarEnEscritura { get; set; }
        public bool ConsiderarInteresSsi { get; set; }
        public decimal MontoMensualidadSsi { get; set; }

        public virtual CvContrato IdContratoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaCeNavigation { get; set; }
        public virtual CtbCuenta IdCuentaSeNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual CvTiposPlan IdTipoPlanNavigation { get; set; }
        public virtual ICollection<CvContratosAccesorio> CvContratosAccesorios { get; set; }
        public virtual ICollection<CvPlanesPagosDet> CvPlanesPagosDets { get; set; }
    }
}
