using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    internal class Alg3 : Algorithm
    {
        protected override void DoAlg(long[] vector)
        {
            long composition = 0;
            for (int i = 0; i < vector.Length; i++)
                composition *= vector[i];
        }
    }
}
