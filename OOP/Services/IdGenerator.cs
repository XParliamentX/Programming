using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace OOP.Sevices
{
    public class IdGenerator
    {
        private static int _nextId = 0;

        public int GetNextId()
        {
            return Interlocked.Increment(ref _nextId);
        }
    }

}
