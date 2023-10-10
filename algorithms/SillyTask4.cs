using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class SillyTask4 : Algorithm
    {
        protected override void DoAlg(long[] vector)
        {
            double sum = 0;
            for (int i = vector.Length - 1; i > 0; i--)
                sum += 1.5 * Math.Pow(vector[i], i - 1);
        }
    }
}
