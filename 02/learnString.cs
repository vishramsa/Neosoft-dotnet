using System;
using System.Text;

namespace HelloWorld{
    public class LearnString{
        internal static void getString(){
        //     string str=string.Empty;//"";
        //     Console.WriteLine(str.Length);
        //     string str2=null;
           
        //     Console.WriteLine(str==str2);
        //     string str3="hello",str4=" World";
        //     Console.WriteLine(str3+" "+str4);
        //    Console.WriteLine(str3.Contains("llo"));
        StringBuilder sb = new StringBuilder("My favourite pet is Cat");
      
        sb[20]='R';
        sb.Append(". Although Dogs are faithful");
        Console.WriteLine(sb.ToString());

        }
        internal static void PrintBackwards(string s){
            for(int i=0; i<s.Length; i++){
                Console.Write(s[s.Length-i-1]);
            }
        }
    }
}