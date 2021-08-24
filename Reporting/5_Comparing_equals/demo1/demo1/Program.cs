using System;
using System.Text;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   // Example of comparison using == operator.
            Console.WriteLine("Using == operator :\n");
            var d1 = DateTime.Now.Date;
            var d2 = DateTime.Now.Date;
            Console.WriteLine("\t" + "Comparing dates :" + (d1 == d2) + "\n"); // Writes True


            object name = "neosoft";
            char[] values = { 'n', 'e', 'o', 's', 'o', 'f', 't' };
            object myName = new string(values);
            Console.WriteLine("\t== operator result is :{0} ", name == myName); //false 
            Console.WriteLine("\tEquals method result is :{0}\n ", myName.Equals(name)); //true

            string s1 = "Blue";
            var sb = new StringBuilder("Bl");
            sb.Append("ue");
            string s2 = sb.ToString();
            Console.WriteLine("\tUsing == operator :" + (s1 == s2)); // True
            Console.WriteLine("\tUsing ReferenceEquals() :" + (object.ReferenceEquals(s1, s2))); // False


            // Example of comparison using Equals() method.
            Console.WriteLine("\nUsing Equals() :\n");
            object o = ".NET";
            object o1 = o;
            // object o1= new string(".NET".ToCharArray());
            Console.WriteLine("\t" + (o == o1) + ": is the value returned by == operator .");
            Console.WriteLine("\t" + o.Equals(o1) + ": is the value returned by Equals() .");



            // Example of comparison using ReferenceEquals() method. 
            Console.WriteLine("\nUsing ReferenceEquals() :\n");
            object n = null;
            object p = null;
            object q = new Object();

            Console.WriteLine("\t" + (Object.ReferenceEquals(n, p)));//true
            p = q;
            Console.WriteLine("\t" + (Object.ReferenceEquals(p, q)));//true  


            // Example of comparison using CompareTo() method. 
            Console.WriteLine("\nUsing CompareTo() :\n");
            int val1 = 10;
            int val2 = 10;
            int val3 = 11;
            int val4 = 13;
            Console.WriteLine($"\t Value 1 = {val1}");
            Console.WriteLine($"\tValue 2 = {val2}");
            Console.WriteLine($"\tValue 3 = {val3}");
            Console.WriteLine($"\tValue 4 = {val4}\n");

            Console.WriteLine("\t" + (CompareValue(val1, val2)));
            Console.WriteLine("\t" + (CompareValue(val1, val3)));
            Console.WriteLine("\t" + (CompareValue(val4, val3)));


            string strFirst = "Firststring";
            string strSecond = "Secondstring";
            string strThird = "thirdstring";
            string strFourth = "fourthstring";
            string strFifth = "Byebye";

            // Compare a string to itself.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFirst)));

            //compare a string with other string
            Console.WriteLine("\t" + (CompareStrings(strFirst, strSecond)));
            Console.WriteLine("\t" + (CompareStrings(strFirst, strThird)));
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFifth)));

            // Compare a string to another string that varies only by case.
            Console.WriteLine("\t" + (CompareStrings(strFirst, strFourth)));
            Console.WriteLine("\t" + (CompareStrings(strFourth, strFirst)));



            static string CompareStrings(string str1, string str2)
            {
                // Compare the values, using the CompareTo method on the string.
                int cmpVal = str1.CompareTo(str2);

                if (cmpVal == 0) // The strings are the same.
                    return $"\n \t{str1} and {str2} occur in the same position in the sort order.";
                else if (cmpVal < 0)
                    return $"\n \t{str1} precedes {str2} in the sort order.";
                else
                    return $"\n \t{str1} follows {str2} in the sort order.";
            }

            static string CompareValue(int val1, int val2)
            {
                // Compare the values, using the CompareTo method on integer value
                int objVal = val1.CompareTo(val2);

                if (objVal == 0) // The values are same.
                    return $"{val1} and {val2} both are equal";
                else if (objVal < 0)
                    return $"{val1} is less than {val2}";
                else
                    return $"{val1} is greater than {val2}";
            }


        }
    }
}



