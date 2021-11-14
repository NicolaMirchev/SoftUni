using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_exercise
{
    interface ILogger
    {
        IAppender Appender { get; set; }
    }
}
