using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Aomizar
    {
        public Aomizar()
        {
            AomizarDets = new HashSet<AomizarDet>();
        }

        public int IdMizar { get; set; }
        public int IdProyecto { get; set; }
        public int Proveedorgeo { get; set; }
        public int ContratoMizar { get; set; }
        public int ContratoNeodata { get; set; }
        public int NumEst { get; set; }
        public string Unegocio { get; set; }
        public string CentrodeCosto { get; set; }
        public byte TipoProyecto { get; set; }
        public byte Estatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public byte TipoRegistro { get; set; }
        public bool AplicadoFgantesIva { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AomizarDet> AomizarDets { get; set; }
    }
}
