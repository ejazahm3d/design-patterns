using System;

namespace Structural.Composite
{
    public class Shape: IComponent
    {
        public void Render()
        {
            Console.WriteLine("Rendering");
        }
    }
}