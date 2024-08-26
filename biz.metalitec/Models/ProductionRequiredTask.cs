using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTask
    {
        public ProductionRequiredTask()
        {
            ProductionRequiredTaskInstances = new HashSet<ProductionRequiredTaskInstance>();
            ProductionRequiredTaskProperties = new HashSet<ProductionRequiredTaskProperty>();
            ProductionRequiredTaskStrategies = new HashSet<ProductionRequiredTaskStrategy>();
        }

        /// <summary>
        /// Required Task Unique ID Number
        /// </summary>
        public int ProductionRequiredTaskId { get; set; }
        /// <summary>
        /// Name of the Required Task
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Required Task
        /// </summary>
        public string Description { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }
        /// <summary>
        /// Property Mask to Describe Task Instance
        /// </summary>
        public string InstanceDescriptionMask { get; set; }
        /// <summary>
        /// Whether individual Instances of this Required Task must be completed before a Production Item can be progressed
        /// </summary>
        public bool TrackInstancesInProduction { get; set; }

        public virtual ICollection<ProductionRequiredTaskInstance> ProductionRequiredTaskInstances { get; set; }
        public virtual ICollection<ProductionRequiredTaskProperty> ProductionRequiredTaskProperties { get; set; }
        public virtual ICollection<ProductionRequiredTaskStrategy> ProductionRequiredTaskStrategies { get; set; }
    }
}
