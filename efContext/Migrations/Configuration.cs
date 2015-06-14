namespace efContext.Migrations
{
    using efModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<efContext.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(efContext.Context context)
        {
            var Computers = new List<Computer> {
                new Computer { ComputerId = "C01", Number = "01" }
                , new Computer { ComputerId = "C02", Number = "02", Printer = new List<Printer> () }
                , new Computer { ComputerId = "C03", Number = "03", Printer = new List<Printer> ()  }
                , new Computer { ComputerId = "C04", Number = "04" }
                , new Computer { ComputerId = "C05", Number = "05" }
                , new Computer { ComputerId = "C06", Number = "06" }
            };


            var Printers = new List <Printer> {
                new Printer { PrinterId = "P01", Counter=100}
                , new Printer { PrinterId = "P02", Counter = 200 }
                ,new Printer { PrinterId = "P03", Counter=150}
            };

            Computers[1].Printer.Add(Printers[1]);
            Computers[1].Printer.Add(Printers[2]);
            Computers[2].Printer.Add(Printers[0]);
            Computers[2].Printer.Add(Printers[1]);

            Computers.ForEach(c => context.Computer.AddOrUpdate(c));
        }
    }
}
