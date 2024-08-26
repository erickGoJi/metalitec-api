using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvPppresupuesto
    {
        public int IdPppresupuesto { get; set; }
        public int IdProyectoPrototipo { get; set; }
        public int IdProyectoCredito { get; set; }
        public decimal InversionInicial { get; set; }
        public decimal MontoCredito { get; set; }
        public decimal AniosCredito { get; set; }
        public decimal PagoMensual { get; set; }
        public decimal AportacionPatronal { get; set; }
        public decimal PagoMensualNeto { get; set; }
        public decimal IngresoMinimo { get; set; }

        public virtual CvProyectosCredito IdProyectoCreditoNavigation { get; set; }
        public virtual CvProyectosPrototipo IdProyectoPrototipoNavigation { get; set; }
    }
}
