using System.Collections.Generic;
using System.Linq;

namespace Structural.Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            if (_icons.ContainsKey(type)) return _icons[type];
            var icon = new PointIcon(type, null);
            _icons.Add(type, icon);

            return _icons[type];
        }
    }
}