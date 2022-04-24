using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class HrmsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HrmsDB;Trusted_Connection=true");
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobList> JobLists { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<PanelStaff> PanelStaffs { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
