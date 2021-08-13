using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Coding
    {
        internal static int GetFactorial(ref int n) //5
        {
            n=5;
            int result = 1;
            for (int i = n; i >= 1; i--)
            {
                result *= i; // result = result * i
            }
            return result;
        }
        internal static int GetFactorial_Recursive(int n)
        {
            if (n == 0)
                return 1;
            return n * GetFactorial_Recursive(n - 1);//3*2*1*1
        }
            
    }
}
