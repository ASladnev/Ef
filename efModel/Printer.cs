using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efModel
{
    public class Printer
    {
        public string PrinterId { get; set; }
        public string Vendor { get; set; }
        public int Counter { get; set; }
        public virtual List<Computer> Computer { get; set; }
    }

}
