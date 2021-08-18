using System;

namespace MiscelleaneousTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            //DelArea del=new DelArea(Shape.SquareArea);
            // Func<double,double> del=new Func<double, double>(Shape.SquareArea);//predefined delegates
            // Action<double> del1;
            // Predicate<double> del2;
            // del += Shape.CircleArea; //multicast delegate
            // del(7); //del.Invoke(5); 
            //Shape.delSqArea(5);
            Console.WriteLine(Shape.delCircleArea(7));
        }
    }
}
