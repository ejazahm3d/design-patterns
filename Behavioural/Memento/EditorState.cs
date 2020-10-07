namespace Behavioural.Memento
{
    public class EditorState
    {
        public string Content { get; set; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}