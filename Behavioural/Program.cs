using System;
using Behavioural.Command.Editor;
using Behavioural.Mediator;
using Behavioural.Observer;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {    
          var dialog = new ArticlesDialogBox();
          dialog.SimulateUserInteraction();
        }
    }
}