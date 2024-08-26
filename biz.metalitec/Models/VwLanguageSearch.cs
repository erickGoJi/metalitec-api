using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwLanguageSearch
    {
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public byte Rtllanguage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
