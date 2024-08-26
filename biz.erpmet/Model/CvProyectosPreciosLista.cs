using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class CvProyectosPreciosLista
    {
        public int IdProyectoPrecioLista { get; set; }
        public int IdProyectoPrototipo { get; set; }
        public int IdSubtipoTerreno { get; set; }
        public decimal PrecioListaPorMetro2 { get; set; }

        public virtual CvProyectosPrototipo IdProyectoPrototipoNavigation { get; set; }
        public virtual CvSubtiposTerreno IdSubtipoTerrenoNavigation { get; set; }
    }
}
