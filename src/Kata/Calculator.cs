using System;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number = "")
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;                
            }
            
            if (number.Split(",").Length > 1)
            {
                int number1 = Int32.Parse(number.Split(",")[0]);
                int number2 = Int32.Parse(number.Split(",")[1]);
                return number1 + number2;
            }
            
            return Int32.Parse(number);
        }
    }
}