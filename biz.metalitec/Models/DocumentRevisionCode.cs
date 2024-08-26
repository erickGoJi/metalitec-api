using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentRevisionCode
    {
        public DocumentRevisionCode()
        {
            DocumentRevisions = new HashSet<DocumentRevision>();
        }

        /// <summary>
        /// The unique revision ID number generated automatically.
        /// </summary>
        public int DocumentRevisionCodeId { get; set; }
        /// <summary>
        /// The Name of the Revision
        /// </summary>
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// The sequence of the Revision
        /// </summary>
        public int Sequence { get; set; }
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
        /// <summary>
        /// System Value
        /// </summary>
        public int System { get; set; }

        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
    }
}
