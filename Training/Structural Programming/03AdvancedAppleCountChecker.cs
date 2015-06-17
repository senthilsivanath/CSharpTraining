using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Structural_Programming
{
    public class AdvancedAppleCountChecker
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
            else if (applesGivenByAnoop < applesGivenByVimal)
            {
                Console.WriteLine("Vimal has more apples");
            }
            else
            {
                Console.WriteLine("Both have same number of apples");
            }

            
        }
    }

    public class BMICalculator
    {
        public double calculateBMI(int heighInCentiMeters, int WeightInKg)
        {
            int heightInMeter = (heighInCentiMeters / 100);

            double bmi = WeightInKg / (heighInCentiMeters * heighInCentiMeters);

            return bmi;
        }


        public double calculateBMIAlternativwe(int heighInCentiMeters, int WeightInKg)
        {
            int heightInMeter = (heighInCentiMeters / 100);

            double bmi = WeightInKg / (Math.Pow(heighInCentiMeters, 2));

            return bmi;
        }
    }
}
