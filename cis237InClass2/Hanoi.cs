using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Hanoi
    {
        public void moveDisk(int n, char source, char auxilary, char destination)
        {
            // Base Case to exit recursive loop.
            if (n == 1)
            {
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                // Attempt to move (n-1) from source location to auxilary location, using destination as temp.
                moveDisk(n - 1, source, destination, auxilary);
                // Move source to destination.
                moveDisk(1, source, auxilary, destination);
                // Attempt to move (n-1) from auxilary location to destination location, using source as temp.
                moveDisk(n-1, auxilary, source, destination);
            }
        }
    }
}
