using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class QuickPow2 : PowAlg
    {
        protected override long DoAlg(long x, long n)
        {
            c = x;
            f = 1;
            k = n;
            count += 3;
            while (k!=0)
            {
                if((k%2)==0)
                {
                    c *= c;
                    k %= 2;
                }
                else
                {
                    f *= c;
                    k--;
                }
                count += 4;
            }
            count += 2;
            return f;
        }
    }
}
