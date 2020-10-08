using System.Collections.Generic;
using Behavioural.Command.FX;

namespace Behavioural.Command
{
    public class CompositeCommand: ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            _commands.Add(command);
        } 
        public void Execute()
        {
            foreach (var command in _commands) command.Execute();
        }
    }
}