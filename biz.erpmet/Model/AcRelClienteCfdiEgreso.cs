using System;
using System.Collections.Generic;

namespace biz.erpmet.Model
{
    public partial class AcRelClienteCfdiEgreso
    {
        public int IdRelClienteCfdiEgreso { get; set; }
        public int? IdContratoDet { get; set; }
        public string Partida { get; set; }
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Descripcionauxiliar { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public string Descripcionpartida { get; set; }
        public string Claveprodserv { get; set; }
        public string Claveunidad { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Impuestostrasladados { get; set; }
        public decimal? Impuestosretenidos { get; set; }
        public decimal? Total { get; set; }
        public string IdProductoServicioSat { get; set; }
        public string IdUnidadSat { get; set; }
        public decimal? MontoPoliza { get; set; }
        public string Cuentapredial { get; set; }
        public int? IdDtConceptos { get; set; }
        public int? IdProyectoConcepto { get; set; }
        public int? IdProyectoPartida { get; set; }
    }
}
