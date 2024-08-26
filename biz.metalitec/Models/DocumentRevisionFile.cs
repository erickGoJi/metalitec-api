using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentRevisionFile
    {
        public int DocumentRevisionFileId { get; set; }
        public int DocumentRevisionId { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual DocumentRevision DocumentRevision { get; set; }
    }
}
