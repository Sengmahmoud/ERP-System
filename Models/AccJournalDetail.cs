using System;
using System.Collections.Generic;

namespace ERP.Models
{
    public partial class AccJournalDetail
    {
        public int JdetailId { get; set; }
        public int JournalId { get; set; }
        public int AccountId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Notes { get; set; }
        public int? CostCenter { get; set; }
        public DateTime? DueDate { get; set; }
        public int CrncId { get; set; }
        public decimal CrncRate { get; set; }
   
    }
}
