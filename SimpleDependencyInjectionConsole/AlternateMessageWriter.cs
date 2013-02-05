using System;

namespace SimpleDependencyInjectionConsole
{
    public class AlternateMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine("AlternateMessageWriter wrote '{0}'", message);
        }
    }
}