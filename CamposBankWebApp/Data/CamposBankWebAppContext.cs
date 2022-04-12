#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CamposBankWebApp.Models;

namespace CamposBankWebApp.Data
{
    public class CamposBankWebAppContext : DbContext
    {
        public CamposBankWebAppContext (DbContextOptions<CamposBankWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<CamposBankWebApp.Models.Account> Account { get; set; }
    }
}
