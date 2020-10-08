using System;

namespace Behavioural.Observer
{
    public class DataSource : Observable
    {
        private int _val;
        public int Val
        {
            get => _val;
            set
            {
                _val = value;
                NotifyObservers(value);
            }
        }
    }
}