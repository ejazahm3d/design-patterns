using System;
using Behavioural.Command.FX;

namespace Behavioural.Command
{
    public class BlackAndWhiteCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Applying Black and White filter");
        }
    }
}