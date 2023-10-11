using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    internal class QuickSort : Algorithm
    {

        //метод для обмена элементов массива
        static void Swap(ref long x, ref long y)
        {
            var t = x;
            x = y;
            y = t;
        }

        //метод возвращающий индекс опорного элемента
        static int Partition(long[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        public static long[] QuickSortAlg(long[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSortAlg(array, minIndex, pivotIndex - 1);
            QuickSortAlg(array, pivotIndex + 1, maxIndex);
            return array;
        }
        protected override void DoAlg(long[] vector)
        {
            QuickSortAlg(vector, 0, vector.Length - 1);
        }
    }

}
