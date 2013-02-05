using System;
using SimpleDependencyInjectionConsole;

namespace SimpleDependencyInjectionTests
{
    public class FakeTimeProvider : TimeProvider
    {
        private readonly DateTime _now;

        public FakeTimeProvider(DateTime now)
        {
            _now = now;
        }

        public override DateTime Now
        {
            get { return _now; }
        }
    }
}