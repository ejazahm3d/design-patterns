using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Bridge;
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
          var remoteControl = new AdvancedRemoteControl(new SamsungTV());
          remoteControl.SetChannel();
        }
    }
}