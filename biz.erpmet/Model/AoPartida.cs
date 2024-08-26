using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AoPartida
    {
        public AoPartida()
        {
            AcAditivasExplosionDets = new HashSet<AcAditivasExplosionDet>();
            AcRequisicionDets = new HashSet<AcRequisicionDet>();
            AcRequisiciones = new HashSet<AcRequisicione>();
            AoExpXpartida = new HashSet<AoExpXpartidum>();
            AoPartidasAvanceFisicoDets = new HashSet<AoPartidasAvanceFisicoDet>();
            AoPresupuestoControls = new HashSet<AoPresupuestoControl>();
        }

        public int IdPartida { get; set; }
        public int IdProyecto { get; set; }
        public string Partida { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public bool? AceptaMov { get; set; }
        public int? IdUnegocio { get; set; }
        public string ModeloCasa { get; set; }

        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual AounidadNegociogeo IdUnegocioNavigation { get; set; }
        public virtual ICollection<AcAditivasExplosionDet> AcAditivasExplosionDets { get; set; }
        public virtual ICollection<AcRequisicionDet> AcRequisicionDets { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisiciones { get; set; }
        public virtual ICollection<AoExpXpartidum> AoExpXpartida { get; set; }
        public virtual ICollection<AoPartidasAvanceFisicoDet> AoPartidasAvanceFisicoDets { get; set; }
        public virtual ICollection<AoPresupuestoControl> AoPresupuestoControls { get; set; }
    }
}
