
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    internal class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] data = args.Split(' ');

            ICommand command = null;

            if (Assembly.GetCallingAssembly().GetTypes().Any(t => t.Name == data[0] + "Command"))
            {
                Type type = Assembly
                    .GetCallingAssembly()
                    .GetTypes()
                    .Where(t => t.Name == data[0] + "Command")
                    .FirstOrDefault();

                command = (ICommand)Activator.CreateInstance(type);                                
            }
            else
            {
                throw new InvalidOperationException("No such command");
            }

            return command.Execute(data[1..]);
            
        }
    }
}