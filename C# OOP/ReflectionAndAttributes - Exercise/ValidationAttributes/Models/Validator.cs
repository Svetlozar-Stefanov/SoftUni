using System;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = (obj as Person).GetType();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var prop in propertyInfos)
            {
                var attribute = prop
                    .GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .FirstOrDefault();

                if (!attribute.IsValid(prop.GetValue(obj)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
