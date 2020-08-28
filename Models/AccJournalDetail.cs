using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace ERP.Models
{
    public  class AccJournalDetail
    {
        
        public int JdetailId { get; set; }
        public int JournalId { get; set; }
        public int AccountId { get; set; }
        [Display(Name ="مدين")]
        public decimal? Debit { get; set; }
        [Display(Name ="دائن")]
        public decimal? Credit { get; set; }
        [Display(Name ="الرصيد")]
        public string Notes { get; set; }
        public int? CostCenter { get; set; }
        [Display(Name ="التاريخ")]
        public DateTime? DueDate { get; set; }
        public int CrncId { get; set; }
        public decimal CrncRate { get; set; }
        //public AccAccount AccAccount { get; set; }
        //public AccJournal AccJournal { get; set; }
      
    }
}
