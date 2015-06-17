using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Structural_Programming
{
    public class AppleCountChecker
    {

        public void WhoHasMoreApples()
        {

            int applesGivenByAnoop = 6; 

            int applesGivenByVimal;  

            applesGivenByVimal = 10; 


            //Explain about if and greater than operator
            if (applesGivenByAnoop > applesGivenByVimal)
            {
                Console.WriteLine("Anoop has more apples");
            }
        }
    }
}
