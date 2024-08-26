using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductiontemplateSearch
    {
        public int ProductionTemplateId { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public string Name { get; set; }
        public int WorkOrderTypeId { get; set; }
        public string WorkOrderType { get; set; }
        public int? WorkOrderCategoryId { get; set; }
        public string WorkOrderCategory { get; set; }
        public int AssemblyTypeId { get; set; }
        public string AssemblyType { get; set; }
        public int MarkItemTypeId { get; set; }
        public string MarkItemType { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
    }
}
