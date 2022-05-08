using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<GloboTicketDbContext>
    {
        public GloboTicketDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GloboTicketDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GloboTicketTicketManagementDb;Trusted_Connection=True;");

            return new GloboTicketDbContext(optionsBuilder.Options);
        }
    }
}
