using CustomTestingFramework.Attributes;
using CustomTestingFramework.Exceptions;
using CustomTestingFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CustomTestingFramework.TestRunner
{
    public class Runner
    {
        private readonly ICollection<string> resultInfo;

        public Runner()
        {
            resultInfo = new List<string>();
        }

        public ICollection<string> Run(string path)
        {
            Type[] classes = Assembly
                .LoadFrom(path)
                .GetTypes()
                .Where(t => t.HasAttribute<TestClassAttribute>())
                .ToArray();

            foreach (var testClass in classes)
            {
                MethodInfo[] methods = testClass
                    .GetMethods()
                    .Where(m => m.HasAttribute<TestMethodAttribute>())
                    .ToArray();

                object instance = Activator.CreateInstance(testClass);

                foreach (var method in methods)
                {
                    try
                    {
                        try
                        {
                            method.Invoke(instance, new object[] { });
                        }
                        catch (TargetInvocationException)
                        {

                            throw new TestException();
                        }

                        resultInfo.Add($"Method: {method.Name} - passed!");
                    }
                    catch(TestException)
                    {
                        resultInfo.Add($"Method: {method.Name} - failed!");
                    }
                    catch
                    {
                        resultInfo.Add($"Method: {method.Name} - unexpected error occured!");
                    }
                }
            }

            return resultInfo;
        }
    }
}
