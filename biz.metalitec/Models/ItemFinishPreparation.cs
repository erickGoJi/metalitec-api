using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemFinishPreparation
    {
        public int ItemFinishPreparationId { get; set; }
        public int ItemFinishId { get; set; }
        public int? DescriptionId { get; set; }
        public int? PreparationId { get; set; }
        public int? ProfileId { get; set; }

        public virtual ItemFinish ItemFinish { get; set; }
    }
}
