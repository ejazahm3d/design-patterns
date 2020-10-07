using System.Collections.Generic;
using System.Linq;

namespace Behavioural.Iterator
{
    public class BrowserHistory
    {
        private List<string> Urls { get; set; } = new List<string>();

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            return Urls.Last();
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
        
        public class ListIterator: IIterator<string>
        {
            private readonly BrowserHistory _history;
            private int Index { get; set; }

            public ListIterator(BrowserHistory history)
            { 
                _history = history;
            }

            public bool HasNext()
            {
                return (Index < _history.Urls.Count);
            }

            public string Current()
            {
                return _history.Urls[Index];
            }

            public void Next()
            {
                Index++;
            }
        }
    }
}