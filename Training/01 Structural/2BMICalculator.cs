using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training._01_Structural
{
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
