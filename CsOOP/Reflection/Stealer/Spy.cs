using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    class Spy
    {
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
