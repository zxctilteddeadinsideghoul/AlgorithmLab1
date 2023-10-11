using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    internal class QuickPow : PowAlg
    {


        protected override long DoAlg(long x, long n)
        {
            c = x;
            k = n;
            count += 2;
            if (k % 2 == 1)
                f = c;
            else
                f = 1;
            count += 2;
            do
            {
                k /= 2;
                c *= c;
                if ((k /= 2) == 1)
                {
                    f *= c;
                    count++;
                }
                count += 4;
            } while (k != 0);
            return f;
        }
    }
}
