using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class RecPow : PowAlg
    {
        protected override long DoAlg(long x, long n)
        {
            if(n == 0)
            {
                f = 1;
                count += 3;
                return f;
            }
            count++;
            f = DoAlg(x, n / 2);
            if ((n%2)==1)
            {
                f = f * f * x;
            }
            else
            {
                f *= f;
            }
            count += 5;
            return f;
        }
    }
}
