using System;
using System.Linq;
using System.Reflection;


public static class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        Type type = Type.GetType("StartUp");

        MethodInfo[] methodInfosByAuthor = type
            .GetMethods
            (BindingFlags.Public |
            BindingFlags.Static |
            BindingFlags.Instance);

        foreach (var method in methodInfosByAuthor)
        {
            if (method.CustomAttributes.Any(m => m.AttributeType == typeof(AuthorAttribute)))
            {
                var attributes = method.GetCustomAttributes(false);

                foreach (AuthorAttribute attribute in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}


