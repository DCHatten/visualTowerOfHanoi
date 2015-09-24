using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">Main-line args.</param>
        static void Main(string[] args)
        {
			// Factorial Section.
            Factorial factorial = new Factorial();

            Console.WriteLine("Input a number to calculate the factorial of: " + "     " + "Note: Must be 30 or lower.");

            try
            {
                int factorialInt = Convert.ToInt32(Console.ReadLine().Trim());

                if (factorialInt < 31)
                {
                    Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");
                    int answerInt = factorial.Calculate(factorialInt);

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
			
			// Tower Section.
            HanoiTower hanoi = new HanoiTower(3);
        }
    }
}
