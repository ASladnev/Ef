using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efModel
{
    public class Computer
    {


        public string ComputerId { get; set; }
        public string Vendor { get; set; }
        public string Number { get; set; }
        public virtual List<Printer> Printer { get; set; }
    }

}
