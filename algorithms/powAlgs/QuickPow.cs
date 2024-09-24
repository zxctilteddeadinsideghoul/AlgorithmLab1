using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms.powAlgs
{
    internal class QuickPow : PowAlg
    {
        protected override void DoAlg(object data)
        {
            uint[] d = (uint[])data;

            uint x = d[0];
            uint n = d[1];

            uint c = x;
            uint k = n;
            uint f;

            if (k % 2 == 1)
            {
                f = c;
            }
            else
            {
                f = 1;
            }
            while (true)
            {
                k = k / 2;
                c *= c;
                if (k % 2 == 1)
                {
                    f *= c;
                }

                if (k == 0)
                {
                    break;
                }


            }
            MessageBox.Show("!" + x.ToString());
            MessageBox.Show(n.ToString());
            MessageBox.Show(f.ToString());
        }
    }
}
