using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractContact
    {
        public int ContractContactId { get; set; }
        public int ContractId { get; set; }
        public int ContactId { get; set; }
        public bool? Internal { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
