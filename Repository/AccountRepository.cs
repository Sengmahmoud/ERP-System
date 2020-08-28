using ERP.Interfaces;
using ERP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Repository
{
    public class AccountRepository : IAccount
    {
        private readonly ERPContext _context;

        public AccountRepository(ERPContext context)
        {
            _context = context;
        }

        public  IEnumerable<AccAccount> GetAccAccount(int id)
        {
            var account = _context.AccAccount.Where(a=>a.AccountId==id);
            return account;
        }

        IEnumerable<AccAccount> IAccount.GetAccAccounts()
        {

            return _context.AccAccount.ToList();
        }

        IEnumerable<AccJournalDetail> IAccount.getDetailts(int accountid , DateTime fromdate , DateTime todate)
        {
            //var details = _context.AccJournalDetail.Include(d => d.AccAccount).Include(d => d.AccJournal)
            //    .Where(d => d.AccountId == accountid && d.AccJournal.InsertDate >= fromdate && d.AccJournal.InsertDate <= todate).ToList();

            List<AccJournalDetail> details = new List<AccJournalDetail>();
            var Account = _context.AccAccount.Find(accountid);
            var jornal = _context.AccJournal.Where(j => j.InsertDate >= fromdate && j.InsertDate <= todate).ToList();
            if (jornal != null)
            {
                foreach (var item in jornal)
                {
                    var items = _context.AccJournalDetail
                         .Where(d => d.AccountId == Account.AccountId
                         && d.JournalId == item.JournalId);
                    
                    details.AddRange(items);
                }

            }
            return details;

            //.Where(d => d.DueDate >= fromdate)
            //.Where(d => d.DueDate <= todate).ToList();

        }
    }
}
