//Створіть додаток, який здійснює операції над матрицями:
//■ Множення матриці на число;
//■ Додавання матриць;
//■ Добуток матриць.
using System;

namespace NET_Homework_2_3
{
    internal class Program
    {
        static void Multi_matrices(ref int[,] array1, ref int[,] array2, ref int[,] multiarray, int r)//Добуток матриць
        {
            int[] ml = new int[r];
            int ml_n = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        ml[k] = (array1[i, k] * array2[k, j]);
                    }
                    for (int n = 0; n < r; n++)
                    {
                        ml_n += ml[n];
                    }
                    multiarray[i, j] = ml_n;
                    ml_n = 0;
                }
            }
            Console.WriteLine();
        }
        static void Addition_array(ref int[,] array1, ref int[,] array2, int r)//Додавання матриць
        {
            int[,] sumarray = new int[r, r];
            for (int i = 0; i < sumarray.GetLength(0); i++)
            {
                for (int j = 0; j < sumarray.GetLength(1); j++)
                {
                    sumarray[i, j] = array1[i, j] + array2[i, j];
                }
            }
            ShowArray(ref sumarray);
        }
        static void Multi_number(ref int[,] array, int number)//Множення матриці на число
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] *= number;
                }
            }
            Console.WriteLine();
        }
        static void Array(out int a)//Створення матриці
        {
            Console.Write("Введіть скільки має бути рядків та стовбців в матриці: ");
            a = Convert.ToInt32(Console.ReadLine());
        }
        static void ShowArray(ref int[,] array)//Вивод матриці на екран
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void InputArray(ref int[,] array)//Заповненя матриці елементами
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Введіть елемент масиву: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static void Multiplication_by_a_number() //Метод в якому здійснюється множення матриці на число
        {
            int r;
            Array(out r);
            int[,] array1 = new int[r, r];

            InputArray(ref array1);

            Console.WriteLine("Матриця:");
            ShowArray(ref array1);

            Console.Write("\nВведіть число на яке потрібно помножити матрицю: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nМатриця помножена на число " + n);
            Multi_number(ref array1, n);
            ShowArray(ref array1);
        }
        static void Adding_matrices()//Метод в якому здійснюється додавання матриць
        {
            Console.WriteLine("\nПерша матриця:");
            int r;
            Array(out r);
            int[,] array1 = new int[r, r];

            InputArray(ref array1);

            Console.WriteLine("Матриця 1:");
            ShowArray(ref array1);

            Console.WriteLine("\nДруга матриця:");
            int r2;
            Array(out r2);
            int[,] array2 = new int[r2, r2];

            InputArray(ref array2);

            Console.WriteLine("Матриця 2:");
            ShowArray(ref array2);

            if (r == r2)
            {
                Console.WriteLine("\nМатриця 1 додана до матриці 2:");
                Addition_array(ref array1, ref array2, r);
            }
            else
            {
                Console.WriteLine("Неможливо здійснити додавання матриць!\n" +
                    "Кількість рядків та стовбців у двох матрицях мають бути однаковими!");
            }

        }
        static void Multiplication_of_matrices()//Метод в якому здійснюється добуток матриць
        {
            Console.WriteLine("\nПерша матриця:");
            int r;
            Array(out r);
            int[,] array1 = new int[r, r];

            InputArray(ref array1);

            Console.WriteLine("Матриця 1:");
            ShowArray(ref array1);

            Console.WriteLine("\nДруга матриця:");
            int r2;
            Array(out r2);
            int[,] array2 = new int[r2, r2];

            InputArray(ref array2);

            Console.WriteLine("Матриця 2:");
            ShowArray(ref array2);

            if (r == r2)
            {
                Console.WriteLine("Матриця 1 помножена на матрицю 2:");
                int[,] multiarray = new int[r, r];
                Multi_matrices(ref array1, ref array2, ref multiarray, r);
                ShowArray(ref multiarray);
            } else
            {
                Console.WriteLine("Неможливо здійснити добуток матриць!\n" +
                    "Кількість рядків та стовбців у двох матрицях мають бути однаковими!\n");
            }
        }
        static void Main(string[] args)
        {
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("\nОберіть необхідну дію з матрицями:\n" +
                    "0. Завершення.\n" +
                    "1. Множення матриці на число.\n" +
                    "2. Додавання матриць.\n" +
                    "3. Добуток матриць.\n");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 0: 
                        {
                            break;
                        }
                        case 1:
                        {
                            Console.WriteLine("Множення матриці на число:");
                            Multiplication_by_a_number();
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Додавання матриць:");
                            Adding_matrices();
                            break;
                        }
                        case 3:
                        {
                            Console.WriteLine("Добуток матриць:");
                            Multiplication_of_matrices();
                            break;
                        }
                }
            }
        }
    }
}
