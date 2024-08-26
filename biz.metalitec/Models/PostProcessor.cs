using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PostProcessor
    {
        public int PostProcessorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string Parameters { get; set; }
        public int Camformat { get; set; }
        public bool RequiresParameterFile { get; set; }
        public string ParameterFile { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }
    }
}
