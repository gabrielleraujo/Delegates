using Delegates.Examples;
using Delegates.Handlers;

namespace Delegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            var handler = new Handler();

            handler.RunExemples("GENERIC DELEGATES\n", Generics.DelegateExample_1, Generics.DelegateExample_2);
            handler.RunExemples("FUNC\n", Funcs.FuncExample_1, Funcs.FuncExample_2);
            handler.RunExemples("CALL BACK\n", CallBacks.CallBackExample_1);
            handler.RunExemples("PREDICATES\n", Predicates.PredicateExample_1);
        }
    }
}