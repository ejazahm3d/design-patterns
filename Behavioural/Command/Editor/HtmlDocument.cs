namespace Behavioural.Command.Editor
{
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content = $"<b>{Content}</b>";
        }
    }
}