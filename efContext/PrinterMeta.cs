using efModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efContext
{
    public class PrinterMeta : EntityTypeConfiguration<Printer>
    {
        public PrinterMeta()
        {
            Property(p => p.PrinterId).HasMaxLength(10).HasColumnType("varchar");
            Property(p => p.Vendor).HasMaxLength(20).HasColumnType("varchar");
        }
    }
}
