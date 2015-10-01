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
        /// Constructor which calculates factorials.
        /// </summary>
        public Factorial()
        {
            Console.WriteLine("Input a number to calculate the factorial of: " + "     " + "Note: Must be 30 or lower.");

            try
            {
                int factorialInt = Convert.ToInt32(Console.ReadLine().Trim());

                if (factorialInt < 31)
                {
                    Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");
                    int answerInt = Calculate(factorialInt);

                    Console.WriteLine(Environment.NewLine + "The answer is: " + answerInt + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "You must enter a number 30 or lower." + Environment.NewLine);
                }
            }
            catch
            {
                Console.WriteLine(Environment.NewLine + "You must enter a number 30 or lower." + Environment.NewLine);
            }
        }

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
