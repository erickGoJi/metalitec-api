using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvCredito
    {
        public CvCredito()
        {
            CvCetapas = new HashSet<CvCetapa>();
            CvClientes = new HashSet<CvCliente>();
            CvCotizacionesDets = new HashSet<CvCotizacionesDet>();
            CvDocumentos = new HashSet<CvDocumento>();
            CvProyectosCreditos = new HashSet<CvProyectosCredito>();
            CvProyectosPaquetes = new HashSet<CvProyectosPaquete>();
        }

        public int IdCredito { get; set; }
        public string Credito { get; set; }
        public string Texto { get; set; }
        public int? TipoRelleno { get; set; }
        public string Ansi { get; set; }
        public decimal EscalaRelleno { get; set; }
        public string DatosAdicionales { get; set; }

        public virtual ICollection<CvCetapa> CvCetapas { get; set; }
        public virtual ICollection<CvCliente> CvClientes { get; set; }
        public virtual ICollection<CvCotizacionesDet> CvCotizacionesDets { get; set; }
        public virtual ICollection<CvDocumento> CvDocumentos { get; set; }
        public virtual ICollection<CvProyectosCredito> CvProyectosCreditos { get; set; }
        public virtual ICollection<CvProyectosPaquete> CvProyectosPaquetes { get; set; }
    }
}
