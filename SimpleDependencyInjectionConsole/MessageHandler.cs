using System;

namespace SimpleDependencyInjectionConsole
{
    public class MessageHandler
    {
        private readonly IMessageValidator _validator;
        private readonly IMessageWriter _writer;
        
        public MessageHandler(IMessageValidator validator, IMessageWriter writer)
        {
            if (validator == null)
                throw new ArgumentNullException("validator");
            if (writer == null)
                throw new ArgumentNullException("writer");
            
            _validator = validator;
            _writer = writer;
        }

        public void Process(string message)
        {
            if (!_validator.IsValid(message))
                throw new ApplicationException("Message is not valid");

            _writer.Write(message);
        }
    }
}
