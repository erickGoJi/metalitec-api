using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectNote
    {
        public int SystemObjectNoteId { get; set; }
        public int SystemObjectId { get; set; }
        public string Name { get; set; }
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
    }
}
