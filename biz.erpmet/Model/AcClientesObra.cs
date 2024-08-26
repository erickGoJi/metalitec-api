using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesObra
    {
        public int IdClienteObra { get; set; }
        public int IdCatCliente { get; set; }
        public string Obra { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
    }
}
