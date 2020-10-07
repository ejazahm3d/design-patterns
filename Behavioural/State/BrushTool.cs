using static System.Console;

namespace Behavioural.State
{
    public class BrushTool: ITool
    {
        public void MouseDown()
        {
            WriteLine("Brush Icon");
        }

        public void MouseUp()
        {
            WriteLine("Draw A Line");
        }
    }
}