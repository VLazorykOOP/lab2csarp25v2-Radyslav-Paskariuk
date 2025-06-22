using System;

namespace ArrayTasks
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Завдання 1: Одновимірний масив ===");
            Task1_OneDimensional();

            Console.WriteLine("\n=== Завдання 1: Двовимірний масив ===");
            Task1_TwoDimensional();

            Console.WriteLine("\n=== Завдання 2: Мінімум серед додатних ===");
            Task2_MinPositive();

            Console.WriteLine("\n=== Завдання 3: Симетрія матриці ===");
            Task3_CheckSymmetry();
        }

        // Завдання 1 — Одновимірний масив
        static void Task1_OneDimensional()
        {
            Console.Write("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Індекси елементів, що не діляться на 7: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 7 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Завдання 1 — Двовимірний масив
        static void Task1_TwoDimensional()
        {
            Console.Write("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Індекси елементів, що не діляться на 7:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 7 != 0)
                        Console.WriteLine($"[{i},{j}]");
                }
            }
        }

        // Завдання 2 — Мінімум серед додатних
        static void Task2_MinPositive()
        {
            Console.Write("Введіть кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double minPositive = double.MaxValue;
            bool found = false;

            foreach (double num in numbers)
            {
                if (num > 0 && num < minPositive)
                {
                    minPositive = num;
                    found = true;
                }
            }

            if (found)
                Console.WriteLine($"Мінімальний додатний елемент: {minPositive}");
            else
                Console.WriteLine("Додатних елементів немає.");
        }

        // Завдання 3 — Симетричність матриці
        static void Task3_CheckSymmetry()
        {
            Console.Write("Введіть розмірність матриці n (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool isSymmetric = true;
            for (int i = 0; i < n && isSymmetric; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
            }

            if (isSymmetric)
                Console.WriteLine("Матриця симетрична відносно головної діагоналі.");
            else
                Console.WriteLine("Матриця НЕ симетрична.");
        }
    }
}
