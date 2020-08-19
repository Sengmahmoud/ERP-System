using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class AccJournal
    {
        public int JournalId { get; set; }
        public int Jcode { get; set; }
        public string Jnotes { get; set; }
        public int ProcessId { get; set; }
        public int SourceId { get; set; }
        public int InsertUser { get; set; }
        public DateTime InsertDate { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public bool IsPosted { get; set; }
        public int? StoreId { get; set; }
        public int CrncId { get; set; }
        public decimal CrncRate { get; set; }
        public string Jnumber { get; set; }
        public int? BookId { get; set; }
    }
}
