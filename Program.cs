using AlgoritmLab1;
using AlgoritmLab1.algorithms;
using AlgoritmLab1.algorithms.templates;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static Stopwatch stopwatch = new Stopwatch();
    public static void Main()
    {
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("** Нажмите номер соответствующий алгоритму который вы хотите выполнить: **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 1. Постоянная функция                                                **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 2. Сумма элементов                                                   **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 3. Произведение элементов                                            **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 4. Метод Горнера                                                     **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 5. Bubblesort                                                        **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 6. Quicksort                                                         **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 7. Timsort                                                           **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 8. Степень                                                           **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 9. Произведение матриц                                               **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 10. Stoogesort                                                       **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 11. НЕсорт бого                                                      **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");
        startInput:
        Console.WriteLine("**                                                                      **");
        Console.Write("** Ваш выбор: ");
        bool success = float.TryParse(Console.ReadLine(), out float algSwitch);
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");
        if(!success)
        {
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("** Вы ничего не ввели или ввели букву. Попробуйте снова.                **");
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("**************************************************************************");
            goto startInput;
        }
        else if (algSwitch > 11 || algSwitch < 1)//менять если больше алг
        {
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("** Вы ввели несуществующий номер. Попробуйте снова.                     **");
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("**************************************************************************");
            goto startInput;
        }
        Algorithm algChosen = new();
        switch (algSwitch)
        {
            case 1://alg1
                algChosen = new Alg1();
                break;
            case 2://alg2
                algChosen = new Alg2();
                break;
            case 3://alg3
                algChosen = new Alg3();
                break;
            case 4://horner
                algChosen = new Horner();
                break;
            case 5://bubble
                algChosen = new BubbleSort();
                break;
            case 6://quick
                algChosen = new QuickSort();
                break;
            case 7://tim
                algChosen = new TimSort();
                break;
            case 8://pow
                   //algChosen = new Alg1();
                break;
            case 9://matrix
                algChosen = new MatrixMultiplication();
                break;
            case 10://stooge
                algChosen = new StoogeSort();
                break;
            case 11://bogo
                    //algChosen = new Alg1();
                break;
        }
        //
        int n = Convert.ToInt32(Console.ReadLine());
        //
        int sHowManyTests = Convert.ToInt32(Console.ReadLine());
        //
        double[,] timeVector = new double[sHowManyTests, n];
        for (int howManyTests = sHowManyTests; howManyTests != 0; howManyTests--)
        {
            for (int vectorSize = 1; vectorSize <= n; vectorSize++)
            {
                timeVector[howManyTests-1,vectorSize-1] = algChosen.Start(vectorSize);
            }
        }

        for (int howManyTests = sHowManyTests; howManyTests != 0; howManyTests--)
        {
            for (int vectorSize = 1; vectorSize <= n; vectorSize++)
            {
                Console.WriteLine(timeVector[howManyTests - 1, vectorSize - 1]);
            }
        }

        double[] timeApprox = new double[n];
        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int iterHMT = 0; iterHMT < sHowManyTests; iterHMT++)
            {
                sum += timeVector[iterHMT, i];
            }
            timeApprox[i] = sum / sHowManyTests;
        }
        //StreamWriter sw = new StreamWriter("test.txt");
        foreach (double i in timeApprox)
        {
            Console.WriteLine(i);
            //sw.WriteLine(i);
        }
        //sw.Close();
        //System.Diagnostics.Process.Start("aboba.txt"); //ПРОВЕРИТЬ ЭТУ ШТУКУ ЭТО ОТКРЫТИЕ ФАЙЛА В БЛОКНОТЕ
    }
}
