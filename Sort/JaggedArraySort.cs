using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class JaggedArraySort
    {

        public static void AcdesndingSortBySumsOfRowElements(double[][] array, int arraysNumber)
        {
            double[] sums = GetArrayOfRowElemetsSum(array, arraysNumber);
            AcsendingSortByKeys(array, arraysNumber, sums);
        }

        public static void AcdesndingSortByMaxRowElement(double[][] array, int arraysNumber)
        {
            double[] maxElements = GetArrayOfMaxRowsElements(array, arraysNumber);
            AcsendingSortByKeys(array, arraysNumber, maxElements);
        }

        public static void AcdesndingSortByMinRowElement(double[][] array, int arraysNumber)
        {
            double[] minElements = GetArrayOfMinRowsElements(array, arraysNumber);
            AcsendingSortByKeys(array, arraysNumber, minElements);
        }

        private static double[] GetArrayOfRowElemetsSum(double[][] array, int arraysNumber)
        {
            double[] rowElementsSumArray = new double[arraysNumber];
            for (int arrayIterator = 0; arrayIterator < arraysNumber; arrayIterator++)
            {
                for (int i = 0; i < array[arrayIterator].Count(); i++)
                {
                    rowElementsSumArray[arrayIterator] += array[arrayIterator][i];
                }
            }
            return rowElementsSumArray;
        }

        private static double[] GetArrayOfMaxRowsElements(double[][] array, int arraysNumber)
        {
            double[] maxRowsElementsArray = new double[arraysNumber];
            for (int arrayIterator = 0; arrayIterator < arraysNumber; arrayIterator++)
            {
                double maxElement = double.MinValue;
                for (int i = 0; i < array[arrayIterator].Count(); i++)
                {
                    if (array[arrayIterator][i] > maxElement) maxElement = array[arrayIterator][i];
                }
                maxRowsElementsArray[arrayIterator] = maxElement;
            }
            return maxRowsElementsArray;
        }

        private static double[] GetArrayOfMinRowsElements(double[][] array, int arraysNumber)
        {
            double[] minRowsElementsArray = new double[arraysNumber];
            for (int arrayIterator = 0; arrayIterator < arraysNumber; arrayIterator++)
            {
                double minElement = double.MaxValue;
                for (int i = 0; i < array[arrayIterator].Count(); i++)
                {
                    if (array[arrayIterator][i] < minElement) minElement = array[arrayIterator][i];
                }
                minRowsElementsArray[arrayIterator] = minElement;
            }
            return minRowsElementsArray;
        }

        private static void AcsendingSortByKeys(double[][] array, int arraysNumber, double[] keys)
        {
            bool swapped = true;
            int n = arraysNumber;

            while (swapped)
            {
                swapped = false;
                for (int i = 1; i <= n - 1; i++)
                    if (keys[i - 1] > keys[i])
                    {
                        Swap(i - 1, i, array, keys);
                        swapped = true;
                    }
                n--;
            }
        }
        
        private static void Swap(int index1, int index2, double[][] array, double[] keys)
        {
            double[] tempArray = array[index1];
            double tmp = keys[index1];

            array[index1] = array[index2];
            keys[index1] = keys[index2];

            array[index2] = tempArray;
            keys[index2] = tmp;
        }
    }
}
