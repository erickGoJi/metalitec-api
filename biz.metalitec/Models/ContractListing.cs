using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractListing
    {
        public ContractListing()
        {
            ContractDrawings = new HashSet<ContractDrawing>();
            ContractLots = new HashSet<ContractLot>();
            ContractMarkInstances = new HashSet<ContractMarkInstance>();
            ContractMarkItemInstances = new HashSet<ContractMarkItemInstance>();
            ContractPrelimMarks = new HashSet<ContractPrelimMark>();
            ContractPrelimSequenceLists = new HashSet<ContractPrelimSequenceList>();
            ContractRevisions = new HashSet<ContractRevision>();
            NestingResultArchives = new HashSet<NestingResultArchive>();
            NestingResults = new HashSet<NestingResult>();
        }

        public int ContractListingId { get; set; }
        public int ContractId { get; set; }
        /// <summary>
        /// ~1 - Prelim , 2 - Detail, 3 - EDI, 4 - Manual Customer Listing
        /// </summary>
        public int ListingTypeId { get; set; }
        public string IssueNo { get; set; }
        public DateTime IssueDate { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the contract.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public Guid Guid { get; set; }
        public string ImportModelType { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractDrawing> ContractDrawings { get; set; }
        public virtual ICollection<ContractLot> ContractLots { get; set; }
        public virtual ICollection<ContractMarkInstance> ContractMarkInstances { get; set; }
        public virtual ICollection<ContractMarkItemInstance> ContractMarkItemInstances { get; set; }
        public virtual ICollection<ContractPrelimMark> ContractPrelimMarks { get; set; }
        public virtual ICollection<ContractPrelimSequenceList> ContractPrelimSequenceLists { get; set; }
        public virtual ICollection<ContractRevision> ContractRevisions { get; set; }
        public virtual ICollection<NestingResultArchive> NestingResultArchives { get; set; }
        public virtual ICollection<NestingResult> NestingResults { get; set; }
    }
}
