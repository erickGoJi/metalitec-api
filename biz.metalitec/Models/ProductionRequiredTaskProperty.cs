using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskProperty
    {
        public ProductionRequiredTaskProperty()
        {
            ProductionRequiredTaskInstanceProperties = new HashSet<ProductionRequiredTaskInstanceProperty>();
            ProductionRuleParameterRequiredTaskProperties = new HashSet<ProductionRuleParameterRequiredTaskProperty>();
        }

        /// <summary>
        /// Required Task Property Unique ID Number
        /// </summary>
        public int ProductionRequiredTaskPropertyId { get; set; }
        public int ProductionRequiredTaskId { get; set; }
        /// <summary>
        /// Name of the Required Task Property
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Data Type of the Required Task Property
        /// </summary>
        public int PropertyType { get; set; }
        /// <summary>
        /// The Extraction Routine to populate the Required Task Property
        /// </summary>
        public int? ProductionRequiredTaskExtractorId { get; set; }
        /// <summary>
        /// The Extraction Routine Property which maps to the Required Task Property
        /// </summary>
        public string ProductionRequiredTaskExtractorProperty { get; set; }

        public virtual ProductionRequiredTask ProductionRequiredTask { get; set; }
        public virtual ProductionRequiredTaskExtractor ProductionRequiredTaskExtractor { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstanceProperty> ProductionRequiredTaskInstanceProperties { get; set; }
        public virtual ICollection<ProductionRuleParameterRequiredTaskProperty> ProductionRuleParameterRequiredTaskProperties { get; set; }
    }
}
