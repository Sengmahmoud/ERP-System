using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Interfaces
{
   public interface IAccount
    {
     IEnumerable<AccAccount> GetAccAccounts();
        IEnumerable<AccJournalDetail> getDetailts(int accountid, DateTime fromdate , DateTime todate);

        IEnumerable<AccAccount> GetAccAccount(int id);
    }
}
