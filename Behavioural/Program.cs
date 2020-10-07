using System;
using Behavioural.Iterator;
using Behavioural.Memento;
using Behavioural.State;
using static System.Console;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
            var browserHistory = new BrowserHistory();
            browserHistory.Push("a");
            browserHistory.Push("b");
            browserHistory.Push("c");
            browserHistory.Push("d");

            var iterator = browserHistory.CreateIterator();
            while (iterator.HasNext())
            {
                var url = iterator.Current();
                WriteLine(url);
                iterator.Next();
            }
        }
    }
}