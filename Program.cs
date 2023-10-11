using AlgoritmLab1;
using AlgoritmLab1.algorithms;
using AlgoritmLab1.algorithms.templates;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        startInput:
        Console.SetWindowSize(74, 45);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("** Нажмите номер соответствующий алгоритму который вы хотите выполнить: **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 1. Постоянная функция                                                **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 2. Сумма элементов                                                   **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 3. Произведение элементов                                            **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 4.1 Метод Горнера                                                    **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 4.2 Решение задачи 4 прямым вычислением                              **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 5. Bubblesort                                                        **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 6. Quicksort                                                         **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 7. Timsort                                                           **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 8.1 Классический алгоритм возведения в степень                       **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 8.2 Алгоритм возведения в степень с помощью рекурсии                 **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 8.3 Быстрый алгоритм возведения в степень                            **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 8.4 Классический быстрый алгоритм возведения в степень               **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 9. Произведение матриц                                               **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 10. Stoogesort                                                       **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 11. Introsort                                                        **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("** 12. Combsort                                                         **");
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");
        
        Console.WriteLine("**                                                                      **");
        Console.Write("** Ваш выбор: ");
        bool success = float.TryParse(Console.ReadLine(), out float algSwitch);
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");
        Console.Clear();
        if (!success)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("** Вы ничего не ввели или ввели букву. Попробуйте снова.                **");
            Console.WriteLine("**                                                                      **");
            Console.WriteLine("**************************************************************************");
            goto startInput;
        }
        Console.Clear();
        Console.SetWindowSize(74, 11);
        Console.WriteLine("**************************************************************************");
        Algorithm algChosen = new();
        switch (algSwitch)
        {
            case 1://alg1
                algChosen = new Alg1();
                Console.WriteLine("** 1. Постоянная функция                                                **");
                break;
            case 2://alg2
                algChosen = new Alg2();
                Console.WriteLine("** 2. Сумма элементов                                                   **");
                break;
            case 3://alg3
                algChosen = new Alg3();
                Console.WriteLine("** 3. Произведение элементов                                            **");
                break;
            case 4.1f://horner
                algChosen = new Horner();
                Console.WriteLine("** 4,1. Метод Горнера                                                    **");
                break;
            case 4.2f://silly4
                algChosen = new SillyTask4();
                Console.WriteLine("** 4,2. Решение задачи 4 прямым вычислением                              **");
                break;
            case 5://bubble
                algChosen = new BubbleSort();
                Console.WriteLine("** 5. Bubblesort                                                        **");
                break;
            case 6://quick
                algChosen = new QuickSort();
                Console.WriteLine("** 6. Quicksort                                                         **");
                break;
            case 7://tim
                algChosen = new TimSort();
                Console.WriteLine("** 7. Timsort                                                           **");
                break;
            case 8.1f://pow
                   algChosen = new ClassicPow();
                Console.WriteLine("** 8,1. Классический алгоритм возведения в степень                       **");
                break;
            case 8.2f://pow
                algChosen = new RecPow();
                Console.WriteLine("** 8,2. Алгоритм возведения в степень с помощью рекурсии                 **");
                break;
            case 8.3f://pow
                algChosen = new QuickPow();
                Console.WriteLine("** 8,3. Быстрый алгоритм возведения в степень                            **");
                break;
            case 8.4f://pow
                algChosen = new QuickPow2();
                Console.WriteLine("** 8,4. Классический быстрый алгоритм возведения в степень               **");
                break;
            case 9://matrix
                algChosen = new MatrixMultiplication();
                Console.WriteLine("** 9. Произведение матриц                                               **");
                break;
            case 10://stooge
                algChosen = new StoogeSort();
                Console.WriteLine("** 10. Stoogesort                                                       **");
                break;
            case 11://Intro
                    algChosen = new IntroSort();
                Console.WriteLine("** 11. Introsort                                                        **");
                break;
            case 12://Comb
                algChosen = new CombSort();
                Console.WriteLine("** 12. Combsort                                                         **");
                break;
            default:
                Console.WriteLine("**                                                                      **");
                Console.WriteLine("** Вы ввели несуществующий номер. Попробуйте снова.                     **");
                Console.WriteLine("**                                                                      **");
                Console.WriteLine("**************************************************************************");
                goto startInput;
                break;
        }
        
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("**                                                                      **");
        Console.Write("** Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");

        Console.WriteLine("**                                                                      **");
        Console.Write("** Введите количество тестов для подсчета среднего значения: ");
        int sHowManyTests = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("**                                                                      **");
        Console.WriteLine("**************************************************************************");
        //тесты
        double[,] timeVector = new double[sHowManyTests, n];
        for (int howManyTests = sHowManyTests; howManyTests != 0; howManyTests--)
            for (int vectorSize = 1; vectorSize <= n; vectorSize++)
                timeVector[howManyTests-1,vectorSize-1] = algChosen.Start(vectorSize);
        //среднее время
        double[] timeApprox = new double[n];
        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int iterHMT = 0; iterHMT < sHowManyTests; iterHMT++)
                sum += timeVector[iterHMT, i];
            timeApprox[i] = sum / sHowManyTests;
        }
        //вывод
        string outputFile = algChosen.GetType().Name + "/"+ algChosen.GetType().Name+" " + Convert.ToString(DateTime.Now).Replace(':','.')+" n("+n+") att("+sHowManyTests+").txt";
        Process.Start("cmd", "/C IF NOT EXIST "+ algChosen.GetType().Name+" md "+ algChosen.GetType().Name);
        Thread.Sleep(1000);
        StreamWriter sw = File.CreateText(outputFile);
        StreamWriter sw2 = File.CreateText(algChosen.GetType().Name + " " + Convert.ToString(DateTime.Now).Replace(':', '.') + " n(" + n + ") att(" + sHowManyTests + ").txt");
        foreach (double i in timeApprox)
        {
            sw.WriteLine(i);
            sw2.WriteLine(i);
        }
        sw.Close();
        Process.Start("notepad.exe", outputFile);
    }
}