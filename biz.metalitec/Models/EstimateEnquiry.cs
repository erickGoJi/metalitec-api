using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateEnquiry
    {
        /// <summary>
        /// Enquiry the estimate is linked to
        /// </summary>
        public int EnquiryId { get; set; }
        /// <summary>
        /// Estimate the enquiry is linked to
        /// </summary>
        public int EstimateId { get; set; }

        public virtual Enquiry Enquiry { get; set; }
        public virtual Estimate Estimate { get; set; }
    }
}
