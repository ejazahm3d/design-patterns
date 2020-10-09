using System.Collections.Generic;

namespace Behavioural.Visitor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node) => _nodes.Add(node);
        
        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes) node.Execute(operation);
        }
    }
}