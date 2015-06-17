using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Structural_Programming
{
    public class _04NestedIf
    {
        public void NestedIfFlow()
        {
            int number = 5;

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Input is even number");
                }
                else
                {
                    Console.WriteLine("Input is odd number");
                }
            }
            else
            {
                Console.WriteLine("Not a positive number");
            }
        }

        public void NestedIfWithoutBraces()
        {
            int number = 4;

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
