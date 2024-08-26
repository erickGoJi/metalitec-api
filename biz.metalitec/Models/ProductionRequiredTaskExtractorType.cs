using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionRequiredTaskExtractorType
    {
        public ProductionRequiredTaskExtractorType()
        {
            ProductionRequiredTaskExtractors = new HashSet<ProductionRequiredTaskExtractor>();
        }

        public int ProductionRequiredTaskExtractorTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool System { get; set; }

        public virtual ICollection<ProductionRequiredTaskExtractor> ProductionRequiredTaskExtractors { get; set; }
    }
}
