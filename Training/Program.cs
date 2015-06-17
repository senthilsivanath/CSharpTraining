using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            if (number > 0)

                if (number % 2 == 0)
                    Console.WriteLine("Input is even number");
                else
                    Console.WriteLine("Input is odd number");


            else

                Console.WriteLine("Not a positive number");



        }
    }
}
