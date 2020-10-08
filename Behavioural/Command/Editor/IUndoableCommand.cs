namespace Behavioural.Command.Editor
{
    public interface IUndoableCommand: ICommand
    {
        void UnExecute();
    }
}