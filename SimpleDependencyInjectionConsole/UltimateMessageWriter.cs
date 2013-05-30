using System;

namespace SimpleDependencyInjectionConsole
{
    public class UltimateMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine("UltimateMessageWriter wrote '{0}'", message);
        }
    }
}