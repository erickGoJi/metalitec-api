using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class AdditionTransport
    {
        /// <summary>
        /// Unique transport addition ID number
        /// </summary>
        public int AdditionTransportId { get; set; }
        /// <summary>
        /// Mill Location
        /// </summary>
        public int MillLocationId { get; set; }
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
    }
}
