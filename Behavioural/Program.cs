using System;
using Behavioural.Iterator;
using Behavioural.Memento;
using Behavioural.State;
using Behavioural.Strategy;
using static System.Console;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {
           var imageStore = new ImageStorage(new JpegCompressor(), new BlackAndWhiteFilter());
           
           imageStore.Store("Hello World");
           
        }
    }
}