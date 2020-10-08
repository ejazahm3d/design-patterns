using System;

namespace Behavioural.Observer
{
    public class Chart: IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart got update: {value}");
        }
    }
}