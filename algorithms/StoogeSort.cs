using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    internal class StoogeSort : Algorithm
    {
        public static long[] StoogeSortAlg(long[] array, int startIndex, int endIndex)
        {
            if (array[startIndex] > array[endIndex])
                (array[startIndex], array[endIndex]) = (array[endIndex], array[startIndex]);

            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSortAlg(array, startIndex, endIndex - len);
                StoogeSortAlg(array, startIndex + len, endIndex);
                StoogeSortAlg(array, startIndex, endIndex - len);
            }
            return array;


        }
        protected override void DoAlg(long[] vector)
        {
            StoogeSortAlg(vector, 0, vector.Length - 1);//returns array
        }
    }
}
