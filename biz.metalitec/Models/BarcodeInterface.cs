using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class BarcodeInterface
    {
        public int BarcodeInterfaceId { get; set; }
        /// <summary>
        /// Name of the Barcode Interface
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Barcode Interface
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The path that the imported file is to be archived to
        /// </summary>
        public string ArchiveFilePath { get; set; }
        /// <summary>
        /// The extension of the file you wish to import
        /// </summary>
        public string FileExtention { get; set; }
        /// <summary>
        /// The path of the file you wish to import
        /// </summary>
        public string DefaultFilePath { get; set; }
        public string BarcodeSeperator { get; set; }
        public string MappingEmployee { get; set; }
        public string MappingBarcode { get; set; }
        public string MappingDateTime { get; set; }
        public string Script { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte System { get; set; }
        public string MappingProcess { get; set; }
        public string MappingContract { get; set; }
        /// <summary>
        /// ~~1=Production Type, 2=Mark Type, 3=Inventory Type
        /// </summary>
        public byte InterfaceTypeId { get; set; }
        public string MappingArea { get; set; }
        public string MappingItemLocation { get; set; }
        public string MappingLength { get; set; }
        public string MappingWidth { get; set; }
    }
}
