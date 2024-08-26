using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EnquiryProjectPerson
    {
        public int EnquiryProjectPeopleId { get; set; }
        public int ContactId { get; set; }
        public int EnquiryId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Enquiry Enquiry { get; set; }
    }
}
