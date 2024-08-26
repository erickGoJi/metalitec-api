﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentTypeSearch
    {
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DefaultSize { get; set; }
        public string DefaultFileType { get; set; }
        public string DefaultStorageLocation { get; set; }
    }
}
