using efModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efContext
{
    public class Context : DbContext, IContext
    {
        public Context()
            : base("name=efmain")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ComputerMeta());
            modelBuilder.Configurations.Add(new PrinterMeta());
        }

        public DbSet<Computer> Computer {get; set;}
        public DbSet<Printer> Printer { get; set; }
    }
}
