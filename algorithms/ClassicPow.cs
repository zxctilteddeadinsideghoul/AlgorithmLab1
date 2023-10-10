using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class ClassicPow : PowAlg
    {
        protected override long DoAlg(long x, long n)
        {
            f = 1;
            k = 0;
            count += 3;
            while (k < n)
            {
                f *= x;
                k++;
                count += 3;
            }
            return f;
        }
    }
}
