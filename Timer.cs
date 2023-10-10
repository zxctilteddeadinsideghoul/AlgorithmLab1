using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1
{
    public static class Timer
    {
        
        public static void StartTimer() 
        {
            Algorithm.stopwatch.Start();
        }
        public static double StopTimer()
        {
            Algorithm.stopwatch.Stop();
            return Algorithm.stopwatch.ElapsedTicks / 10000000.0d;
        }
    }
}