using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVCContactBook.Models
{
    public class OurDbContext:DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}