using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPresupuestoControl
    {
        public AoPresupuestoControl()
        {
            AcAlmacenSalida = new HashSet<AcAlmacenSalida>();
            AoAvanceDiarios = new HashSet<AoAvanceDiario>();
            AoConceptosXdestajista = new HashSet<AoConceptosXdestajistum>();
            AoDestajosEstDets = new HashSet<AoDestajosEstDet>();
            AoPresupuestoControlOcdets = new HashSet<AoPresupuestoControlOcdet>();
            AoPresupuestoControlPeriodos = new HashSet<AoPresupuestoControlPeriodo>();
            AoPresupuestoControlPrecedenciaIdPresupuestoControlHijoNavigations = new HashSet<AoPresupuestoControlPrecedencia>();
            AoPresupuestoControlPrecedenciaIdPresupuestoControlPadreNavigations = new HashSet<AoPresupuestoControlPrecedencia>();
            AoProgramaObras = new HashSet<AoProgramaObra>();
            AoPrototiposDets = new HashSet<AoPrototiposDet>();
            AoSubcontratosDets = new HashSet<AoSubcontratosDet>();
        }

        public int IdPresupuestoControl { get; set; }
        public int IdProyecto { get; set; }
        public int IdPartida { get; set; }
        public int IdConcepto { get; set; }
        public int Renglon { get; set; }
        public decimal CantidadOriginal { get; set; }
        public decimal CantidadOc { get; set; }
        public decimal CantidadMocapturado { get; set; }
        public decimal CantidadSubmo { get; set; }
        public decimal CantidadMocontratado { get; set; }
        public decimal CantidadMocontratadoSubmo { get; set; }
        public decimal CantidadSubestimada { get; set; }
        public decimal CantidadDesestimada { get; set; }
        public decimal CantidadSubmoestimada { get; set; }
        public decimal CostoGlobalActual { get; set; }
        public decimal CostoDestajoActual { get; set; }
        public decimal CostoSubmoactual { get; set; }
        public DateTime? FechaInicioPrograma { get; set; }
        public int Duracion { get; set; }
        public DateTime? FechaFinPrograma { get; set; }
        public bool? FraccionaTope { get; set; }
        public bool? EstimaDecimal { get; set; }
        public bool Marca { get; set; }
        public decimal CantidadOriginalAnt { get; set; }
        public decimal CantidadMocapturadoAnt { get; set; }
        public decimal CantidadSubmoant { get; set; }
        public bool CantidadInconsistente { get; set; }
        public bool ActividadProgramada { get; set; }
        public int ControlPu2010 { get; set; }
        public decimal CantidadOriginalImportada { get; set; }
        public decimal CostoOriginalImportado { get; set; }
        public decimal CostoOriginalSubcontrato { get; set; }

        public virtual AoCatConcepto IdConceptoNavigation { get; set; }
        public virtual AoPartida IdPartidaNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalida { get; set; }
        public virtual ICollection<AoAvanceDiario> AoAvanceDiarios { get; set; }
        public virtual ICollection<AoConceptosXdestajistum> AoConceptosXdestajista { get; set; }
        public virtual ICollection<AoDestajosEstDet> AoDestajosEstDets { get; set; }
        public virtual ICollection<AoPresupuestoControlOcdet> AoPresupuestoControlOcdets { get; set; }
        public virtual ICollection<AoPresupuestoControlPeriodo> AoPresupuestoControlPeriodos { get; set; }
        public virtual ICollection<AoPresupuestoControlPrecedencia> AoPresupuestoControlPrecedenciaIdPresupuestoControlHijoNavigations { get; set; }
        public virtual ICollection<AoPresupuestoControlPrecedencia> AoPresupuestoControlPrecedenciaIdPresupuestoControlPadreNavigations { get; set; }
        public virtual ICollection<AoProgramaObra> AoProgramaObras { get; set; }
        public virtual ICollection<AoPrototiposDet> AoPrototiposDets { get; set; }
        public virtual ICollection<AoSubcontratosDet> AoSubcontratosDets { get; set; }
    }
}
