using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittalRecipient
    {
        public int DocumentTransmittalRecipientId { get; set; }
        public int ContactId { get; set; }
        /// <summary>
        /// ~1 = To, 2= CC
        /// </summary>
        public int? RecipientTypeId { get; set; }
        public byte? TeamLeader { get; set; }
        public int? DocumentTransmittalRevisionId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual DocumentTransmittalRevision DocumentTransmittalRevision { get; set; }
    }
}
