using System;

namespace Delegates.Handlers
{
    public class Handler
    {
        public void RunExemples(string message, params Action[] actions)
        {
            Console.WriteLine(message);
            foreach (var action in actions)
            {
                action();
                Console.WriteLine("*******************************************************");
            }
        }
    }
}