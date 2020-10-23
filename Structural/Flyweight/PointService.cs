using System.Collections.Generic;

namespace Structural.Flyweight
{
    public class PointService
    {
        private readonly PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public IEnumerable<Point> GetPoints()
        {
            return new List<Point> {new Point {X = 1, Y = 2, PointIcon = _iconFactory.GetPointIcon(PointType.Cafe)}};
        }

    }
}


