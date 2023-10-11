using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmLab1
{
    internal class GetInput
    {
        static Random rand = new Random();

        public static int numberInput()
        {
            return rand.Next();
        }
        public static long[] VectorInput(int n)
        {
            
            long[] vector = new long[n];
            for (int i = 0; i < vector.Length; i++)
                vector[i] = rand.Next();
            return vector;
        }
        public static long[,] MatrixInput(int n)
        {
            long[,] matrix = new long[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next();
                }
            }
            return matrix;
        }
    }
}
