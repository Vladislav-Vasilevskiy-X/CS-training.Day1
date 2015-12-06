using System;
using static System.Console;
using NEvaluation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Runner
    {
        static void Main(string[] args)
        {
            MainLoop();
        }

        private static void MainLoop()
        {
            double number, accuracy = 0, power = 0;

            while (true)
            {
                WriteLine("Please, enter a number.");
                string answer = ReadLine();

                if (!Double.TryParse(answer, out number))
                {
                    WriteLine("Incorrect number. Try again.");
                }
                else
                {
                    GetAccuracyNumberFromConsole(ref accuracy);
                    GetPowerNumberFromConsole(ref power);
                    CompareResults(Calculation.Evaluate(number, power, accuracy), number, power);
                    break;
                }
            }
        }

        private static void GetAccuracyNumberFromConsole(ref double accuracy)
        {
            while (true)
            {
                Clear();
                WriteLine("Please, enter an accuracy.");
                string answer = ReadLine();

                if (!Double.TryParse(answer, out accuracy) && accuracy > 0)
                { 
                    WriteLine("Incorrect number. Try again.");
                }
                else break;
            }
        }

        private static void GetPowerNumberFromConsole(ref double power)
        {
            while (true)
            {
                Clear();
                WriteLine("Please, enter a power.");
                string answer = ReadLine();

                if (!Double.TryParse(answer, out power))
                {
                    WriteLine("Incorrect number. Try again.");
                }
                else break;
            }
        }

        private static void CompareResults(double evaluationResult, double number, double power)
        {
            WriteLine("Result of evaluation by Newton's method: " + evaluationResult);
            WriteLine("Result of evaluation by Math.Pow method: " + Math.Pow(number, 1/power));
        }
    }
}
