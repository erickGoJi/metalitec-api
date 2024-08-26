using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CtbPrefijo
    {
        public int IdPrefijo { get; set; }
        public string Prefijo { get; set; }
        public string NombreBase { get; set; }
        public bool DiaAnterior { get; set; }
        public short? Anio { get; set; }
        public short? MesInicial { get; set; }
        public short? MesFinal { get; set; }
        public bool Importar { get; set; }
        public short Hora { get; set; }
        public short Minuto { get; set; }
        public string RutaArchivo { get; set; }
    }
}
