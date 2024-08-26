using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcCatDeudore
    {
        public AcCatDeudore()
        {
            AcGastosXcomprobars = new HashSet<AcGastosXcomprobar>();
        }

        public int IdDeudor { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public int? IdCiudad { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodPost { get; set; }
        public string Delegacion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }
        public string Curp { get; set; }
        public int IdCuentaDeudor { get; set; }
        public int? IdBancoSat { get; set; }
        public string CuentaBancaria { get; set; }
        public string BancoSat { get; set; }
        public string MonedaSatdefault { get; set; }

        public virtual CtbCuenta IdCuentaDeudorNavigation { get; set; }
        public virtual ICollection<AcGastosXcomprobar> AcGastosXcomprobars { get; set; }
    }
}
