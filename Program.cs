using System;

namespace Seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            // 0, 7, 8, -2, -2 -> 2
            // 1, -7, 567, 89, 223-> 3

            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

            Console.WriteLine($"\nInput Task№\t");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 0: return; 
                case 41: CountNumber(); break;
                case 43: PointOfIntersectionOfLines(); break;
                default: System.Console.WriteLine("error"); break;
            }


            void CountNumber()

            {
                System.Console.WriteLine($"Введите размер массива  ");
                int M = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[M];

                System.Console.WriteLine($"Введите {M} чисел через enter  ");

                for (int i = 0; i < M; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                int count = 0;
                for (int j = 0; j < M; j++)
                {
                    if (arr[j] > 0) count++;
                }
                System.Console.WriteLine($"\n Введено {count} чисел больше нуля."); 
            }


            void PointOfIntersectionOfLines()
            {
                Console.WriteLine($"Укажите коэф-т b1 уравнения 1");
                double b1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Укажите коэф-т k1 уравнения 1");
                double k1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Укажите коэф-т b2 уравнения 2");
                double b2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Укажите коэф-т k2 уравнения 2");
                double k2 = Convert.ToDouble(Console.ReadLine());

                //k1 * x - y + b1 = 0, k2 * x- y + b2 = 0;

                if (k1 == k2 && b1 == b2)
                {
                    System.Console.WriteLine("Прямые совпадают, бесконечное количество точек пересечения");
                }
                else if (k1 == k2)
                {
                    System.Console.WriteLine("Прямые параллельны, точек пересечения нет");
                }
                else
                {
                    double PointX = (b2 - b1) / (k1 - k2);
                    double PointY = k1 * PointX + b1;
                    System.Console.WriteLine($"{Math.Round(PointX, 2)}; {Math.Round(PointY, 2)}");
                }

            }
        }
    }
}


