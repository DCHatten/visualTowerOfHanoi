using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi hanoi = new Hanoi();

            hanoi.moveDisk(3, 'A', 'B', 'C');
        }
    }
}
