using efContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efRepository
{
    public class Repository : IRepository
    {
        private IContext _context;
        public Repository (IContext context)
        {
            _context = context;
        }

        public efModel.Computer getComputerById(string computerId)
        {
            throw new NotImplementedException();
        }
    }
}
