using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            int searchedNumber = 66;
            int searchedIndex = BinarySearch(numbers, searchedNumber);


            Console.WriteLine($"Numbers are {String.Join(", ", numbers)}");
            Console.WriteLine($"Search number is {searchedNumber} and it is located at index: {searchedIndex}");
        }

        public static int BinarySearch(List<int> numbers, int searchedNumber)
        {
            int left = 0;
            int right = numbers.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (searchedNumber == numbers[middle])
                {
                    return middle;
                }
                else if (searchedNumber < numbers[middle])
                {
                    right = middle - 1;
                }
                else if (searchedNumber > numbers[middle])
                {
                    left = middle + 1;
                }
            }

            return -1;
 
        }
    }
}
