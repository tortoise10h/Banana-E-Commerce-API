using System;

namespace Banana_E_Commerce_API.Entities
{
    public class ImportProductReport
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime NextImportTime { get; set; }
        public string ReportImageLocation { get; set; }
        public int CreatedBy { get; set; }
        public int RequestImportProductId { get; set; }

        public StorageManager StorageManager { get; set; }
        public RequestImportProduct RequestImportProduct { get; set; }
    }
}