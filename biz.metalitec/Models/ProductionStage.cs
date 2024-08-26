using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionStage
    {
        public ProductionStage()
        {
            ProductionProcesses = new HashSet<ProductionProcess>();
        }

        public int ProductionStageId { get; set; }
        public string Name { get; set; }
        public int StageNo { get; set; }
        public string Color { get; set; }
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
        public byte System { get; set; }

        public virtual ICollection<ProductionProcess> ProductionProcesses { get; set; }
    }
}
