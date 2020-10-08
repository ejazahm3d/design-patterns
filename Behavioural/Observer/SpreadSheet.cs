using System;

namespace Behavioural.Observer
{
    public class SpreadSheet: IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Spreadsheet got notified: {value}");
        }
    }
}