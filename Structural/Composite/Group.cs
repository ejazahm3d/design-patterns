using System.Collections.Generic;

namespace Structural.Composite
{
    public class Group
    {
        private readonly List<Shape> _shapes = new List<Shape>();

        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void Render()
        {
            foreach (var shape in _shapes)
            {
                shape.Render();
            }
        }
    }
}