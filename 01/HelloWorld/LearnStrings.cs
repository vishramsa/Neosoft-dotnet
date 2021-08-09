using System.Text;
namespace HelloWorld
{
    public class LearnStrings
    {
        internal static void GetStrings(){
            string str = "Hello";//string.Empty; //"";
            string str1 ="World";// null;
            // System.Console.WriteLine(str.Length);
            // System.Console.WriteLine(str == str1);
            //System.Console.WriteLine(str+" "+str1); // + operator to concat strings
            StringBuilder sb = new StringBuilder("My favorite pet is Cat");
            sb[19] = 'R';
            sb.Append(". Although Dogs are faithful.");
            System.Console.WriteLine(sb.ToString());
            
        }
        internal static void PrintBackwards(string s){
            for (int i = 0; i < s.Length; i++)
            {
                System.Console.Write(s[s.Length-i-1]);
            }
        }
    }
}