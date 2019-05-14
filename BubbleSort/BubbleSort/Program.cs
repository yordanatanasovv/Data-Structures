using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 31, 52, 13, 24, 75, 76, 87, 88, 49 };

            Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");


            BubbleSort(numbers);
        }

        public static void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted numbers: {string.Join(", ", numbers)}");
        }
    }
}
