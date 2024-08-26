namespace biz.erpmet.Entities
{
    public class FamilyMaterial
    {
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }
        public string Insumo { get; set; }
        public int IdInsumo { get; set; }
        public int IdProveedor { get; set; }
        public int IdProyecto { get; set; }
        public string DescripcionLarga { get; set; }
        public string RFCemisor { get; set; }
    }
}