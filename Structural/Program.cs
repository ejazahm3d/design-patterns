using System;
using Structural.Composite;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());
            group1.Add(new Shape());
            
            var group2 = new Group();
            
            group2.Add(new Shape());
            group2.Add(new Shape());
            group2.Add(new Shape());
            
        }
    }
}