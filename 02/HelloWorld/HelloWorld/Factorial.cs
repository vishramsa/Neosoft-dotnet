using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Factorial
    {
       internal static int calculateFactorialUsingRecursion(int number)
        {

            if (number == 0) return 1;
            else if (number == 1) return number;
            else if (number < 0) return 0;
            
            return number * calculateFactorialUsingRecursion(number - 1);
        }
        internal static int calculateFactorialUsingForLoop(int number)
        {
            int result = 1;
            if (number == 0) return 1;
            else if(number < 0)    return 0;
  
            for (int i = number; i >= 1; i--) result *= i;
            return result;
        }
    }
}
