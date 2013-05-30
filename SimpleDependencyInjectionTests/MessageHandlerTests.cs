using System;
using NSubstitute;
using NUnit.Framework;
using SimpleDependencyInjectionConsole;

namespace SimpleDependencyInjectionTests
{
    //[TestFixture]
    //public class MessageHandlerTests
    //{
    //    private const string Message = "Hello CraftyCoders!";

    //    private IMessageValidator _validator;
    //    private IMessageWriter _writer;

    //    [SetUp]
    //    public void Setup()
    //    {
    //        _validator = Substitute.For<IMessageValidator>();
    //        _writer = Substitute.For<IMessageWriter>();
    //    }

    //    [Test]
    //    [ExpectedException(typeof(ApplicationException))]
    //    public void should_not_write_message_if_it_is_not_valid()
    //    {
    //        _validator.IsValid(Message).Returns(false);

    //        var handler = new MessageHandler(_validator, _writer);

    //        handler.Process(Message);

    //        _writer.DidNotReceive().Write(Message);
    //    }

    //    [Test]
    //    public void should_write_message_if_it_is_valid()
    //    {
    //        _validator.IsValid(Message).Returns(true);

    //        var handler = new MessageHandler(_validator, _writer);

    //        handler.Process(Message);

    //        _writer.Received().Write(Message);
    //    }
    //}
}
