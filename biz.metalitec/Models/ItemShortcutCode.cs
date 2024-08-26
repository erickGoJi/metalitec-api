using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemShortcutCode
    {
        public int ItemShortcutId { get; set; }
        public int? SectionTypeId { get; set; }
        public string SectionSize { get; set; }
        public string ShortcutCode { get; set; }

        public virtual SectionType SectionType { get; set; }
    }
}
