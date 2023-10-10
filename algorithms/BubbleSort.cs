using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    internal class BubbleSort : Algorithm
    {
        protected override void DoAlg(long[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
                for (int j = i + 1; j < vector.Length; j++)
                    if (vector[i] > vector[j])
                        (vector[i], vector[j]) = (vector[j], vector[i]);
        }
    }
}
