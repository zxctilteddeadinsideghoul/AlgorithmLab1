using AlgoritmLab1.algorithms.templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms
{
    internal class CombSort : Algorithm
    {
        protected override void DoAlg(long[] vector)
        {
            int toFixGap = vector.Length;
            for (int gap = Convert.ToInt32(vector.Length / 1.2473309d); gap > 1; gap = Convert.ToInt32(Math.Round(gap / 1.2473309d)))
            {
                //чтобы gap не повторялся
                if (toFixGap == gap)
                    gap--;
                toFixGap = gap;
                //
                for (int poVec = 0, gapPoVec = gap; (poVec+gap)<vector.Length;poVec++,gapPoVec++)
                    if (vector[poVec] > vector[gapPoVec])
                        (vector[poVec], vector[gapPoVec]) = (vector[gapPoVec], vector[poVec]);
            }
        }
    }
}