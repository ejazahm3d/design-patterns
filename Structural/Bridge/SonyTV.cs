using System;

namespace Structural.Bridge
{
    public class SonyTV: IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn off");
        }

        public void SetChannel()
        {
            Console.WriteLine("Sony: set channel");
        }
    }
}