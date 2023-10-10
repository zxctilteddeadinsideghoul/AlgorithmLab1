using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using AlgoritmLab1.algorithms.templates;

namespace AlgoritmLab1.algorithms
{
    class MatrixMultiplication : Algorithm
    {
        protected override void DoAlg(long[,] matrixOne, long[,] matrixTwo)
        {
            long[,] outMatrix = new long[matrixTwo.GetLength(0), matrixOne.GetLength(1)];
            for (int outMatrixRank = 0; outMatrixRank < matrixOne.GetLength(1); outMatrixRank++)
            {
                for (int outMatrixLength = 0; outMatrixLength < matrixTwo.GetLength(0); outMatrixLength++)
                {
                    for (int fillerOne = 0; fillerOne < matrixOne.GetLength(0); fillerOne++)
                    {
                        outMatrix[outMatrixLength, outMatrixRank] = outMatrix[outMatrixLength, outMatrixRank] + matrixOne[fillerOne, outMatrixRank] * matrixTwo[outMatrixLength, fillerOne];
                    }
                }
            }
        }
        public override double Start(int n)
        {
            long[,] matrixA = GetInput.MatrixInput(n);
            long[,] matrixB = GetInput.MatrixInput(n);
            Timer.StartTimer();
            DoAlg(matrixA, matrixB);
            return Timer.StopTimer();
        }
    }
}
