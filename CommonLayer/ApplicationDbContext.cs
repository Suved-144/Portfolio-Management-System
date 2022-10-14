using Authentication_System.Model;
using Microsoft.EntityFrameworkCore;
using PortFolio_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<StocksDetails> StokesDetail { get; set; }
        

    }
}
