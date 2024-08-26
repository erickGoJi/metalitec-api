using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwFacilitySearch
    {
        public int FacilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double WeeklyCapacityWeight { get; set; }
        public double WeeklyCapacityHours { get; set; }
        public int CurrencyId { get; set; }
        public string Currency { get; set; }
        public int? DefaultCalendarId { get; set; }
        public string Calendar { get; set; }
        public string DefaultLocation { get; set; }
        public string DefaultOffcutLocation { get; set; }
        public string DefaultAssemblyLocation { get; set; }
        public string AngleNestingEngine { get; set; }
        public string LinearNestingEngine { get; set; }
        public string PlateNestingEngine { get; set; }
        public string DivisionName { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int System { get; set; }
    }
}
