using efModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efContext
{
    public interface IContext
    {
        DbSet<Computer> Computer { get; set; }
        DbSet<Printer> Printer { get; set; }
    }
}
