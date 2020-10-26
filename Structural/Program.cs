using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Bridge;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;
using Structural.Flyweight;
using Structural.Proxy;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
         var library = new Library();
         var fileNames = new string[]{"a", "b", "c"};

         foreach (var fileName in fileNames) 
             library.Add(new LoggingEbookProxy(fileName));
         library.OpenEbook("a");
         library.OpenEbook("b");
        }
    }
}