using Delegates.Utils;
using System;

namespace Delegates.Examples
{
    public class Generics
    {
        public delegate TResult MyGenericDelegate<in T1, in T2, out TResult>(T1 p1, T2 p2);

        public static void DelegateExample_1()
        {
            Console.WriteLine(nameof(DelegateExample_1));

            MyGenericDelegate<int, int, bool> delegateCheckeIfSumIsEven;
            delegateCheckeIfSumIsEven = Checker.SumIsEven;

            Console.WriteLine($"Result {nameof(delegateCheckeIfSumIsEven)} - {delegateCheckeIfSumIsEven(1, 2)}");  // false
        }

        public static void DelegateExample_2()
        {
            Console.WriteLine($"\n{nameof(DelegateExample_2)}");

            MyGenericDelegate<double, double, string> delegateCheckDebtProgress;
            delegateCheckDebtProgress = Checker.DebtProgress;

            Console.WriteLine($"Result {nameof(delegateCheckDebtProgress)} - {delegateCheckDebtProgress(2000.99, 2000.99)}");  // "Dívida quitada. c:"
        }
    }
}