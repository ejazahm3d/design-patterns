using System;

namespace Behavioural.Visitor
{
    public class HighlightOperation: IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}