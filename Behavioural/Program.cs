using System;
using Behavioural.Memento;
using Behavioural.State;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
            
            canvas.CurrentTool = new BrushTool();
            
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}