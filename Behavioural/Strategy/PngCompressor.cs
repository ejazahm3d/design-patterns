using System;

namespace Behavioural.Strategy
{
    class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing into PNG");
        }
    }
}