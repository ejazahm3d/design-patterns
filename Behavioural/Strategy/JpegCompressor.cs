using System;

namespace Behavioural.Strategy
{
    class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing into JPEG");
        }
    }
}