using System;
using Structural.Adapter;
using Structural.Adapter.avaFilters;
using Structural.Composite;
using Structural.Decorator;
using Structural.Facade;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();
            notificationService.Send("Hello World", "target");
        }
    }
}