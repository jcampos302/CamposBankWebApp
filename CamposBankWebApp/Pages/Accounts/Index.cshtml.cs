#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CamposBankWebApp.Data;
using CamposBankWebApp.Models;

namespace CamposBankWebApp.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly CamposBankWebApp.Data.CamposBankWebAppContext _context;

        public IndexModel(CamposBankWebApp.Data.CamposBankWebAppContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; }
     
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public async Task OnGetAsync()
        {
            var accounts = from m in _context.Account
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                accounts = accounts.Where(s => s.AccountName.Contains(SearchString) 
                | s.FirstName.Contains(SearchString) | s.LastName.Contains(SearchString)
                | s.Nick.Contains(SearchString));

            }
            Account = await accounts.ToListAsync();
        }
    }
}
