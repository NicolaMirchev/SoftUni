using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;

        public MyRangeAttribute(int min, int max)
        {
            minValue = min;
            maxValue = max;
        }

        public override bool IsValid(object obj)
        {
            Type type = Type.GetType(obj.ToString());

            return true;
        }


    }
}
