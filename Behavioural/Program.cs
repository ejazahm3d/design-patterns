using System;
using Behavioural.Memento;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());
            editor.Content = "c";
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}