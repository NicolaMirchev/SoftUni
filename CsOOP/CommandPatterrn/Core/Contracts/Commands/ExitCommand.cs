using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.CommandPatterrn.Core.Contracts
{
    class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
