using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using Structural.Flyweight;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
          var pointService = new PointService(new PointIconFactory());

          foreach (var point in pointService.GetPoints()) point.Draw();
        }
    }
}