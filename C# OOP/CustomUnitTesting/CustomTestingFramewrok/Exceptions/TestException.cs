using System;
using System.Reflection;

namespace CustomTestingFramework.Exceptions
{
    public class TestException : Exception
    {
        private const string message = "Failed Test";

        public TestException(string message, Exception exception)
            : base(message, exception)
        {

        }

        public TestException(string message)
            : base(message)
        {

        }

        public TestException()
            :base(message)
        {

        }
    }
}
