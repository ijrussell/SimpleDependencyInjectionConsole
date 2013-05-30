using System;

namespace SimpleDependencyInjectionConsole
{
    public class LoggingMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;
        private readonly ILogger _logger;

        public LoggingMessageWriter(IMessageWriter writer, ILogger logger)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            if (logger == null)
                throw new ArgumentNullException("logger");
            
            _writer = writer;
            _logger = logger;
        }

        public void Write(string message)
        {
            _logger.Debug(string.Format("LoggingMessageWriter [{0}] {1}", DateTime.UtcNow, message));
            _writer.Write(message);
        }
    }
}