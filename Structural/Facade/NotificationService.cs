﻿namespace Structural.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("id", "key");
            server.Send(authToken,new Message(message), target);
            connection.Disconnect();
        }
    }
}