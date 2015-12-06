using System;
using static System.Console;
using Sort;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    class Runner
    {
        static void Main(string[] args)
        {
            MainLoop();
        }

        private static void MainLoop()
        {
            int arraysNumber = 0, numberOfElements = 0;
            GetArraysNumberFromConsole(ref arraysNumber);
            double[][] array = new double[arraysNumber][];

            for (int i = 0; i < arraysNumber; i++)
            {
                GetNumberOfElementsFromConsole(ref numberOfElements, i + 1);
                array[i] = new double[numberOfElements];
            }

            GetValueForArrayFromConsole(ref array, arraysNumber);
            Clear();
            WriteLine("Jagged array before sorts:");
            PrintArray(array, arraysNumber);

            JaggedArraySort.AcdesndingSortBySumsOfRowElements(array, arraysNumber);
            WriteLine("Jagged array after sort by sum of row's elements:");
            PrintArray(array, arraysNumber);

            JaggedArraySort.AcdesndingSortByMaxRowElement(array, arraysNumber);
            WriteLine("Jagged array after sort by max element in a row:");
            PrintArray(array, arraysNumber);

            JaggedArraySort.AcdesndingSortByMinRowElement(array, arraysNumber);
            WriteLine("Jagged array after sort by min element in a row:");
            PrintArray(array, arraysNumber);
        }

        private static void GetArraysNumberFromConsole(ref int arraysNumber)
        {
            while (true)
            {
                WriteLine("Please, enter a number of arrays.");
                string answer = ReadLine();

                if (!Int32.TryParse(answer, out arraysNumber))
                {
                    WriteLine("Incorrect number. Try again.");
                }
                else break;
            }
        }

        private static void GetNumberOfElementsFromConsole(ref int elementsNumber, int arrayNumber)
        {
            while (true)
            {
                WriteLine("Please, enter a number of elemnts for array" + arrayNumber);
                string answer = ReadLine();

                if (!Int32.TryParse(answer, out elementsNumber))
                {
                    WriteLine("Incorrect number. Try again.");
                }
                else break;
            }
        }

        private static void GetValueForArrayFromConsole(ref double[][] array, int arraysNumber)
        {
            for (int arraysIterator = 0; arraysIterator < arraysNumber; arraysIterator++)
            {
                for (int i = 0; i < array[arraysIterator].Count(); i++)
                {
                    while (true)
                    {
                        WriteLine("Please, type value for [" + arraysIterator + "][" + i + "]");
                        string answer = ReadLine();

                        if (!Double.TryParse(answer, out array[arraysIterator][i]))
                        {
                            WriteLine("Incorrect number. Try again.");
                        }
                        else break;
                    }
                }
            }
        }
        
        private static void PrintArray(double[][] array, int arraysNumber)
        {
            for (int arraysIterator = 0; arraysIterator < arraysNumber; arraysIterator++)
            {
                for (int i = 0; i < array[arraysIterator].Count(); i++)
                {
                    Write(array[arraysIterator][i] + " ");
                }
                Write("\n");
            }
        }
    }
}
