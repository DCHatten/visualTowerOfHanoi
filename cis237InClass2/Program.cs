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
        /// Main. Selects either factorials or hanoi.
        /// </summary>
        /// <param name="args">Main-line args.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for factorials or 2 for Tower of Hanoi.");
            string userInput = Console.ReadLine().Trim();
            Console.WriteLine();

            switch (userInput)
            {
                case "1":
                    Factorial factorial = new Factorial();
                    break;
                case "2":
                    Console.WriteLine("Enter number of disks on tower. For best output, try 5 or lower.");
                    userInput = Console.ReadLine().Trim();
                    try
                    {
                        HanoiTower hanoi = new HanoiTower(Convert.ToInt32(userInput));
                    }
                    catch
                    {
                        Console.WriteLine("You must enter an int. Try '3'.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        }
    }
}
