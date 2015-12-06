using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEvaluation
{
    public static class Calculation
    {
        public static double Evaluate(double number, double power, double accuracy)
        {
            double result = 1;

            while(true)
            {
                double currentValue = 1 / power * ((power - 1) * result + number / (Math.Pow(result, power - 1)));
                if (Math.Abs(result - currentValue) < accuracy) break;
                result = currentValue;
            }

            return result;
        } 
    }
}
