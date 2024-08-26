using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentTransmittal
    {
        public DocumentTransmittal()
        {
            ApplicationForPaymentCorrespondences = new HashSet<ApplicationForPaymentCorrespondence>();
        }

        /// <summary>
        /// The unique transmittal ID number generated automatically.
        /// </summary>
        public int DocumentTransmittalId { get; set; }
        /// <summary>
        /// The Name of this Transmittal
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int DocumentTransmittalTypeId { get; set; }
        /// <summary>
        /// The Contract this is assigned to
        /// </summary>
        public int? ContractId { get; set; }
        public int? FacilityId { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<ApplicationForPaymentCorrespondence> ApplicationForPaymentCorrespondences { get; set; }
    }
}
