using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskExtractor
    {
        public ProductionRequiredTaskExtractor()
        {
            ProductionRequiredTaskProperties = new HashSet<ProductionRequiredTaskProperty>();
        }

        /// <summary>
        /// Required Task Extractor Unique ID Number
        /// </summary>
        public int ProductionRequiredTaskExtractorId { get; set; }
        /// <summary>
        /// Name of the Required Task Extractor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Required Task Extractor
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The Type of the Required Task Extractor
        /// </summary>
        public int ProductionRequiredTaskExtractorTypeId { get; set; }
        /// <summary>
        /// The Type of Work Order the Required Task Extractor relates to
        /// </summary>
        public int WorkOrderTypeId { get; set; }
        /// <summary>
        /// Whether the Required Task Extractor is available for use
        /// </summary>
        public bool Active { get; set; }
        public int CodeBaseId { get; set; }
        public string Script { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }

        public virtual ProductionRequiredTaskExtractorType ProductionRequiredTaskExtractorType { get; set; }
        public virtual ICollection<ProductionRequiredTaskProperty> ProductionRequiredTaskProperties { get; set; }
    }
}
