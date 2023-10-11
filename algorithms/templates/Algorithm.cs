using AlgoritmLab1.algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms.templates
{
    internal class Algorithm
    { 
        public virtual double Start(int n)
        {
            long[] vector = GetInput.VectorInput(n);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DoAlg(vector);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks / 10000000.0d;
        }
        protected virtual void DoAlg(long[] vector) { }
        protected virtual void DoAlg(long[,] matrixA, long[,] matrixB) { }
    }
}
