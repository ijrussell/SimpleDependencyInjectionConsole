namespace SimpleDependencyInjectionConsole
{
    public class Checkout
    {
        private readonly IShippingCostCalculatorFactory _shippingCostCalculatorFactory;

        public Checkout(IShippingCostCalculatorFactory shippingCostCalculatorFactory)
        {
            _shippingCostCalculatorFactory = shippingCostCalculatorFactory;
        }

        public int CalculateShippingCost(ShoppingBasket shoppingBasket)
        {
            var calculator = _shippingCostCalculatorFactory.GetCalculator(shoppingBasket.ShippingMethod);

            return calculator.CalculatePrice(shoppingBasket);
        }
    }
}