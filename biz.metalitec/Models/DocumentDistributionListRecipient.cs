using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentDistributionListRecipient
    {
        public int DocumentDistributionListRecipientId { get; set; }
        /// <summary>
        /// ~Foreign Key to Distribution List
        /// </summary>
        public int DocumentDistributionListId { get; set; }
        /// <summary>
        /// ~Foreign Key to Recipient
        /// </summary>
        public int ContactId { get; set; }
        /// <summary>
        /// Is this a team leader?
        /// </summary>
        public bool? TeamLeader { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual DocumentDistributionList DocumentDistributionList { get; set; }
    }
}
