using System;
using Behavioural.Command.FX;

namespace Behavioural.Command
{
    public class ResizeCommand: ICommand 
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}