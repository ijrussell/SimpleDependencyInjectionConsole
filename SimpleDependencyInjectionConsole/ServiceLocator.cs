using System;
using System.Collections.Generic;

namespace SimpleDependencyInjectionConsole
{
    public static class ServiceLocator
    {
        private readonly static Dictionary<Type, object> services = new Dictionary<Type, object>();

        public static T Resolve<T>()
        {
            return (T)ServiceLocator.services[typeof(T)];
        }

        public static void Register<T>(T service)
        {
            ServiceLocator.services[typeof(T)] = service;
        }

        public static void Reset()
        {
            ServiceLocator.services.Clear();
        }
    }
}
