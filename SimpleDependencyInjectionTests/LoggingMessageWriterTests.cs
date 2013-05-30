using NSubstitute;
using NUnit.Framework;
using SimpleDependencyInjectionConsole;

namespace SimpleDependencyInjectionTests
{
    [TestFixture]
    public class LoggingMessageWriterTests
    {
        private const string Message = "Hello CraftyCoders!"; 
        
        private IMessageWriter _writer;
        private ILogger _logger;
        private LoggingMessageWriter _sut;

        [SetUp]
        public void Setup()
        {
            _writer = Substitute.For<IMessageWriter>();
            _logger = Substitute.For<ILogger>();

            _sut = new LoggingMessageWriter(_writer, _logger);
        }

        [Test]
        public void should_log_correct_message()
        {
            _sut.Write(Message);

            _logger.Received().Debug(Arg.Any<string>());
        }

        [Test]
        public void should_call_inner_writer()
        {
            _sut.Write(Message);

            _writer.Received().Write(Message);
        }
    }
}