namespace Delegates.Utils
{
    static class Checker
    {
        public static bool SumIsEven(int number1, int number2)
        {
            return (number1 + number2) % 2 == 0 ? true : false;
        }

        public static string DebtProgress(double amountPaid, double debit)
        {
            return (amountPaid < debit) ? $"Você precisa quitar sua dívida mocinho. :c" : $"Dívida quitada. c:";
        }
    }
}