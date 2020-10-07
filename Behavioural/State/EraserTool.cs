using static System.Console;

namespace Behavioural.State
{
    public class EraserTool : ITool
    {
        public void MouseDown()
        {
            WriteLine("Eraser");
        }

        public void MouseUp()
        {
            WriteLine("Erase something");
        }
    }
}