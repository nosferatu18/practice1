using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            try
            {
                Console.Write("Введите целое число: ");
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }

            //2
            try
            {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            // Если b = 0, программа "упадет" здесь
            int result = a / b;
            Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат данных");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: делить на ноль нельзя");
            }

            //3
            try
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите элемент {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Массив введён");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод данных");
            }

            //4
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                Console.WriteLine("Массив содержит 5 элементов (индексы 0-4).");
                Console.Write("Введите индекс элемента для отображения: ");

                int index = int.Parse(Console.ReadLine());

                Console.WriteLine($"Элемент с индексом {index}: {numbers[index]}");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: указан неверный индексы!");
                Console.WriteLine("Индекс должен быть от 0 до 4.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: нужно вводить только числа!");
            }

            //5

            try
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите элемент {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                    sum += arr[1];
                }

                Console.WriteLine($"Сумма элементов массива: {sum}");
                Console.WriteLine("Массив введён");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод данных");
            }

            //6

            //1
            try
            {
                Console.Write("Введите целое число: ");
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }

            //2
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            // Если b = 0, программа "упадет" здесь
            int result = a / b;
            Console.WriteLine($"Результат: {result}");

            //3
            try
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());

                int[] apr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите элемент {i}: ");
                    apr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Массив введён");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод данных");
            }

            //4
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                Console.WriteLine("Массив содержит 5 элементов (индексы 0-4).");
                Console.Write("Введите индекс элемента для отображения: ");

                int index = int.Parse(Console.ReadLine());

                Console.WriteLine($"Элемент с индексом {index}: {numbers[index]}");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: указан неверный индексы!");
                Console.WriteLine("Индекс должен быть от 0 до 4.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: нужно вводить только числа!");
            }

            //5

            try
            {
                Console.Write("Введите размер массива: ");
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите элемент {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                    sum += array[1];
                }

                Console.WriteLine($"Сумма элементов массива: {sum}");
                Console.WriteLine("Массив введён");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод данных");
            }

            //6

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write($"Введите элемент {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: неверный ввод данных");
                    i--;
                }
            }

            Console.WriteLine("Массив введён");

            //7

            try
            {
                Console.Write("Введите размер массивов: ");
                int n = int.Parse(Console.ReadLine());

                int[] arr1 = new int[n];
                int[] arr2 = new int[n];
                int[] rezult = new int[n];

                Console.WriteLine("Введите элементы первого массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Элемент {i}: ");
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введите элементы второго массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Элемент {i}: ");
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    rezult[i] = arr1[i] / arr2[i];
                }

                Console.WriteLine("Результат деления массивов:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(rezult[i] + " ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный ввод данных");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");




        }
    }
}
