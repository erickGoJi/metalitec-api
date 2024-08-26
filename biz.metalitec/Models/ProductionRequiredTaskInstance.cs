using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskInstance
    {
        public ProductionRequiredTaskInstance()
        {
            ProductionRequiredTaskInstanceProperties = new HashSet<ProductionRequiredTaskInstanceProperty>();
        }

        public int ProductionRequiredTaskInstanceId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int ProductionRequiredTaskId { get; set; }
        public int Instance { get; set; }
        public int? MarkInstanceId { get; set; }
        public int? MarkItemInstanceId { get; set; }

        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkInstance MarkInstance { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual ContractMarkItemInstance MarkItemInstance { get; set; }
        public virtual ProductionRequiredTask ProductionRequiredTask { get; set; }
        public virtual ICollection<ProductionRequiredTaskInstanceProperty> ProductionRequiredTaskInstanceProperties { get; set; }
    }
}
