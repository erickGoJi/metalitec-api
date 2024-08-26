using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoCatDestajista
    {
        public AoCatDestajista()
        {
            AcAlmacenSalida = new HashSet<AcAlmacenSalida>();
            AoAnticiposDestajista = new HashSet<AoAnticiposDestajista>();
            AoAvanceDiarios = new HashSet<AoAvanceDiario>();
            AoConceptosXdestajista = new HashSet<AoConceptosXdestajistum>();
            AoDestajistasContratistasPu2010s = new HashSet<AoDestajistasContratistasPu2010>();
            AoDestajosEsts = new HashSet<AoDestajosEst>();
        }

        public int IdDestajista { get; set; }
        public string Destajista { get; set; }
        public string RazonSocial { get; set; }
        public string Observaciones { get; set; }
        public int IdCiudad { get; set; }
        public string Delegacion { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string Especialidad { get; set; }
        public int IdTipoMoneda { get; set; }
        public decimal PorcentajeFonGar { get; set; }
        public int? IdContratista { get; set; }
        public bool EsContratistaMo { get; set; }
        public bool EsContratistaInsSum { get; set; }
        public int? IdCuentaAcreedor { get; set; }
        public int? IdCuentaAnticipo { get; set; }
        public int? IdCuentaViaticos { get; set; }

        public virtual AcCatCiudade IdCiudadNavigation { get; set; }
        public virtual AoCatContratista IdContratistaNavigation { get; set; }
        public virtual CtbCuenta IdCuentaAcreedorNavigation { get; set; }
        public virtual CtbCuenta IdCuentaAnticipoNavigation { get; set; }
        public virtual CtbCuenta IdCuentaViaticosNavigation { get; set; }
        public virtual AcCatMoneda IdTipoMonedaNavigation { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalida { get; set; }
        public virtual ICollection<AoAnticiposDestajista> AoAnticiposDestajista { get; set; }
        public virtual ICollection<AoAvanceDiario> AoAvanceDiarios { get; set; }
        public virtual ICollection<AoConceptosXdestajistum> AoConceptosXdestajista { get; set; }
        public virtual ICollection<AoDestajistasContratistasPu2010> AoDestajistasContratistasPu2010s { get; set; }
        public virtual ICollection<AoDestajosEst> AoDestajosEsts { get; set; }
    }
}
