using System;
using Behavioural.ChainOfResponsibility;
using Behavioural.Command.Editor;
using Behavioural.Mediator;
using Behavioural.Observer;

namespace Behavioural
{
    class Program
    {
        static void Main(string[] args)
        {    
          var compressor = new Compressor(null);
          var logger = new Logger(compressor);
          var authenticator = new Authenticator(logger);
          var webServer = new WebServer(authenticator);
          webServer.Handle(new HttpRequest("test", "123"));
        }
    }
}