using System;

namespace Delegates.Handlers
{
    public interface IHandler
    {
        void RunExemples(string message, params Action[] actions);
    }
}