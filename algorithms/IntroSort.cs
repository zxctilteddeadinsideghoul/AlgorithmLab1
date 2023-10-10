using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class IntroSort : Algorithm
    {
        protected override void DoAlg(long[] data)
        {
            int partitionSize = Partition(ref data, 0, data.Length - 1);

            if (partitionSize < 16)
            {
                InsertionSort(ref data);
            }
            else if (partitionSize > 2 * Math.Log(data.Length))
            {
                HeapSort(ref data);
            }
            else
            {
                QuickSortRecursive(ref data, 0, data.Length - 1);
            }
        }

        private static void InsertionSort(ref long[] data)
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int j = i;

                while (j > 0)
                {
                    if (data[j - 1] > data[j])
                    {
                        data[j - 1] ^= data[j];
                        data[j] ^= data[j - 1];
                        data[j - 1] ^= data[j];

                        --j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void HeapSort(ref long[] data)
        {
            int heapSize = data.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(ref data, heapSize, p);

            for (int i = data.Length - 1; i > 0; --i)
            {
                long temp = data[i];
                data[i] = data[0];
                data[0] = temp;

                --heapSize;
                MaxHeapify(ref data, heapSize, 0);
            }
        }

        private static void MaxHeapify(ref long[] data, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && data[left] > data[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && data[right] > data[largest])
                largest = right;

            if (largest != index)
            {
                long temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                MaxHeapify(ref data, heapSize, largest);
            }
        }

        private static void QuickSortRecursive(ref long[] data, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(ref data, left, right);
                QuickSortRecursive(ref data, left, q - 1);
                QuickSortRecursive(ref data, q + 1, right);
            }
        }

        private static int Partition(ref long[] data, int left, int right)
        {
            long pivot = data[right];
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (data[j] <= pivot)
                {
                    (data[j], data[i]) = (data[i], data[j]);
                    i++;
                }
            }

            data[right] = data[i];
            data[i] = pivot;

            return i;
        }

    }
}
