using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fields)
    {
        Type classToInvestigate = Type.GetType(className);

        StringBuilder sb = new StringBuilder();

        FieldInfo[] fieldInfos = classToInvestigate
        .GetFields
        (
            BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.NonPublic |
            BindingFlags.Public
        );

        Object classInstance = Activator.CreateInstance(classToInvestigate, new object[] { });

        sb.AppendLine($"Class under investigation: {classToInvestigate}");
        foreach (var field in fieldInfos.Where(f => fields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type type = Type.GetType(className);

        FieldInfo[] invalidFields = type
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

        MethodInfo[] publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        MethodInfo[] nonPublicMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        StringBuilder sb = new StringBuilder();

        foreach (var invalidField in invalidFields)
        {
            sb.AppendLine($"{invalidField.Name} must be private!");
        }

        foreach (var nonPublicMethod in nonPublicMethods.Where(p => p.Name.StartsWith("get")))
        {
            sb.AppendLine($"{nonPublicMethod.Name} have to be public!");
        }
        
        foreach (var publicMethod in publicMethods.Where(p => p.Name.StartsWith("set")))
        {
            sb.AppendLine($"{publicMethod.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        Type type = Type.GetType(className);

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {type}");
        sb.AppendLine($"Base Class: {type.BaseType.Name}");

        MethodInfo[] methodInfos = type
            .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var methodInfo in methodInfos)
        {
            sb.AppendLine(methodInfo.Name);
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type type = Type.GetType(className);

        MethodInfo[] getters = type
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(m => m.Name.StartsWith("get"))
            .ToArray();

        MethodInfo[] setters = type
            .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
            .Where(m => m.Name.StartsWith("set"))
            .ToArray();

        StringBuilder sb = new StringBuilder();
        foreach (var getter in getters)
        {
            sb.AppendLine($"{getter.Name} will return {getter.ReturnType}");
        }

        foreach (var setter in setters)
        {
            sb.AppendLine($"{setter.Name} will set field of {setter.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}

