using System;

namespace SimpleDependencyInjectionConsole
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}