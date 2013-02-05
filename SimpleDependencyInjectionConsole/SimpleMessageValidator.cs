namespace SimpleDependencyInjectionConsole
{
    public class SimpleMessageValidator : IMessageValidator
    {
        public bool IsValid(string message)
        {
            return !string.IsNullOrWhiteSpace(message);
        }
    }
}