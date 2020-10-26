using System;

namespace Structural.Bridge
{
    public class SamsungTV: IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn off");
        }

        public void SetChannel()
        {
            Console.WriteLine("Samsung: set channel");
        }
    }
}