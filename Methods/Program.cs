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
        static void Main(string[] args)
        {
            myname();
        }

        static void myname()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

    }
}
