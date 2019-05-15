using System;
using System.Collections.Generic;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 0, 6, 3, 2, 8, 1 };

            List<int> result = InsertionSort(numbers);

            Console.WriteLine($"Sorted numbers: {string.Join(", ", numbers)}");
        }

        public static List<int> InsertionSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > current)
                {
                    numbers[j + 1] = numbers[j];
                    j -= 1;
                }

                numbers[j + 1] = current;
            }

            return numbers;
        }
    }
}
