using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentPackageDocument
    {
        public int DocumentPackageDocumentId { get; set; }
        /// <summary>
        /// ~Foreign Key to Document Package
        /// </summary>
        public int? DocumentPackageId { get; set; }
        public int DocumentId { get; set; }

        public virtual Document Document { get; set; }
        public virtual DocumentPackage DocumentPackage { get; set; }
    }
}
