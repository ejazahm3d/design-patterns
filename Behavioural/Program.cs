using System;
using Behavioural.Command.Editor;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {    
            var history = new History();
            var document = new HtmlDocument {Content = "Hello World"};
            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);
            var undoCommand = new UndoCommand(history);
            
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }
    }
}