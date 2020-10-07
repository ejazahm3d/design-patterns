using System.Collections.Generic;
using System.Linq;

namespace Behavioural.Memento
{
    public class History
    {
        private readonly List<EditorState> _states  = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            return _states.Last();
        }
    }
}