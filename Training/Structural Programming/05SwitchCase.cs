using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Structural_Programming
{
    public class _05SwitchCase
    {
        public void DoSwitch()
        {
            int val = 10;
            switch (val)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
            }
        }

        public void DoSwitchWithDefault()
        {
            int val = 10;
            switch (val)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("I am not one two or three");
                    break;
            }
        }

        public void DoSwitchWithDefaultTop()
        {
            int val = 10;
            switch (val)
            {
                default:
                    Console.WriteLine("I am not one two or three");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
               
            }
        }
    }
}
