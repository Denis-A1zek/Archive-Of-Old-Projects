using Microsoft.EntityFrameworkCore;
using Sigida.PollingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.PollingSystem.Application
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base (options)
        {

        }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollAnswer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
