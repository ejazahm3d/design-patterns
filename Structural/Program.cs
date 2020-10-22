using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Composite;
using Structural.Decorator;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
          var cloudStream = new CloudStream();
          
          var compressedAndEncrypted = new EncryptedCloudStream(new CompressedCloudStream(cloudStream));
          
          compressedAndEncrypted.Write("Teeeheeee");
        }
    }
}