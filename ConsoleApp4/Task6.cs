using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Task6
    {
        public static void PerformArrayOperations()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int[] array2 = { 4, 5, 6, 7, 8, 9 };

            var difference = array1.Except(array2);
            Console.WriteLine("Різниця двох масивів (елементи з першого масиву, яких немає у другому):");
            foreach (var num in difference)
            {
                Console.WriteLine(num);
            }

            var intersection = array1.Intersect(array2);
            Console.WriteLine("\nПеретин масивів (спільні елементи):");
            foreach (var num in intersection)
            {
                Console.WriteLine(num);
            }

            var union = array1.Union(array2);
            Console.WriteLine("\nОб’єднання масивів (елементи без дублікатів):");
            foreach (var num in union)
            {
                Console.WriteLine(num);
            }

            var distinctArray1 = array1.Distinct();
            Console.WriteLine("\nВміст першого масиву без повторень:");
            foreach (var num in distinctArray1)
            {
                Console.WriteLine(num);
            }
        }
    }
}

