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

        public async Task OnGetAsync()
        {
            Account = await _context.Account.ToListAsync();
        }
    }
}
