using System;
using Behavioural.Memento;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            editor.Content = "Hello World";
            editor.Content = "No world";
        }
    }
}