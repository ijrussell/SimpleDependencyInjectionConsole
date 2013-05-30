﻿using System;

namespace SimpleDependencyInjectionConsole
{
    public class NullLogger : ILogger
    {
        public void Debug(string message)
        {
            //
        }

        public void Info(string message)
        {
            //
        }

        public void Warning(string message)
        {
            //
        }

        public void Error(string message, Exception exception)
        {
            //
        }
    }
}