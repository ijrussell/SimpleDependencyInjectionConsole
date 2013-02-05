using System;

namespace SimpleDependencyInjectionConsole
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine("ConsoleMessageWriter wrote '{0}'", message);
        }
    }
}