using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemDataPort
    {
        public int SystemDataPortId { get; set; }
        public int SystemObjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
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
        public byte? System { get; set; }
        public bool HasExportFilter { get; set; }
    }
}
