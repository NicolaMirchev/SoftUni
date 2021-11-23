using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
   public class DataBaseCrashedException : Exception
    {
        public DataBaseCrashedException(string message) : base(message)
        { }

    }
}
