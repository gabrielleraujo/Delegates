using Delegates.Utils;
using System;

namespace Delegates.Examples
{
    public class Funcs
    {
        public static void FuncExample_1()
        {
            Console.WriteLine(nameof(FuncExample_1));

            Func<double, double, double, double> funcCalculateAverage = (a, b, c) => (a + b + c) / 3;

            Console.WriteLine($"Result {nameof(funcCalculateAverage)} - {funcCalculateAverage(90, 5, 5)}");  // 33.333...
        }

        public static void FuncExample_2()
        {
            Console.WriteLine($"\n{nameof(FuncExample_2)}");

            Func<int, int, bool> funcCheckeIfSumIsEven = Checker.SumIsEven;
            Func<double, double, string> funcCheckDebtProgress = Checker.DebtProgress;

            Console.WriteLine($"Result {nameof(funcCheckeIfSumIsEven)} - {funcCheckeIfSumIsEven(10, 3)}");  // false
            Console.WriteLine($"Result {nameof(funcCheckDebtProgress)} - {funcCheckDebtProgress(15000.85, 15000.85)}");  // "Divida quitada. c:"
        }
    }
}