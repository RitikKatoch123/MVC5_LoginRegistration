using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5_LoginRegistration.Models
{
    public class Ourdbcontext: DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }

    }
}