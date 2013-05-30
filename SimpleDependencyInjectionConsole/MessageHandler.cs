using System;

namespace SimpleDependencyInjectionConsole
{
    public class MessageHandler
    {
        public void Process(string message)
        {
            var validator = new SimpleMessageValidator();
            
            if (!validator.IsValid(message))
                throw new ApplicationException("Message is not valid");

            var writer = new ConsoleMessageWriter();
            
            writer.Write(message);
        }
    }
}
