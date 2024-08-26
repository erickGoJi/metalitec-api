using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportQscategorysetcategory
    {
        public int QscategorySetId { get; set; }
        public string QsCategorySet { get; set; }
        public int? QscategoryId { get; set; }
        public string QsCategory { get; set; }
        public string QsCategoryDescription { get; set; }
        public string QsCategoryUnit { get; set; }
        public string QsCategoryType { get; set; }
        public string QsCategoryNotes { get; set; }
    }
}
