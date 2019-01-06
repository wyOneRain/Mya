using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mya.Models;

namespace Mya.Data
{
    public class MyaDbContext: DbContext
    {
        public MyaDbContext(DbContextOptions<MyaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mya.Models.Account> Account { get; set; }
    }
}
