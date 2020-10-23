
using System;

namespace Structural.Flyweight
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointIcon PointIcon { get; set; }
       
        public void Draw()
        {
            Console.WriteLine($"{PointIcon.Type} at ({X}, {Y})");
        }
    }
}