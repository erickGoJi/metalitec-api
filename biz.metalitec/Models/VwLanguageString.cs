using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwLanguageString
    {
        public int LanguageId { get; set; }
        public string SystemString { get; set; }
        public string TranslatedString { get; set; }
    }
}
