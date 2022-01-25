namespace Delegates.Models
{
    public class Payment
    {
        public delegate string Check(double p1, double p2);
        public event Check OnChecking;

        public Payment(double amountPaid, double debit)
        {
            AmountPaid = amountPaid;
            Debit = debit;
        }

        public double AmountPaid { get; private set; }
        public double Debit { get; private set; }

        public string GetStatusMessage(Check checkDebtProgress)
        {
            var message = string.Empty;
            message += "---------------------------\n";
            message += "Inicio da mensage\r\n\r\n";
            message += checkDebtProgress(AmountPaid, Debit);
            message += "\r\n\r\n";
            message += "Final da mensagem\r\n";
            message += "---------------------------";

            OnChecking.Invoke(AmountPaid,Debit);
            return message;
        }
    }
}