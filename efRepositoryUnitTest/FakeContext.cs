using efContext;
using efModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace efRepositoryUnitTest
{
    internal class FakeContext : IContext
    {
        public DbSet<Computer> Computer { get; set; }
        public DbSet<Printer> Printer { get; set; }

    }
}
