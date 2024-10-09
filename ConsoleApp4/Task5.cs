using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Task5
    {
        public static void SortNumbersByDigitSum()
        {
            int[] numbersInArray = { 121, 75, 81, 34, 90 };

            var ascending = numbersInArray.OrderBy(n => n.ToString().Sum(c => c - '0')).ToArray();
            Console.WriteLine("Сортування за зростанням суми цифр:");
            foreach (var num in ascending)
            {
                Console.WriteLine(num);
            }

            var descending = numbersInArray.OrderByDescending(n => n.ToString().Sum(c => c - '0')).ToArray();
            Console.WriteLine("Сортування за спаданням суми цифр:");
            foreach (var num in descending)
            {
                Console.WriteLine(num);
            }
        }
    }
}
