using CustomTestingFramework.Exceptions;
using System;

namespace CustomTestingFramework.Asserts
{
    public static class Assert
    {
        public static void AreEqual(object a, object b)
        {
            if (!a.Equals(b))
            {
                throw new TestException();
            }
        }

        public static void AreNotEqual(object a, object b)
        {
            if (a.Equals(b))
            {
                throw new TestException();
            }
        }

        public static void Throws<T>(Func<bool> condition)
            where T : Exception
        {
            try
            {
                if (condition.Invoke())
                {
                    throw new TestException();
                }

            }
            catch (T)
            {
            }
        }

    }
}
