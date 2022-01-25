using System;
using System.Collections.Generic;

namespace Delegates.Examples
{
    public class Predicates
    {
        static IList<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        static Predicate<int> isEven = (number) => number % 2 == 0 ? true : false;

        public static void PredicateExample_1()
        {
            Console.WriteLine(nameof(PredicateExample_1));

            IList<int> onlyEvenNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (isEven(number))
                {
                    onlyEvenNumbers.Add(number);
                    Console.Write($"{number}, ");
                }
            }
            Console.WriteLine();
        }
    }
}