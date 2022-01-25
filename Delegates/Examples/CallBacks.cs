using Delegates.Events;
using Delegates.Models;
using Delegates.Utils;
using System;

namespace Delegates.Examples
{
    public class CallBacks
    {
        public delegate string Check(double p1, double p2);

        public static void CallBackExample_1()
        {
            Console.WriteLine($"{nameof(CallBackExample_1)}");


            var payment = new Payment(100, 150); 

            AddEvents(payment);

            var message = payment.GetStatusMessage(Checker.DebtProgress);


            Console.WriteLine($"Result {nameof(payment.GetStatusMessage)}");
            Console.WriteLine(message); // "Você precisa quitar sua dívida mocinho. :c"
        }

        private static void AddEvents(Payment payment)
        {
            payment.OnChecking += PaymentEvent.SendByEmail;
            payment.OnChecking += PaymentEvent.SendBySMS;
        }
    }
}