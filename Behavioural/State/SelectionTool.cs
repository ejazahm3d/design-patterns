using static System.Console;

namespace Behavioural.State
{
    public class SelectionTool: ITool
    {
        public void MouseDown()
        {
            WriteLine("Selection Icon");
        }

        public void MouseUp()
        {
            WriteLine("Draw Dashed Rectangle");
        }
    }
}