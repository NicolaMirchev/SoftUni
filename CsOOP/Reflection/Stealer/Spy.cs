using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    class Spy
    {

        public string AnalyzeAccessModifiers(string className)
        {
            Type type = Type.GetType(className);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] PublicMethods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] PrivateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();

            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var mehod in PrivateMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{mehod.Name} must be public!");
            }
            foreach (var method in PublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} must be private!");
            }

            return sb.ToString();
        }
        public string StealFieldInfo(string nameOfTheClass, params string[] fieldsToInvestigate)
        {
            StringBuilder sb = new StringBuilder();

            Type type = Type.GetType(nameOfTheClass);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance 
                    | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);

            sb.AppendLine($"Class under investigation: {nameOfTheClass}");
            Object classInstance = Activator.CreateInstance(type, new object[] { });

            foreach (var field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString();
        }
    }
}
