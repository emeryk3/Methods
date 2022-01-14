using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {

        // We first make our method and call it myname and then in static void main the method myname is called. This is a simple method there is no return type or any arguments to pass.

        /*
        static void Main(string[] args)
        {
            myname();
        }
        static void myname()
        {
           Console.WriteLine("Hello World!");
           Console.ReadLine();
        }
        */

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter product cost: ");
            string pC = Console.ReadLine();

            Console.WriteLine("Now enter current VAT rate: ");
            string cR = Console.ReadLine();

            var result = VAT(Convert.ToDouble(pC), Convert.ToDouble(cR));

            Console.WriteLine("Total cost is {0:C}", result);
            Console.ReadLine();
            */

            Games(new[] { "GTA 5", "BF4", "Fifa", "Uncharted" });
            Console.ReadLine();
        }

        // Passing Parameters

        static double VAT(double productCost, double currentRate)
        {
            double CR = (currentRate + 100) / 100;
            return productCost * CR;
        }

        /// <summary>
        /// Prints Out a list of Games
        /// </summary>
        /// <param name="newGames">Specify an array of games</param>
        static void Games(string[] newGames)
        {
            foreach (var g in newGames)
            {
                Console.WriteLine(g);
            }
        }

        static void Games(string newGames)
        {
            Console.WriteLine(newGames);
        }


    }
}
