using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwExtraSearch
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ExtraType { get; set; }
        public byte? Addition { get; set; }
        public string RecalculateRollType { get; set; }
        public string CostCode { get; set; }
        public string RollType { get; set; }
        public string CalculationType { get; set; }
        public string ItemExtraType { get; set; }
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
