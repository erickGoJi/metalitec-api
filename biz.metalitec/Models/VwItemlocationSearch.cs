using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemlocationSearch
    {
        public int ItemLocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemLocationTypeId { get; set; }
        public string LocationType { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public string Notes { get; set; }
    }
}
