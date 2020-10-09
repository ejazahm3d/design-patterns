namespace Behavioural.Visitor
{
    public interface IHtmlNode
    {
        public void Execute(IOperation operation);
    }
}