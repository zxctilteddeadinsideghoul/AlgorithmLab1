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
            return rand.Next(0, 50000);
        }
        public static long[] VectorInput(int n)
        {
            
            long[] vector = new long[n]; //массив подопытный
            for (int i = 0; i < vector.Length; i++)//заполнение подопытного
                vector[i] = rand.Next(0, 50000);
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
