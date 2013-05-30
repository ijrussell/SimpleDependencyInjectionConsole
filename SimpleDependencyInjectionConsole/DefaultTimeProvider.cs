using System;

namespace SimpleDependencyInjectionConsole
{
    public class DefaultTimeProvider : TimeProvider
    {
        public override DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}