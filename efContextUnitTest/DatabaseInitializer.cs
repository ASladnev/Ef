using efContext;
using efModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efContextUnitTest
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges <Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);

            var printers = new List<Printer> {
                new Printer {PrinterId = "P1"},
                new Printer {PrinterId = "P2"},
                new Printer {PrinterId = "P3"},
            };

            printers.ForEach(p => context.Printer.Add(p));

            var computers = new List<Computer> {
                new Computer {ComputerId = "C1", Number = "1"},
                new Computer {ComputerId = "C2", Number = "2"},
            };

            computers.ForEach(c => context.Computer.Add(c));
        }
    }
}
