using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcClientesAntilavado
    {
        public AcClientesAntilavado()
        {
            AcClientesAntilavadoDets = new HashSet<AcClientesAntilavadoDet>();
            CtbPolizasDets = new HashSet<CtbPolizasDet>();
        }

        public int IdClienteAntilavado { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string PaisDeNacimiento { get; set; }
        public string PaisDeNacionalidad { get; set; }
        public string ActividadOcupacion { get; set; }
        public string DomicilioCalle { get; set; }
        public string DomicilioNoExterior { get; set; }
        public string DomicilioNoInterior { get; set; }
        public string DomicilioColonia { get; set; }
        public int DomicilioIdEstado { get; set; }
        public string DomicilioPais { get; set; }
        public string DomicilioCodigoPostal { get; set; }
        public string DomicilioDelegacion { get; set; }
        public int DomicilioIdCiudad { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string IdentificacionNombre { get; set; }
        public string IdentificacionEmisor { get; set; }
        public string IdentificacionNumero { get; set; }
        public bool EsExtranjero { get; set; }
        public string DomicilioCalleExtranjero { get; set; }
        public string DomicilioNoExteriorExtranjero { get; set; }
        public string DomicilioNoInteriorExtranjero { get; set; }
        public string DomicilioColoniaExtranjero { get; set; }
        public string DomicilioEstadoExtranjero { get; set; }
        public string DomicilioPaisExtranjero { get; set; }
        public string DomicilioCodigoPostalExtranjero { get; set; }
        public string DomicilioDelegacionExtranjero { get; set; }
        public string DomicilioCiudadExtranjero { get; set; }

        public virtual AcCatCiudade DomicilioIdCiudadNavigation { get; set; }
        public virtual AcCatEstado DomicilioIdEstadoNavigation { get; set; }
        public virtual ICollection<AcClientesAntilavadoDet> AcClientesAntilavadoDets { get; set; }
        public virtual ICollection<CtbPolizasDet> CtbPolizasDets { get; set; }
    }
}
