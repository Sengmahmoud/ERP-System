using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.ViewModels
{
    public class AccountViewModel
    {
        public IEnumerable<AccAccount> Accounts { get; set; }
        public AccAccount Account { get; set; }
        public IEnumerable<AccJournalDetail> AccJournalDetails { get; set; }
        public AccJournal AccJournal { get; set; }
        
    }
}
