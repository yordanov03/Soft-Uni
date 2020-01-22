using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluffy_Duffy_Munchkin_Cats.Data
{
    public class CatsDBContext : DbContext
    {
        public CatsDBContext(DbContextOptions<CatsDBContext> options):base(options)
        {

        }
        public DbSet<Cat> cats { get; set; }
        

    }
}
