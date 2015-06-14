using efModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efContext
{

    public class ComputerMeta : EntityTypeConfiguration <Computer>
    {
        public ComputerMeta()
        {
            Property(p => p.ComputerId).HasMaxLength(20).HasColumnType("varchar");
            Property(p => p.Vendor).HasMaxLength(20).HasColumnType("varchar");
            Property(p => p.Number).HasMaxLength(10).HasColumnType("varchar").IsRequired ();
        }

    }
}
