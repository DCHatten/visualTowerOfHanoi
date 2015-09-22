using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    /// <summary>
    /// Shows use of recursion to solve factorials.
    /// </summary>
    class Factorial
    {
        /// <summary>
        /// Calculates the factorial of the given number.
        /// </summary>
        /// <param name="number">The factorial to calculate.</param>
        /// <returns>The calculated factorial.</returns>
        public int Calculate(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * Calculate(number - 1);
        }
    }
}
