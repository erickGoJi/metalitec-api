using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class Centro
    {
        public Centro()
        {
            AcAlmacenSalida = new HashSet<AcAlmacenSalida>();
            AcAlmacenSalidaDetCcs = new HashSet<AcAlmacenSalidaDetCc>();
            AcRequisiciones = new HashSet<AcRequisicione>();
            AoAvanceDiarios = new HashSet<AoAvanceDiario>();
            AoDestajosEstCcs = new HashSet<AoDestajosEstCc>();
            AoSubContratosEstDetCcs = new HashSet<AoSubContratosEstDetCc>();
        }

        public int IdCentro { get; set; }
        public int IdProyecto { get; set; }
        public string Centro1 { get; set; }
        public string Descripcion { get; set; }
        public int? IdPrototipo { get; set; }
        public bool AceptaMov { get; set; }
        public DateTime? InicioProgramado { get; set; }
        public int? IdPrototipoDet { get; set; }
        public bool Cerrado { get; set; }

        public virtual AoPrototiposDet IdPrototipoDetNavigation { get; set; }
        public virtual AoPrototipo IdPrototipoNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual ICollection<AcAlmacenSalida> AcAlmacenSalida { get; set; }
        public virtual ICollection<AcAlmacenSalidaDetCc> AcAlmacenSalidaDetCcs { get; set; }
        public virtual ICollection<AcRequisicione> AcRequisiciones { get; set; }
        public virtual ICollection<AoAvanceDiario> AoAvanceDiarios { get; set; }
        public virtual ICollection<AoDestajosEstCc> AoDestajosEstCcs { get; set; }
        public virtual ICollection<AoSubContratosEstDetCc> AoSubContratosEstDetCcs { get; set; }
    }
}
