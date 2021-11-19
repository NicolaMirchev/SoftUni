using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidationAttributes
{
    class MyRequiredAttribute : MyValidationAttribute 
    {
        public override bool IsValid(object obj)
        {
            Type type = Type.GetType(obj.ToString());


            if (type.CustomAttributes.Any(a => a.AttributeType.Name == "MyValidationAttribute")) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
