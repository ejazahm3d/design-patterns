using System;

namespace Behavioural.ChainOfResponsibility
{
    public class Authenticator: Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            var isValid = request.Username == "test" && request.Password == "123";
            Console.WriteLine("Authentication");
            return !isValid;
        }
    }
}