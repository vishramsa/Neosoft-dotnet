using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class positiveIntegerPrimeNumber
    {
        internal static void checkPrimeNumber(int number)
        {
            int temp,flag=0;
            temp = number / 2;
            for (int i = 2; i <= temp; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
    }
}
