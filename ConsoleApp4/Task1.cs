using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Task1
    {
        public static void PrintAllNumbers(List<int> numbers)
        {
            var allNumbers = from num in numbers
                             select num;
            Console.WriteLine("Всі числа:");
            foreach (var number in allNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintEvenNumbers(List<int> numbers)
        {
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            Console.WriteLine("Парні числа:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintOddNumbers(List<int> numbers)
        {
            var oddNumbers = from num in numbers
                             where num % 2 != 0
                             select num;
            Console.WriteLine("Непарні числа:");
            foreach (var number in oddNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintRangeNumbers(List<int> numbers, int min, int max)
        {
            var rangeNumbers = from num in numbers
                               where num >= min && num <= max
                               select num;
            Console.WriteLine($"Числа в діапазоні від {min} до {max}:");
            foreach (var number in rangeNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintDivisibleBySeven(List<int> numbers)
        {
            var divisibleBySeven = from num in numbers
                                   where num % 7 == 0
                                   orderby num
                                   select num;
            Console.WriteLine("Числа, кратні семи за зростанням:");
            foreach (var number in divisibleBySeven)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintDivisibleByEight(List<int> numbers)
        {
            var divisibleByEight = from num in numbers
                                   where num % 8 == 0
                                   orderby num descending
                                   select num;
            Console.WriteLine("Числа, кратні восьми за спаданням:");
            foreach (var number in divisibleByEight)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

