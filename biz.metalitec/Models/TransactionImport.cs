using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TransactionImport
    {
        /// <summary>
        /// Unique ID for the transaction import
        /// </summary>
        public int TransactionImportId { get; set; }
        /// <summary>
        /// The transaction import type (e.g. 5=Purchase Order, 6=Roll Reference)
        /// </summary>
        public byte ImportTypeId { get; set; }
        /// <summary>
        /// The object ID to which the import refers
        /// </summary>
        public int ReferenceId { get; set; }
        /// <summary>
        /// The related object ID for the import
        /// </summary>
        public int? ReferenceId2 { get; set; }
        /// <summary>
        /// The name of the imported file
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// The transformed XML data of the imported file
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// Date the file was received
        /// </summary>
        public DateTime DateReceived { get; set; }
        /// <summary>
        /// Date the imported data was processed
        /// </summary>
        public DateTime? DateProcessed { get; set; }
    }
}
