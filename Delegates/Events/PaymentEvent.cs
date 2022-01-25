using System;

namespace Delegates.Events
{
    public static class PaymentEvent
    {
        public static string SendByEmail(double amountPaid, double debit)
        {
            var message = "Sending the result to the email xpto@gmail.com...\n";
            message += $"Parameters: {nameof(amountPaid)}: {amountPaid} - {debit}: {nameof(debit)}";

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine(nameof(SendByEmail));
            Console.WriteLine(message);
            Console.ResetColor();

            return message; // retornando pra nada, mas ok kkk
        }

        public static string SendBySMS(double amountPaid, double debit)
        {
            var message = string.Empty;
            message += "Sending the result to the number +55 (xx) xxxx-xxxx...\n";
            message += $"Parameters: {nameof(amountPaid)}: {amountPaid} - {debit}: {nameof(debit)}";

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine(nameof(SendBySMS));
            Console.WriteLine(message);
            Console.ResetColor();

            return message;
        }
    }
}