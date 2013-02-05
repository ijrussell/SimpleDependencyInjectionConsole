using System.Collections.Generic;

namespace SimpleDependencyInjectionConsole
{
    /// <summary>
    /// Manual Composition Root
    /// AKA poor Man's Dependency Injection
    /// </summary>
    public class ObjectFactory
    {
        private static ILogger _logger;
        
        static ObjectFactory()
        {
            _logger = new ConsoleLogger();
        }

        public static MessageHandler CreateMessageHandler()
        {
            return new MessageHandler(CreateMessageValidator(), CreateLoggingMessageWriter());
        }

        public static IMessageValidator CreateMessageValidator()
        {
            return new SimpleMessageValidator();
        }

        public static IMessageWriter CreateLoggingMessageWriter()
        {
            return new LoggingMessageWriter(CreateMessageWriter(), CreateLogger());
        }

        public static IMessageWriter CreateMessageWriter()
        {
            return new ConsoleMessageWriter();
        }

        public static ILogger CreateLogger()
        {
            return _logger;
        }

        public static Checkout CreateCheckout()
        {
            return new Checkout(CreateShippingCostCalculatorFactory());
        }

        public static IShippingCostCalculatorFactory CreateShippingCostCalculatorFactory()
        {
            return new ShippingCostCalculatorFactory(CreateShippingCostCalculators());
        }

        public static IEnumerable<IShippingCostCalculator> CreateShippingCostCalculators()
        {
            return new List<IShippingCostCalculator>
                {
                    new ExpressShippingCalculator(),
                    new PriceSaverShippingCalculator(),
                    new StandardShippingCalculator(),
                    new FreeShippingCostCalculator()
                };
        }
    }
}