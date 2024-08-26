using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            DocumentRevisions = new HashSet<DocumentRevision>();
        }

        /// <summary>
        /// The unique document type ID number generated automatically.
        /// </summary>
        public int DocumentTypeId { get; set; }
        /// <summary>
        /// Name of the Document Type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Document Type
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Lookup for Document Size Defaults
        /// </summary>
        public int? DefaultSizeId { get; set; }
        /// <summary>
        /// Lookup for the Default Filetype of this Document Type
        /// </summary>
        public int? DefaultFileTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte System { get; set; }
        public string DefaultStorageLocation { get; set; }

        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
    }
}
