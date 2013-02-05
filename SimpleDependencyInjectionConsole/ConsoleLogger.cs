using System;

namespace SimpleDependencyInjectionConsole
{
    public class ConsoleLogger : ILogger
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug: {0}", message);
        }

        public void Info(string message)
        {
            Console.WriteLine("Info: {0}", message);
        }

        public void Warning(string message)
        {
            Console.WriteLine("Warning: {0}", message);
        }

        public void Error(string message, Exception exception)
        {
            Console.WriteLine("Error: {0}\n{1}\n{2}", message, exception.Message, exception);
        }
    }
}