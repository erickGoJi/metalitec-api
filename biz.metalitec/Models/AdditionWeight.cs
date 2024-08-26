using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class AdditionWeight
    {
        /// <summary>
        /// Unique weight addition ID number
        /// </summary>
        public int AdditionWeightId { get; set; }
        /// <summary>
        /// The section type the addition applies to
        /// </summary>
        public int SectionTypeId { get; set; }
        /// <summary>
        /// Weight to which the addition takes effect
        /// </summary>
        public double ToWeight { get; set; }
        /// <summary>
        /// The value of the addition
        /// </summary>
        public double Value { get; set; }
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual SectionType SectionType { get; set; }
    }
}
