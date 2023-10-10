using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms.templates
{
    internal class PowAlg : Algorithm
    {
        protected static long c = 0;
        protected static long k = 0;
        protected static long f = 0;
        protected static double count = 0;
        public override double Start(int n)
        {
            DoAlg((long)GetInput.numberInput(), (long)n);
            return count;
        }
        protected virtual long DoAlg(long x, long n) { return 0; }
    }
}