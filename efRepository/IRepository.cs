using efModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efRepository
{
    public interface IRepository
    {
        Computer getComputerById(string computerId);
    }
}
