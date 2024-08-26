using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderNumber
    {
        public int ChangeOrderNumberId { get; set; }
        public int? ContractId { get; set; }
        public int? NextNumber { get; set; }
    }
}
