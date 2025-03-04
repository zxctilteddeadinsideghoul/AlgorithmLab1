﻿using AlgoritmLab1.algorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1.algorithms.templates
{
    internal abstract class Algorithm : Testing
    {
        static Random rand = new Random();

        protected override object GetData(uint n)
        {

            uint[] vector = new uint[n];
            for (uint i = 0; i < vector.Length; i++)
                vector[i] = (uint)rand.Next();
            return vector;
        }
    }
}
