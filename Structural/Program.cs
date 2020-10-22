using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Composite;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));
        }
    }
}