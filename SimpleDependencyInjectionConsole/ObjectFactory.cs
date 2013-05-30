using System.Collections.Generic;
using SimpleDependencyInjectionConsole;

namespace SimpleDependencyInjectionConsole
{
    //<summary>
    //Manual Composition Root
    //AKA poor Man's Dependency Injection
    //</summary>
    public class ObjectFactory
    {
        private static ILogger _logger;

        static ObjectFactory()
        {
            _logger = new ConsoleLogger();
        }

        public static MessageHandler CreateMessageHandler()
        {
            return new MessageHandler();
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
            return new Checkout();
        }

        public static ShippingCostCalculatorFactory CreateShippingCostCalculatorFactory()
        {
            return new ShippingCostCalculatorFactory(CreateShippingCostCalculators());
        }

        public static IEnumerable<IShippingCostCalculator> CreateShippingCostCalculators()
        {
            return new List<IShippingCostCalculator>
                {
                    new ExpressShippingCalculator(),
                    new PriceSaverShippingCalculator(),
                    new StandardShippingCalculator()
                };
        }
    }
}