using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_MaxFloat
{
    public class MaxFloatNumber
    {
        public static double MaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if(firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0)
            {
                return firstValue;
            }
            if(secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if(thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("first Number, second Number, third Number are same");
        }
    }
}
