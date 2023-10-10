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
        public static Stopwatch stopwatch = new Stopwatch();
        public virtual double Start(int n)
        {
            long[] vector = GetInput.VectorInput(n);
            Timer.StartTimer();
            DoAlg(vector);
            return Timer.StopTimer();
        }
        protected virtual void DoAlg(long[] vector) { }
        protected virtual void DoAlg(long[,] matrixA, long[,] matrixB) { }
    }
}
